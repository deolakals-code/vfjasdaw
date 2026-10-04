"""Who reads each BonusType?  Scans the exec segment of libil2cpp for the constant id (movz / cmp / add / sub immediates, the same method as scan_const.py)
and lists the functions that contain it, minus enum plumbing (.cctor, packet GetValue/SetValue, System.*).

An immediate equal to the id is a candidate, not proof (small ids collide with unrelated constants), so the list is filtered by name only; a consumer is confirmed by
decoding the function (decode_fn.py). Output: player_status/bonus_consumers.json = {bonusName: [function, ...]} for the 115 item stat lines.

Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\bonus_consumers.py" [name ...]
"""
import sys, re, json, struct, bisect, collections

sys.path.insert(0, r"D:\toram reverse data\scripts")
sys.path.insert(0, r"D:\toram_re")
import dis_android as D
import il2
import player_status as P

OUT = r"D:\toram reverse data\player_status\bonus_consumers.json"
NOISE = re.compile(r"\.cctor|\$\$(Get|Set)Value$|GetPacket|\$\$Create|^System\.|^Toram\.Common\.(Operations|Events|Parameters|Orbs)|DecimalConverter|XmlConvert|\$\$ctor|MoveNext|get_Code$")


def main():
    gear = json.load(open(r"D:\toram reverse data\gear\gear.json", encoding="utf-8"))
    names = sys.argv[1:] or sorted(b["k"] for b in gear["bonuses"])
    ids = {n: i for i, n in P.BONUS_BY_ID.items()}
    want = {ids[n]: n for n in names}
    s, e = il2.TEXT_RANGE
    code = D.b[s:e]
    res = collections.defaultdict(set)
    for i in range(0, len(code) - 3, 4):
        w = struct.unpack_from("<I", code, i)[0]
        imm = None
        if ((w >> 23) & 0x1ff) in (0b010100101, 0b110100101) and ((w >> 21) & 3) == 0:
            imm = (w >> 5) & 0xffff
        elif ((w >> 24) & 0x7f) in (0x11, 0x31, 0x51, 0x71) and (w >> 22) & 3 == 0:
            imm = (w >> 10) & 0xfff
        if imm in want:
            j = bisect.bisect_right(D.starts, s + i + D.OFF) - 1
            fn = D.names.get(D.starts[j], hex(D.starts[j]))
            if not NOISE.search(fn):
                res[want[imm]].add(fn)
    out = {n: sorted(res.get(n, [])) for n in names}
    if not sys.argv[1:]:
        json.dump(out, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    for n in names:
        print(n, ids[n], len(out[n]))
        for f in out[n][:12]:
            print("    ", f)


if __name__ == "__main__":
    main()
