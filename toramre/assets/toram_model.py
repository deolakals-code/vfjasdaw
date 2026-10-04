"""Toram's own model format (items, costumes, NPCs), stored as an XOR-encoded TextAsset inside the model bundles.
Moved from scripts/export_models.py (2026-10-04) so the program and the old scripts share one copy.
Format notes and evidence labels are unchanged from the original."""
import math
import os
import re
import struct

from PIL import Image, ImageDraw


class Reader:
    def __init__(self, b, o=0): self.b, self.o = b, o
    def u8(self): self.o += 1; return self.b[self.o - 1]
    def u16(self): self.o += 2; return struct.unpack_from("<H", self.b, self.o - 2)[0]
    def u32(self): self.o += 4; return struct.unpack_from("<I", self.b, self.o - 4)[0]
    def pstr(self): n = self.u8(); self.o += n; return self.b[self.o - n:self.o].decode("utf-8", "replace")

    def arr(self, fmt, n):
        size = struct.calcsize(fmt) * n
        self.o += size
        return list(struct.iter_unpack(fmt, self.b[self.o - size:self.o]))


# MaterialProperty ids (tag) -> payload size; 100 MainTexture, 101 SubTexture, 102 RenderQueue, 103 Layer,
# 104..106 ChangeColorR/G/B (dye palette, RGB24), 107 UVSpeed
PROP_SIZE = {100: 1, 101: 1, 102: 2, 103: 2, 104: 3, 105: 3, 106: 3, 107: 2}
# MaterialDataType: 0 Skin, 1 Face, 2 Hair carry no texture (the character's own colours fill them);
# 3/5/7 are normal textured, 4/6/8 alpha ones whose RGB textures use black as empty -> drawn additively
KIND = {0: "skin", 1: "face", 2: "hair", 3: "opaque", 4: "add", 5: "opaque", 6: "add", 7: "opaque", 8: "add"}


def parse_model(b):
    # header: <u8 ver><u8 nsec> nsec x <u8 id><u32 offset><u32>; ModelDataType 1 = meshes, 2 = materials, 3 = textures
    r = Reader(b)
    ver, nsec = r.u8(), r.u8()
    secs = {}
    for _ in range(nsec):
        sid, off = r.u8(), r.u32(); r.u32()
        secs[sid] = off
    r.o = secs[3]
    textures = []
    for _ in range(r.u8()):
        # ver2 record: <u8 index><u8 format: 1 = RGBA32>; ver1: <u8 index>, always RGB24
        r.u8(); mode = ("RGB", "RGBA")[r.u8()] if ver >= 2 else "RGB"
        w, h = r.u16(), r.u16()
        size = w * h * len(mode)
        textures.append(Image.frombytes(mode, (w, h), b[r.o:r.o + size])); r.o += size
    r.o = secs[2]
    materials = {}
    for _ in range(r.u8()):
        idx, typ, props = r.u8(), r.u8(), {}
        for _ in range(r.u8()):
            tag = r.u8(); props[tag] = b[r.o:r.o + PROP_SIZE[tag]]; r.o += PROP_SIZE[tag]
        tex = props[100][0] if 100 in props else -1
        dye = [props[t].hex() for t in (104, 105, 106)] if all(t in props for t in (104, 105, 106)) else None
        materials[idx] = (KIND.get(typ, "opaque"), tex if 0 <= tex < len(textures) else -1, dye)
    r.o = secs[1]
    heads = []
    for _ in range(r.u8()):
        name, off = r.pstr(), r.u32(); r.u32()
        heads.append((name, off))
    meshes = []
    for name, off in heads:
        r.o = off
        n = r.u16()
        pos = r.arr("<3f", n)
        col = r.arr("<4B", n)                 # byte 0 unknown; bytes 1..3 = weight of dye slot R/G/B (ChangeColorR/G/B)
        uv = r.arr("<2f", n); r.o += 8 * n   # second per-vertex float pair, unidentified
        for _ in range(r.u8()):
            r.pstr()                          # bone names
        for _ in range(n):                    # skin: <u8 k> then 1 bone, or k x (bone, weight %)
            k = r.u8(); r.o += 1 if k == 1 else 2 * k
        subs = []
        for _ in range(r.u8()):
            mat, cnt = r.u8(), r.u16()
            idx = [i for (i,) in r.arr("<H", cnt)]
            if idx and max(idx) >= n:
                raise ValueError("index out of range")
            subs.append((mat, idx))
        meshes.append((name, pos, uv, subs, col))
    return textures, meshes, materials


def default_variant(meshes):
    # body/cos files hold one full character per variant, all in the same space: mesh names end in _<n>
    # where odd n is the female build (inferred from silhouettes), and armours prefix h_/m_/l_ for the
    # heavy/normal/light armour modes. Keep the male normal build for previews.
    names = [n for n, *_ in meshes]
    keep = [m for m in meshes if not re.search(r"_\d+$", m[0]) or int(m[0].rsplit("_", 1)[1]) % 2 == 0]
    if any(n.startswith("m_") for n in names):
        keep = [m for m in keep if m[0].startswith("m_")]
    return keep or meshes


