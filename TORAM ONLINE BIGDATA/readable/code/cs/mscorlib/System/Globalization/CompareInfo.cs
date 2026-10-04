// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
public class CompareInfo : IDeserializationCallback // TypeDefIndex: 10765
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944;
	internal static readonly CompareInfo Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string m_name; // 0x10
	private string _sortName; // 0x18
	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion; // 0x20
	private int culture; // 0x28
	private ISimpleCollator collator; // 0x30
	private static Dictionary<string, ISimpleCollator> collators; // 0x8
	private static bool managedCollation; // 0x10
	private static bool managedCollationChecked; // 0x11

	// Properties
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x2F5FBE4 Offset: 0x2F5BBE4 VA: 0x2F5FBE4
	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x2F60044 Offset: 0x2F5C044 VA: 0x2F60044
	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x2F5FCA8 Offset: 0x2F5BCA8 VA: 0x2F5FCA8
	private static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start) { }

	// RVA: 0x2F60110 Offset: 0x2F5C110 VA: 0x2F60110
	private static char InvariantToUpper(char c) { }

	// RVA: 0x2F60128 Offset: 0x2F5C128 VA: 0x2F60128
	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x2F603D0 Offset: 0x2F5C3D0 VA: 0x2F603D0
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x2F60434 Offset: 0x2F5C434 VA: 0x2F60434
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializing]
	// RVA: 0x2F604EC Offset: 0x2F5C4EC VA: 0x2F604EC
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x2F604F8 Offset: 0x2F5C4F8 VA: 0x2F604F8 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[OnDeserialized]
	// RVA: 0x2F605AC Offset: 0x2F5C5AC VA: 0x2F605AC
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x2F604FC Offset: 0x2F5C4FC VA: 0x2F604FC
	private void OnDeserialized() { }

	[OnSerializing]
	// RVA: 0x2F605B0 Offset: 0x2F5C5B0 VA: 0x2F605B0
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2F6063C Offset: 0x2F5C63C VA: 0x2F6063C Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x2F606C8 Offset: 0x2F5C6C8 VA: 0x2F606C8 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x2F606D8 Offset: 0x2F5C6D8 VA: 0x2F606D8 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x2F60C68 Offset: 0x2F5CC68 VA: 0x2F60C68
	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x2F61064 Offset: 0x2F5D064 VA: 0x2F61064
	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2) { }

	// RVA: 0x2F61290 Offset: 0x2F5D290 VA: 0x2F61290 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x2F617DC Offset: 0x2F5D7DC VA: 0x2F617DC
	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	// RVA: 0x2F60978 Offset: 0x2F5C978 VA: 0x2F60978
	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x2F61AD4 Offset: 0x2F5DAD4 VA: 0x2F61AD4 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x2F61E5C Offset: 0x2F5DE5C VA: 0x2F61E5C Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x2F621E0 Offset: 0x2F5E1E0 VA: 0x2F621E0
	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x2F62244 Offset: 0x2F5E244 VA: 0x2F62244 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x2F622B0 Offset: 0x2F5E2B0 VA: 0x2F622B0 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x2F62560 Offset: 0x2F5E560 VA: 0x2F62560
	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x2F626D4 Offset: 0x2F5E6D4 VA: 0x2F626D4 Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x2F62A18 Offset: 0x2F5EA18 VA: 0x2F62A18
	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x2F62B50 Offset: 0x2F5EB50 VA: 0x2F62B50 Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x2F62CD0 Offset: 0x2F5ECD0 VA: 0x2F62CD0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2F62D90 Offset: 0x2F5ED90 VA: 0x2F62D90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F62DB8 Offset: 0x2F5EDB8 VA: 0x2F62DB8
	internal static int GetIgnoreCaseHash(string source) { }

	// RVA: 0x2F63204 Offset: 0x2F5F204 VA: 0x2F63204
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x2F633D0 Offset: 0x2F5F3D0 VA: 0x2F633D0 Slot: 15
	public virtual int GetHashCode(string source, CompareOptions options) { }

	// RVA: 0x2F634D0 Offset: 0x2F5F4D0 VA: 0x2F634D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F63530 Offset: 0x2F5F530 VA: 0x2F63530
	private static bool get_UseManagedCollation() { }

	// RVA: 0x2F6367C Offset: 0x2F5F67C VA: 0x2F6367C
	private ISimpleCollator GetCollator() { }

	// RVA: 0x2F639A4 Offset: 0x2F5F9A4 VA: 0x2F639A4
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x2F63ADC Offset: 0x2F5FADC VA: 0x2F63ADC
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x2F60B6C Offset: 0x2F5CB6C VA: 0x2F60B6C
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x2F63EAC Offset: 0x2F5FEAC VA: 0x2F63EAC
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x2F63CCC Offset: 0x2F5FCCC VA: 0x2F63CCC
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x2F63FAC Offset: 0x2F5FFAC VA: 0x2F63FAC
	private static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options) { }

	// RVA: 0x2F63DF8 Offset: 0x2F5FDF8 VA: 0x2F63DF8
	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x2F63FB0 Offset: 0x2F5FFB0 VA: 0x2F63FB0
	private static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first) { }

	// RVA: 0x2F63C18 Offset: 0x2F5FC18 VA: 0x2F63C18
	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	// RVA: 0x2F60418 Offset: 0x2F5C418 VA: 0x2F60418
	private void InitSort(CultureInfo culture) { }

	// RVA: 0x2F61950 Offset: 0x2F5D950 VA: 0x2F61950
	private static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2) { }

	// RVA: 0x2F626B4 Offset: 0x2F5E6B4 VA: 0x2F626B4
	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x2F62B30 Offset: 0x2F5EB30 VA: 0x2F62B30
	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x2F62B18 Offset: 0x2F5EB18 VA: 0x2F62B18
	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x2F62660 Offset: 0x2F5E660 VA: 0x2F62660
	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x2F61000 Offset: 0x2F5D000 VA: 0x2F61000
	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x2F611A0 Offset: 0x2F5D1A0 VA: 0x2F611A0
	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options) { }

	// RVA: 0x2F62C18 Offset: 0x2F5EC18 VA: 0x2F62C18
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x2F61CE8 Offset: 0x2F5DCE8 VA: 0x2F61CE8
	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	// RVA: 0x2F62070 Offset: 0x2F5E070 VA: 0x2F62070
	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	// RVA: 0x2F621E4 Offset: 0x2F5E1E4 VA: 0x2F621E4
	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x2F633A4 Offset: 0x2F5F3A4 VA: 0x2F633A4
	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	// RVA: 0x2F63FB8 Offset: 0x2F5FFB8 VA: 0x2F63FB8
	private static void .cctor() { }

	// RVA: 0x2F6404C Offset: 0x2F6004C VA: 0x2F6404C
	internal void .ctor() { }
}
