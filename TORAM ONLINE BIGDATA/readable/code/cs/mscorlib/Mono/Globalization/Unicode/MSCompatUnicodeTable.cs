// Assembly: mscorlib.dll
// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTable // TypeDefIndex: 9461
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x2E68A84 Offset: 0x2E64A84 VA: 0x2E68A84
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x2E68B88 Offset: 0x2E64B88 VA: 0x2E68B88
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x2E692FC Offset: 0x2E652FC VA: 0x2E692FC
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x2E69580 Offset: 0x2E65580 VA: 0x2E69580
	public static byte Category(int cp) { }

	// RVA: 0x2E69624 Offset: 0x2E65624 VA: 0x2E69624
	public static byte Level1(int cp) { }

	// RVA: 0x2E696C8 Offset: 0x2E656C8 VA: 0x2E696C8
	public static byte Level2(int cp) { }

	// RVA: 0x2E6976C Offset: 0x2E6576C VA: 0x2E6976C
	public static byte Level3(int cp) { }

	// RVA: 0x2E69810 Offset: 0x2E65810 VA: 0x2E69810
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x2E69928 Offset: 0x2E65928 VA: 0x2E69928
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x2E69980 Offset: 0x2E65980 VA: 0x2E69980
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x2E69998 Offset: 0x2E65998 VA: 0x2E69998
	public static int ToWidthCompat(int i) { }

	// RVA: 0x2E69B24 Offset: 0x2E65B24 VA: 0x2E69B24
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x2E69BA4 Offset: 0x2E65BA4 VA: 0x2E69BA4
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x2E69BB8 Offset: 0x2E65BB8 VA: 0x2E69BB8
	public static bool IsHiragana(char c) { }

	// RVA: 0x2E69BD0 Offset: 0x2E65BD0 VA: 0x2E69BD0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x2E69CB8 Offset: 0x2E65CB8 VA: 0x2E69CB8
	public static bool get_IsReady() { }

	// RVA: 0x2E69D10 Offset: 0x2E65D10 VA: 0x2E69D10
	private static IntPtr GetResource(string name) { }

	// RVA: 0x2E69DC8 Offset: 0x2E65DC8 VA: 0x2E69DC8
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x2E69DF8 Offset: 0x2E65DF8 VA: 0x2E69DF8
	private static void .cctor() { }

	// RVA: 0x2E6A25C Offset: 0x2E6625C VA: 0x2E6A25C
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x2E6A3BC Offset: 0x2E663BC VA: 0x2E6A3BC
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}