def dye_tint(dye, cols):
    # colour multiplier = product over dye slots of lerp(white, slot colour, vertex weight); inferred, not from shader code
    if not dye:
        return (1.0, 1.0, 1.0)
    out = [1.0, 1.0, 1.0]
    for s in range(3):
        w = sum(c[s + 1] for c in cols) / (255 * len(cols))
        rgb = bytes.fromhex(dye[s])
        for ch in range(3):
            out[ch] *= 1 - w + w * rgb[ch] / 255
    return tuple(out)


def render(textures, meshes, materials, size=256, yaw=0.7, pitch=0.35):
    cy, sy, cp, sp = math.cos(yaw), math.sin(yaw), math.cos(pitch), math.sin(pitch)
    tris = []
    for _, pos, uv, subs, col in default_variant(meshes):
        rot = []
        for x, z, y in pos:  # models are Z-up
            x, z = x * cy - z * sy, x * sy + z * cy
            y, z = y * cp - z * sp, y * sp + z * cp
            rot.append((x, y, z))
        for mat, idx in subs:
            kind, t, dye = materials.get(mat, ("opaque", -1, None))
            if kind == "add":
                continue
            tex = textures[t].convert("RGB") if t >= 0 else None
            for k in range(0, len(idx) - 2, 3):
                tint = dye_tint(dye, [col[i] for i in idx[k:k + 3]])
                tris.append(([rot[i] for i in idx[k:k + 3]], [uv[i] for i in idx[k:k + 3]], tex, tint))
    if not tris:
        return None
    xs = [p[0] for t in tris for p in t[0]]; ys = [p[1] for t in tris for p in t[0]]
    scale = (size - 16) / max(max(xs) - min(xs), max(ys) - min(ys), 1e-6)
    cx, cy2 = (max(xs) + min(xs)) / 2, (max(ys) + min(ys)) / 2
    img = Image.new("RGBA", (size, size), (0, 0, 0, 0))
    d = ImageDraw.Draw(img)
    # ponytail: painter's algorithm with per-face colour, no z-buffer or per-pixel texturing; use the OBJ for real renders
    for p, t, tex, tint in sorted(tris, key=lambda t: sum(v[2] for v in t[0])):
        ax, ay, az = (p[1][i] - p[0][i] for i in range(3))
        bx, by, bz = (p[2][i] - p[0][i] for i in range(3))
        nx, ny, nz = ay * bz - az * by, az * bx - ax * bz, ax * by - ay * bx
        light = 0.45 + 0.55 * abs(nx * 0.3 + ny * 0.6 - nz * 0.74) / (math.sqrt(nx * nx + ny * ny + nz * nz) or 1)
        if tex:
            u = sum(q[0] for q in t) / 3 % 1; v = sum(q[1] for q in t) / 3 % 1
            c = tex.getpixel((min(tex.width - 1, int(u * tex.width)), min(tex.height - 1, int(v * tex.height))))  # rows stored bottom-up
        else:
            c = (180, 180, 180)
        d.polygon([(size / 2 + (q[0] - cx) * scale, size / 2 - (q[1] - cy2) * scale) for q in p],
                  fill=tuple(int(ch * light * k) for ch, k in zip(c, tint)))
    return img


def write_obj(path, name, textures, meshes, materials):
    base = os.path.join(path, name)
    for i, t in enumerate(textures):
        t.transpose(Image.Transpose.FLIP_TOP_BOTTOM).save(f"{base}_{i}.png")
    with open(base + ".mtl", "w", encoding="utf-8") as f:
        for mat, (kind, t, dye) in sorted(materials.items()):
            # "# kind" / "# dye" are ours (build-models-pak.mjs reads them); OBJ readers skip comments
            f.write(f"newmtl m{mat}\n# kind {kind}\n" + (f"# dye {' '.join(dye)}\n" if dye else "")
                    + (f"map_Kd {name}_{t}.png\n" if t >= 0 else ""))
    with open(base + ".obj", "w", encoding="utf-8") as f:
        f.write(f"mtllib {name}.mtl\n")
        vbase = 1
        for mesh, pos, uv, subs, col in meshes:
            f.write(f"o {mesh}\n")
            # vertex "colour" = dye slot weights 0..1 (the common OBJ "v x y z r g b" extension)
            f.writelines(f"v {x:.5f} {y:.5f} {z:.5f} {c[1] / 255:.3f} {c[2] / 255:.3f} {c[3] / 255:.3f}\n"
                         for (x, y, z), c in zip(pos, col))
            f.writelines(f"vt {u:.5f} {v:.5f}\n" for u, v in uv)
            for mat, idx in subs:
                f.write(f"usemtl m{mat}\n")
                f.writelines("f " + " ".join(f"{vbase + i}/{vbase + i}" for i in idx[k:k + 3]) + "\n"
                             for k in range(0, len(idx) - 2, 3))
            vbase += len(pos)


