// Assembly: mscorlib.dll
// Namespace: System.Text
internal class Normalization // TypeDefIndex: 10063
{
	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x2EA0188 Offset: 0x2E9C188 VA: 0x2EA0188
	private static uint PropValue(int cp) { }

	// RVA: 0x2EA021C Offset: 0x2E9C21C VA: 0x2EA021C
	private static int CharMapIdx(int cp) { }

	// RVA: 0x2EA02B0 Offset: 0x2E9C2B0 VA: 0x2EA02B0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x2EA0358 Offset: 0x2E9C358 VA: 0x2EA0358
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x2EA0400 Offset: 0x2E9C400 VA: 0x2EA0400
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x2EA04A8 Offset: 0x2E9C4A8 VA: 0x2EA04A8
	private static string Compose(string source, int checkType) { }

	// RVA: 0x2EA06BC Offset: 0x2E9C6BC VA: 0x2EA06BC
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x2EA07F8 Offset: 0x2E9C7F8 VA: 0x2EA07F8
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x2EA0A3C Offset: 0x2E9CA3C VA: 0x2EA0A3C
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x2EA0E34 Offset: 0x2E9CE34 VA: 0x2EA0E34
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x2EA0C00 Offset: 0x2E9CC00 VA: 0x2EA0C00
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x2EA0E70 Offset: 0x2E9CE70 VA: 0x2EA0E70
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x2EA0F88 Offset: 0x2E9CF88 VA: 0x2EA0F88
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x2EA0588 Offset: 0x2E9C588 VA: 0x2EA0588
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x2EA1204 Offset: 0x2E9D204 VA: 0x2EA1204
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x2EA1014 Offset: 0x2E9D014 VA: 0x2EA1014
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x2EA0908 Offset: 0x2E9C908 VA: 0x2EA0908
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x2EA1638 Offset: 0x2E9D638 VA: 0x2EA1638
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x2EA1480 Offset: 0x2E9D480 VA: 0x2EA1480
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x2EA1724 Offset: 0x2E9D724 VA: 0x2EA1724
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x2EA17E0 Offset: 0x2E9D7E0 VA: 0x2EA17E0
	public static string Normalize(string source, int type) { }

	// RVA: 0x2EA1880 Offset: 0x2E9D880 VA: 0x2EA1880
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x2EA1884 Offset: 0x2E9D884 VA: 0x2EA1884
	private static void .cctor() { }
}
