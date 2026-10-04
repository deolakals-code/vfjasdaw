// Toram Online client-data decoder (C#), mirrors tools/decode.py. Offline use on files copied from the game cache.
// Bundle layout: outer UnityFS holds TextAssets; each asset is XOR-obfuscated with a per-bundle key.
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public static class ToramDecoder
{
    // key = last 8 hex chars of the cache version dir name, e.g. "02dc3f32" -> 0x02dc3f32
    public static byte[] Decode(byte[] c, uint verHash)
    {
        byte[] key = BitConverter.GetBytes(verHash);          // little-endian
        var p = (byte[])c.Clone();
        int n = c.Length - c.Length % 4;                       // trailing len%4 bytes are stored plain
        for (int j = 0; j < n; j++)
            p[j] = (byte)(c[j] ^ (j >= 4 ? c[j - 4] : 0) ^ key[j & 3]);
        return p;
    }

    public record TextRow(uint Id, int No, byte Kind, string Text);

    // `*_th` style tables: <u32 count> then <u32 id><u8 kind>[<u8 no> when quest kind != 0]<7-bit varint len><utf8>
    public static List<TextRow> ReadText(byte[] d, bool hasNo = false)
    {
        var r = new BinaryReader(new MemoryStream(d));
        uint count = r.ReadUInt32();
        var rows = new List<TextRow>();
        for (uint i = 0; i < count; i++)
        {
            uint id = r.ReadUInt32();
            byte kind = r.ReadByte();
            int no = hasNo && kind != 0 ? r.ReadByte() : 0;
            int len = Read7Bit(r);
            rows.Add(new TextRow(id, no, kind, Encoding.UTF8.GetString(r.ReadBytes(len))));
        }
        return rows;
    }

    static int Read7Bit(BinaryReader r)
    {
        int n = 0, s = 0; byte b;
        do { b = r.ReadByte(); n |= (b & 0x7f) << s; s += 7; } while (b >= 0x80);
        return n;
    }
}
