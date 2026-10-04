// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
internal sealed class Tree // TypeDefIndex: 17170
{
	// Fields
	private static readonly int HEAP_SIZE; // 0x0
	internal static readonly int[] ExtraLengthBits; // 0x8
	internal static readonly int[] ExtraDistanceBits; // 0x10
	internal static readonly int[] extra_blbits; // 0x18
	internal static readonly sbyte[] bl_order; // 0x20
	private static readonly sbyte[] _dist_code; // 0x28
	internal static readonly sbyte[] LengthCode; // 0x30
	internal static readonly int[] LengthBase; // 0x38
	internal static readonly int[] DistanceBase; // 0x40
	internal short[] dyn_tree; // 0x10
	internal int max_code; // 0x18
	internal StaticTree staticTree; // 0x20

	// Methods

	// RVA: 0x2E36648 Offset: 0x2E32648 VA: 0x2E36648
	internal static int DistanceCode(int dist) { }

	// RVA: 0x2E3EBCC Offset: 0x2E3ABCC VA: 0x2E3EBCC
	internal void gen_bitlen(DeflateManager s) { }

	// RVA: 0x2E357A8 Offset: 0x2E317A8 VA: 0x2E357A8
	internal void build_tree(DeflateManager s) { }

	// RVA: 0x2E3EF54 Offset: 0x2E3AF54 VA: 0x2E3EF54
	internal static void gen_codes(short[] tree, int max_code, short[] bl_count) { }

	// RVA: 0x2E3F12C Offset: 0x2E3B12C VA: 0x2E3F12C
	internal static int bi_reverse(int code, int len) { }

	// RVA: 0x2E34CC4 Offset: 0x2E30CC4 VA: 0x2E34CC4
	public void .ctor() { }

	// RVA: 0x2E3F154 Offset: 0x2E3B154 VA: 0x2E3F154
	private static void .cctor() { }
}
