// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
internal sealed class InflateBlocks // TypeDefIndex: 17164
{
	// Fields
	internal static readonly int[] border; // 0x0
	private InflateBlocks.InflateBlockMode mode; // 0x10
	internal int left; // 0x14
	internal int table; // 0x18
	internal int index; // 0x1C
	internal int[] blens; // 0x20
	internal int[] bb; // 0x28
	internal int[] tb; // 0x30
	internal InflateCodes codes; // 0x38
	internal int last; // 0x40
	internal ZlibCodec _codec; // 0x48
	internal int bitk; // 0x50
	internal int bitb; // 0x54
	internal int[] hufts; // 0x58
	internal byte[] window; // 0x60
	internal int end; // 0x68
	internal int readAt; // 0x6C
	internal int writeAt; // 0x70
	internal object checkfn; // 0x78
	internal uint check; // 0x80
	internal InfTree inftree; // 0x88

	// Methods

	// RVA: 0x2E3A8E8 Offset: 0x2E368E8 VA: 0x2E3A8E8
	internal void .ctor(ZlibCodec codec, object checkfn, int w) { }

	// RVA: 0x2E3AA88 Offset: 0x2E36A88 VA: 0x2E3AA88
	internal uint Reset() { }

	// RVA: 0x2E3AB38 Offset: 0x2E36B38 VA: 0x2E3AB38
	internal int Process(int r) { }

	// RVA: 0x2E3CCD4 Offset: 0x2E38CD4 VA: 0x2E3CCD4
	internal void Free() { }

	// RVA: 0x2E3BC1C Offset: 0x2E37C1C VA: 0x2E3BC1C
	internal int Flush(int r) { }

	// RVA: 0x2E3CD04 Offset: 0x2E38D04 VA: 0x2E3CD04
	private static void .cctor() { }
}
