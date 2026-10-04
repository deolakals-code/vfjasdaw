// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
internal sealed class InfTree // TypeDefIndex: 17169
{
	// Fields
	internal static readonly int[] fixed_tl; // 0x0
	internal static readonly int[] fixed_td; // 0x8
	internal static readonly int[] cplens; // 0x10
	internal static readonly int[] cplext; // 0x18
	internal static readonly int[] cpdist; // 0x20
	internal static readonly int[] cpdext; // 0x28
	internal int[] hn; // 0x10
	internal int[] v; // 0x18
	internal int[] c; // 0x20
	internal int[] r; // 0x28
	internal int[] u; // 0x30
	internal int[] x; // 0x38

	// Methods

	// RVA: 0x2E3E080 Offset: 0x2E3A080 VA: 0x2E3E080
	private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v) { }

	// RVA: 0x2E3BEF8 Offset: 0x2E37EF8 VA: 0x2E3BEF8
	internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z) { }

	// RVA: 0x2E3C014 Offset: 0x2E38014 VA: 0x2E3C014
	internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z) { }

	// RVA: 0x2E3BDB0 Offset: 0x2E37DB0 VA: 0x2E3BDB0
	internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z) { }

	// RVA: 0x2E3E800 Offset: 0x2E3A800 VA: 0x2E3E800
	private void initWorkArea(int vsize) { }

	// RVA: 0x2E3AA80 Offset: 0x2E36A80 VA: 0x2E3AA80
	public void .ctor() { }

	// RVA: 0x2E3E9C8 Offset: 0x2E3A9C8 VA: 0x2E3E9C8
	private static void .cctor() { }
}
