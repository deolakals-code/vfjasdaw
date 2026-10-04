// Assembly: mscorlib.dll
// Namespace: Mono.Globalization.Unicode
internal class SimpleCollator : ISimpleCollator // TypeDefIndex: 9468
{
	// Fields
	private static SimpleCollator invariant; // 0x0
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C

	// Methods

	// RVA: 0x2E6B188 Offset: 0x2E67188 VA: 0x2E6B188
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x2E6B4D4 Offset: 0x2E674D4 VA: 0x2E6B4D4
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x2E6B5B0 Offset: 0x2E675B0 VA: 0x2E6B5B0
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x2E6B620 Offset: 0x2E67620 VA: 0x2E6B620
	private byte Category(int cp) { }

	// RVA: 0x2E6B6B4 Offset: 0x2E676B4 VA: 0x2E6B6B4
	private byte Level1(int cp) { }

	// RVA: 0x2E6B748 Offset: 0x2E67748 VA: 0x2E6B748
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x2E6B87C Offset: 0x2E6787C VA: 0x2E6B87C
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x2E6B8F0 Offset: 0x2E678F0 VA: 0x2E6B8F0
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x2E6B9B0 Offset: 0x2E679B0 VA: 0x2E6B9B0
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x2E6BAD8 Offset: 0x2E67AD8 VA: 0x2E6BAD8
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x2E6BB98 Offset: 0x2E67B98 VA: 0x2E6BB98
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x2E6BD80 Offset: 0x2E67D80 VA: 0x2E6BD80
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x2E6BE64 Offset: 0x2E67E64 VA: 0x2E6BE64
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x2E6BF64 Offset: 0x2E67F64 VA: 0x2E6BF64
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x2E6BF84 Offset: 0x2E67F84 VA: 0x2E6BF84
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x2E6C194 Offset: 0x2E68194 VA: 0x2E6C194
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x2E6C210 Offset: 0x2E68210 VA: 0x2E6C210
	private bool IsSafe(int i) { }

	// RVA: 0x2E6C26C Offset: 0x2E6826C VA: 0x2E6C26C Slot: 4
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x2E6C28C Offset: 0x2E6828C VA: 0x2E6C28C
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x2E6C570 Offset: 0x2E68570 VA: 0x2E6C570
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x2E6C988 Offset: 0x2E68988 VA: 0x2E6C988
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x2E6CEF8 Offset: 0x2E68EF8 VA: 0x2E6CEF8
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x2E6D044 Offset: 0x2E69044 VA: 0x2E6D044 Slot: 5
	private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x2E6D048 Offset: 0x2E69048 VA: 0x2E6D048
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x2E6C90C Offset: 0x2E6890C VA: 0x2E6C90C
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x2E6D0F8 Offset: 0x2E690F8 VA: 0x2E6D0F8
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6E51C Offset: 0x2E6A51C VA: 0x2E6E51C
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x2E6E538 Offset: 0x2E6A538 VA: 0x2E6E538 Slot: 6
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x2E6E558 Offset: 0x2E6A558 VA: 0x2E6E558
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x2E6E604 Offset: 0x2E6A604 VA: 0x2E6E604
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6E66C Offset: 0x2E6A66C VA: 0x2E6E66C Slot: 7
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x2E6E68C Offset: 0x2E6A68C VA: 0x2E6E68C
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x2E6E8A8 Offset: 0x2E6A8A8 VA: 0x2E6E8A8
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x2E6EA10 Offset: 0x2E6AA10 VA: 0x2E6EA10 Slot: 8
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x2E6F0A8 Offset: 0x2E6B0A8 VA: 0x2E6F0A8
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x2E6F180 Offset: 0x2E6B180 VA: 0x2E6F180
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x2E6F1F0 Offset: 0x2E6B1F0 VA: 0x2E6F1F0
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6EC00 Offset: 0x2E6AC00 VA: 0x2E6EC00
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6E720 Offset: 0x2E6A720 VA: 0x2E6E720 Slot: 9
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x2E6F984 Offset: 0x2E6B984 VA: 0x2E6F984
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x2E6FAB8 Offset: 0x2E6BAB8 VA: 0x2E6FAB8
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6F458 Offset: 0x2E6B458 VA: 0x2E6F458
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6F28C Offset: 0x2E6B28C VA: 0x2E6F28C
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E6FD34 Offset: 0x2E6BD34 VA: 0x2E6FD34
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E70090 Offset: 0x2E6C090 VA: 0x2E70090
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x2E6FB5C Offset: 0x2E6BB5C VA: 0x2E6FB5C
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E702B8 Offset: 0x2E6C2B8 VA: 0x2E702B8
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x2E70758 Offset: 0x2E6C758 VA: 0x2E70758
	private static void .cctor() { }
}
