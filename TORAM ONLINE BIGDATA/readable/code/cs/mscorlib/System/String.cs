// Assembly: mscorlib.dll
// Namespace: System
[DefaultMember("Chars")]
[Serializable]
public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable // TypeDefIndex: 9509
{
	// Fields
	private const int StackallocIntBufferSizeLimit = 128;
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;
	private const int PROBABILISTICMAP_SIZE = 8;
	private int _stringLength; // 0x10
	private char _firstChar; // 0x14
	public static readonly string Empty; // 0x0

	// Properties
	public int Length { get; }
	public char Chars { get; }

	// Methods

	// RVA: 0x2E8049C Offset: 0x2E7C49C VA: 0x2E8049C
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x2E804D0 Offset: 0x2E7C4D0 VA: 0x2E804D0
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	// RVA: 0x2E80508 Offset: 0x2E7C508 VA: 0x2E80508
	private static int CompareOrdinalHelper(string strA, string strB) { }

	// RVA: 0x2E806C4 Offset: 0x2E7C6C4 VA: 0x2E806C4
	public static int Compare(string strA, string strB) { }

	// RVA: 0x2E8097C Offset: 0x2E7C97C VA: 0x2E8097C
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x2E806CC Offset: 0x2E7C6CC VA: 0x2E806CC
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x2E809A0 Offset: 0x2E7C9A0 VA: 0x2E809A0
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x2E80A38 Offset: 0x2E7CA38 VA: 0x2E80A38
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x2E80A48 Offset: 0x2E7CA48 VA: 0x2E80A48
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x2E80E68 Offset: 0x2E7CE68 VA: 0x2E80E68
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x2E80EAC Offset: 0x2E7CEAC VA: 0x2E80EAC
	internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x2E80F4C Offset: 0x2E7CF4C VA: 0x2E80F4C
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x2E81144 Offset: 0x2E7D144 VA: 0x2E81144 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2E81200 Offset: 0x2E7D200 VA: 0x2E81200 Slot: 7
	public int CompareTo(string strB) { }

	// RVA: 0x2E81208 Offset: 0x2E7D208 VA: 0x2E81208
	public bool EndsWith(string value) { }

	// RVA: 0x2E81210 Offset: 0x2E7D210 VA: 0x2E81210
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x2E814C8 Offset: 0x2E7D4C8 VA: 0x2E814C8
	public bool EndsWith(char value) { }

	// RVA: 0x2E81518 Offset: 0x2E7D518 VA: 0x2E81518 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E815BC Offset: 0x2E7D5BC VA: 0x2E815BC Slot: 8
	public bool Equals(string value) { }

	// RVA: 0x2E815FC Offset: 0x2E7D5FC VA: 0x2E815FC
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x2E81894 Offset: 0x2E7D894 VA: 0x2E81894
	public static bool Equals(string a, string b) { }

	// RVA: 0x2E818E0 Offset: 0x2E7D8E0 VA: 0x2E818E0
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x2E81B78 Offset: 0x2E7DB78 VA: 0x2E81B78
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x2E81B7C Offset: 0x2E7DB7C VA: 0x2E81B7C
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x2E81B94 Offset: 0x2E7DB94 VA: 0x2E81B94 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E81B98 Offset: 0x2E7DB98 VA: 0x2E81B98
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x2E81BE8 Offset: 0x2E7DBE8 VA: 0x2E81BE8
	public bool StartsWith(string value) { }

	// RVA: 0x2E81C40 Offset: 0x2E7DC40 VA: 0x2E81C40
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x2E80984 Offset: 0x2E7C984 VA: 0x2E80984
	internal static void CheckStringComparison(StringComparison comparisonType) { }

	// RVA: 0x2E81F10 Offset: 0x2E7DF10 VA: 0x2E81F10
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x2E81F90 Offset: 0x2E7DF90 VA: 0x2E81F90
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x2E82044 Offset: 0x2E7E044 VA: 0x2E82044
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x2E821FC Offset: 0x2E7E1FC VA: 0x2E821FC
	public static string Concat(object[] args) { }

	// RVA: 0x2E78D2C Offset: 0x2E74D2C VA: 0x2E78D2C
	public static string Concat(string str0, string str1) { }

	// RVA: 0x2E8213C Offset: 0x2E7E13C VA: 0x2E8213C
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x2E8245C Offset: 0x2E7E45C VA: 0x2E8245C
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x2E82564 Offset: 0x2E7E564 VA: 0x2E82564
	public static string Concat(string[] values) { }

	// RVA: 0x2E79944 Offset: 0x2E75944 VA: 0x2E79944
	public static string Format(string format, object arg0) { }

	// RVA: 0x2E8286C Offset: 0x2E7E86C VA: 0x2E8286C
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x2E828B0 Offset: 0x2E7E8B0 VA: 0x2E828B0
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x2E828F4 Offset: 0x2E7E8F4 VA: 0x2E828F4
	public static string Format(string format, object[] args) { }

	// RVA: 0x2E8299C Offset: 0x2E7E99C VA: 0x2E8299C
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x2E829F0 Offset: 0x2E7E9F0 VA: 0x2E829F0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x2E82A48 Offset: 0x2E7EA48 VA: 0x2E82A48
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x2E82AA4 Offset: 0x2E7EAA4 VA: 0x2E82AA4
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x2E82768 Offset: 0x2E7E768 VA: 0x2E82768
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x2E82B54 Offset: 0x2E7EB54 VA: 0x2E82B54
	public string Insert(int startIndex, string value) { }

	// RVA: 0x2E82C90 Offset: 0x2E7EC90 VA: 0x2E82C90
	public static string Join(string separator, string[] value) { }

	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F2528 Offset: 0x26EE528 VA: 0x26F2528
	|-String.Join<int>
	|
	|-RVA: 0x26F25A8 Offset: 0x26EE5A8 VA: 0x26F25A8
	|-String.Join<Int32Enum>
	|
	|-RVA: 0x26F2628 Offset: 0x26EE628 VA: 0x26F2628
	|-String.Join<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E82D70 Offset: 0x2E7ED70 VA: 0x2E82D70
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x2E82CF0 Offset: 0x2E7ECF0 VA: 0x2E82CF0
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	private static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F26AC Offset: 0x26EE6AC VA: 0x26F26AC
	|-String.JoinCore<int>
	|
	|-RVA: 0x26F2BE0 Offset: 0x26EEBE0 VA: 0x26F2BE0
	|-String.JoinCore<Int32Enum>
	|
	|-RVA: 0x26F3158 Offset: 0x26EF158 VA: 0x26F3158
	|-String.JoinCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E8323C Offset: 0x2E7F23C VA: 0x2E8323C
	private static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count) { }

	// RVA: 0x2E835E0 Offset: 0x2E7F5E0 VA: 0x2E835E0
	public string PadLeft(int totalWidth) { }

	// RVA: 0x2E835E8 Offset: 0x2E7F5E8 VA: 0x2E835E8
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x2E83708 Offset: 0x2E7F708 VA: 0x2E83708
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x2E83830 Offset: 0x2E7F830 VA: 0x2E83830
	public string Remove(int startIndex, int count) { }

	// RVA: 0x2E839CC Offset: 0x2E7F9CC VA: 0x2E839CC
	public string Remove(int startIndex) { }

	// RVA: 0x2E83C1C Offset: 0x2E7FC1C VA: 0x2E83C1C
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x2E83CF4 Offset: 0x2E7FCF4 VA: 0x2E83CF4
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x2E84008 Offset: 0x2E80008 VA: 0x2E84008
	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices) { }

	// RVA: 0x2E84348 Offset: 0x2E80348 VA: 0x2E84348
	public string[] Split(char separator, StringSplitOptions options = 0) { }

	// RVA: 0x2E846D4 Offset: 0x2E806D4 VA: 0x2E846D4
	public string[] Split(char[] separator) { }

	// RVA: 0x2E84748 Offset: 0x2E80748 VA: 0x2E84748
	public string[] Split(char[] separator, StringSplitOptions options) { }

	// RVA: 0x2E847C0 Offset: 0x2E807C0 VA: 0x2E847C0
	public string[] Split(char[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x2E843A8 Offset: 0x2E803A8 VA: 0x2E843A8
	private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options) { }

	// RVA: 0x2E851D4 Offset: 0x2E811D4 VA: 0x2E851D4
	public string[] Split(string separator, StringSplitOptions options = 0) { }

	// RVA: 0x2E85648 Offset: 0x2E81648 VA: 0x2E85648
	public string[] Split(string[] separator, StringSplitOptions options) { }

	// RVA: 0x2E85258 Offset: 0x2E81258 VA: 0x2E85258
	private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options) { }

	// RVA: 0x2E8565C Offset: 0x2E8165C VA: 0x2E8565C
	private string[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	// RVA: 0x2E84D18 Offset: 0x2E80D18 VA: 0x2E84D18
	private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) { }

	// RVA: 0x2E84F20 Offset: 0x2E80F20 VA: 0x2E84F20
	private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) { }

	// RVA: 0x2E84844 Offset: 0x2E80844 VA: 0x2E84844
	private void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder) { }

	// RVA: 0x2E85AF0 Offset: 0x2E81AF0 VA: 0x2E85AF0
	private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder) { }

	// RVA: 0x2E85818 Offset: 0x2E81818 VA: 0x2E85818
	private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder) { }

	// RVA: 0x2E85CE8 Offset: 0x2E81CE8 VA: 0x2E85CE8
	public string Substring(int startIndex) { }

	// RVA: 0x2E83A84 Offset: 0x2E7FA84 VA: 0x2E83A84
	public string Substring(int startIndex, int length) { }

	// RVA: 0x2E85DF0 Offset: 0x2E81DF0 VA: 0x2E85DF0
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x2E85E48 Offset: 0x2E81E48 VA: 0x2E85E48
	public string ToLower() { }

	// RVA: 0x2E85EC4 Offset: 0x2E81EC4 VA: 0x2E85EC4
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x2E85F48 Offset: 0x2E81F48 VA: 0x2E85F48
	public string ToLowerInvariant() { }

	// RVA: 0x2E85FC4 Offset: 0x2E81FC4 VA: 0x2E85FC4
	public string ToUpper() { }

	// RVA: 0x2E86040 Offset: 0x2E82040 VA: 0x2E86040
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x2E860C4 Offset: 0x2E820C4 VA: 0x2E860C4
	public string ToUpperInvariant() { }

	// RVA: 0x2E86140 Offset: 0x2E82140 VA: 0x2E86140
	public string Trim() { }

	// RVA: 0x2E86280 Offset: 0x2E82280 VA: 0x2E86280
	public string Trim(char trimChar) { }

	// RVA: 0x2E86404 Offset: 0x2E82404 VA: 0x2E86404
	public string Trim(char[] trimChars) { }

	// RVA: 0x2E86438 Offset: 0x2E82438 VA: 0x2E86438
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x2E8646C Offset: 0x2E8246C VA: 0x2E8646C
	public string TrimEnd() { }

	// RVA: 0x2E86474 Offset: 0x2E82474 VA: 0x2E86474
	public string TrimEnd(char trimChar) { }

	// RVA: 0x2E86494 Offset: 0x2E82494 VA: 0x2E86494
	public string TrimEnd(char[] trimChars) { }

	// RVA: 0x2E86148 Offset: 0x2E82148 VA: 0x2E86148
	private string TrimWhiteSpaceHelper(string.TrimType trimType) { }

	// RVA: 0x2E862A0 Offset: 0x2E822A0 VA: 0x2E862A0
	private string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType) { }

	// RVA: 0x2E864C8 Offset: 0x2E824C8 VA: 0x2E864C8
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x2E86558 Offset: 0x2E82558 VA: 0x2E86558
	public bool Contains(string value) { }

	// RVA: 0x2E8658C Offset: 0x2E8258C VA: 0x2E8658C
	public bool Contains(char value) { }

	// RVA: 0x2E865B0 Offset: 0x2E825B0 VA: 0x2E865B0
	public int IndexOf(char value) { }

	// RVA: 0x2E865C0 Offset: 0x2E825C0 VA: 0x2E865C0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x2E865CC Offset: 0x2E825CC VA: 0x2E865CC
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x2E866A4 Offset: 0x2E826A4 VA: 0x2E866A4
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x2E8686C Offset: 0x2E8286C VA: 0x2E8686C
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x2E866B0 Offset: 0x2E826B0 VA: 0x2E866B0
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x2E86878 Offset: 0x2E82878 VA: 0x2E86878
	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	// RVA: 0x2E86900 Offset: 0x2E82900 VA: 0x2E86900
	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	// RVA: 0x2E86958 Offset: 0x2E82958 VA: 0x2E86958
	private int IndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x2E85CF4 Offset: 0x2E81CF4 VA: 0x2E85CF4
	private static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf) { }

	// RVA: 0x2E86A88 Offset: 0x2E82A88 VA: 0x2E86A88
	private static bool ArrayContains(char searchChar, char[] anyOf) { }

	// RVA: 0x2E85DD4 Offset: 0x2E81DD4 VA: 0x2E85DD4
	private static bool IsCharBitSet(uint* charMap, byte value) { }

	// RVA: 0x2E86AE4 Offset: 0x2E82AE4 VA: 0x2E86AE4
	private static void SetCharBit(uint* charMap, byte value) { }

	// RVA: 0x2E86B08 Offset: 0x2E82B08 VA: 0x2E86B08
	public int IndexOf(string value) { }

	// RVA: 0x2E86B18 Offset: 0x2E82B18 VA: 0x2E86B18
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x2E8657C Offset: 0x2E8257C VA: 0x2E8657C
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x2E86B28 Offset: 0x2E82B28 VA: 0x2E86B28
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x2E86B38 Offset: 0x2E82B38 VA: 0x2E86B38
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x2E86E80 Offset: 0x2E82E80 VA: 0x2E86E80
	public int LastIndexOf(char value) { }

	// RVA: 0x2E86E90 Offset: 0x2E82E90 VA: 0x2E86E90
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x2E86E98 Offset: 0x2E82E98 VA: 0x2E86E98
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x2E86F7C Offset: 0x2E82F7C VA: 0x2E86F7C
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x2E86F88 Offset: 0x2E82F88 VA: 0x2E86F88
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x2E870B4 Offset: 0x2E830B4 VA: 0x2E870B4
	private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x2E871E4 Offset: 0x2E831E4 VA: 0x2E871E4
	public int LastIndexOf(string value) { }

	// RVA: 0x2E8759C Offset: 0x2E8359C VA: 0x2E8759C
	public int LastIndexOf(string value, int startIndex) { }

	// RVA: 0x2E875A8 Offset: 0x2E835A8 VA: 0x2E875A8
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x2E871F4 Offset: 0x2E831F4 VA: 0x2E871F4
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x2E875B8 Offset: 0x2E835B8 VA: 0x2E875B8
	public void .ctor(char[] value) { }

	// RVA: 0x2E875BC Offset: 0x2E835BC VA: 0x2E875BC
	private static string Ctor(char[] value) { }

	// RVA: 0x2E8764C Offset: 0x2E8364C VA: 0x2E8764C
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x2E87650 Offset: 0x2E83650 VA: 0x2E87650
	private static string Ctor(char[] value, int startIndex, int length) { }

	[CLSCompliant(False)]
	// RVA: 0x2E877FC Offset: 0x2E837FC VA: 0x2E877FC
	public void .ctor(char* value, int startIndex, int length) { }

	// RVA: 0x2E87800 Offset: 0x2E83800 VA: 0x2E87800
	private static string Ctor(char* ptr, int startIndex, int length) { }

	[CLSCompliant(False)]
	// RVA: 0x2E87980 Offset: 0x2E83980 VA: 0x2E87980
	public void .ctor(sbyte* value, int startIndex, int length) { }

	// RVA: 0x2E87984 Offset: 0x2E83984 VA: 0x2E87984
	private static string Ctor(sbyte* value, int startIndex, int length) { }

	// RVA: 0x2E87AFC Offset: 0x2E83AFC VA: 0x2E87AFC
	private static string CreateStringForSByteConstructor(byte* pb, int numBytes) { }

	[CLSCompliant(False)]
	// RVA: 0x2E87B78 Offset: 0x2E83B78 VA: 0x2E87B78
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2E87B7C Offset: 0x2E83B7C VA: 0x2E87B7C
	private static string Ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2E87D3C Offset: 0x2E83D3C VA: 0x2E87D3C
	public void .ctor(char c, int count) { }

	// RVA: 0x2E87D40 Offset: 0x2E83D40 VA: 0x2E87D40
	private static string Ctor(char c, int count) { }

	// RVA: 0x2E87E5C Offset: 0x2E83E5C VA: 0x2E87E5C
	public void .ctor(ReadOnlySpan<char> value) { }

	// RVA: 0x2E87E60 Offset: 0x2E83E60 VA: 0x2E87E60
	private static string Ctor(ReadOnlySpan<char> value) { }

	// RVA: -1 Offset: -1
	public static string Create<TState>(int length, TState state, SpanAction<char, TState> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26F1F64 Offset: 0x26EDF64 VA: 0x26F1F64
	|-String.Create<ValueTuple<object, int, int>>
	|
	|-RVA: 0x26F20A0 Offset: 0x26EE0A0 VA: 0x26F20A0
	|-String.Create<ValueTuple<IntPtr, int, IntPtr, int, bool>>
	|
	|-RVA: 0x26F21EC Offset: 0x26EE1EC VA: 0x26F21EC
	|-String.Create<ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>
	|
	|-RVA: 0x26F2348 Offset: 0x26EE348 VA: 0x26F2348
	|-String.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E87F20 Offset: 0x2E83F20 VA: 0x2E87F20
	public static ReadOnlySpan<char> op_Implicit(string value) { }

	// RVA: 0x2E87F70 Offset: 0x2E83F70 VA: 0x2E87F70 Slot: 26
	public object Clone() { }

	// RVA: 0x2E87F74 Offset: 0x2E83F74 VA: 0x2E87F74
	public static string Copy(string str) { }

	// RVA: 0x2E88008 Offset: 0x2E84008 VA: 0x2E88008
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x2E8817C Offset: 0x2E8417C VA: 0x2E8817C
	public char[] ToCharArray() { }

	[NonVersionable]
	// RVA: 0x2E82440 Offset: 0x2E7E440 VA: 0x2E82440
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x2E88268 Offset: 0x2E84268 VA: 0x2E88268
	public static bool IsNullOrWhiteSpace(string value) { }

	// RVA: 0x2E804C8 Offset: 0x2E7C4C8 VA: 0x2E804C8
	internal ref char GetRawStringData() { }

	// RVA: 0x2E88318 Offset: 0x2E84318 VA: 0x2E88318
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x2E883E0 Offset: 0x2E843E0 VA: 0x2E883E0
	internal static string CreateFromChar(char c) { }

	// RVA: 0x2E81F84 Offset: 0x2E7DF84 VA: 0x2E81F84
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x2E88404 Offset: 0x2E84404 VA: 0x2E88404 Slot: 3
	public override string ToString() { }

	// RVA: 0x2E88408 Offset: 0x2E84408 VA: 0x2E88408 Slot: 24
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2E8840C Offset: 0x2E8440C VA: 0x2E8840C Slot: 6
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x2E88468 Offset: 0x2E84468 VA: 0x2E88468 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2E884C4 Offset: 0x2E844C4 VA: 0x2E884C4
	internal static int wcslen(char* ptr) { }

	// RVA: 0x2E885CC Offset: 0x2E845CC VA: 0x2E885CC Slot: 9
	public TypeCode GetTypeCode() { }

	// RVA: 0x2E885D4 Offset: 0x2E845D4 VA: 0x2E885D4 Slot: 10
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2E8863C Offset: 0x2E8463C VA: 0x2E8863C Slot: 11
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2E886A4 Offset: 0x2E846A4 VA: 0x2E886A4 Slot: 12
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2E8870C Offset: 0x2E8470C VA: 0x2E8870C Slot: 13
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2E88774 Offset: 0x2E84774 VA: 0x2E88774 Slot: 14
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2E887DC Offset: 0x2E847DC VA: 0x2E887DC Slot: 15
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2E88844 Offset: 0x2E84844 VA: 0x2E88844 Slot: 16
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2E888AC Offset: 0x2E848AC VA: 0x2E888AC Slot: 17
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2E88914 Offset: 0x2E84914 VA: 0x2E88914 Slot: 18
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2E8897C Offset: 0x2E8497C VA: 0x2E8897C Slot: 19
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2E889E4 Offset: 0x2E849E4 VA: 0x2E889E4 Slot: 20
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2E88A4C Offset: 0x2E84A4C VA: 0x2E88A4C Slot: 21
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2E88AB4 Offset: 0x2E84AB4 VA: 0x2E88AB4 Slot: 22
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2E88B1C Offset: 0x2E84B1C VA: 0x2E88B1C Slot: 23
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2E88B84 Offset: 0x2E84B84 VA: 0x2E88B84 Slot: 25
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x2E88BF4 Offset: 0x2E84BF4 VA: 0x2E88BF4
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x2E88C5C Offset: 0x2E84C5C VA: 0x2E88C5C
	public int get_Length() { }

	// RVA: 0x2E88C64 Offset: 0x2E84C64 VA: 0x2E88C64
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x2E88D64 Offset: 0x2E84D64 VA: 0x2E88D64
	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	// RVA: 0x2E88F30 Offset: 0x2E84F30 VA: 0x2E88F30
	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x2E89000 Offset: 0x2E85000 VA: 0x2E89000
	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	// RVA: 0x2E89190 Offset: 0x2E85190 VA: 0x2E89190
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x2E8243C Offset: 0x2E7E43C VA: 0x2E8243C
	internal static string FastAllocateString(int length) { }

	// RVA: 0x2E891E8 Offset: 0x2E851E8 VA: 0x2E891E8
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x2E89290 Offset: 0x2E85290 VA: 0x2E89290
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x2E89298 Offset: 0x2E85298 VA: 0x2E89298
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x2E892A4 Offset: 0x2E852A4 VA: 0x2E892A4
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x2E892AC Offset: 0x2E852AC VA: 0x2E892AC
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x2E892B4 Offset: 0x2E852B4 VA: 0x2E892B4
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x2E892BC Offset: 0x2E852BC VA: 0x2E892BC
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x2E892C4 Offset: 0x2E852C4 VA: 0x2E892C4
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x2E892D0 Offset: 0x2E852D0 VA: 0x2E892D0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x2E892DC Offset: 0x2E852DC VA: 0x2E892DC
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x2E892E8 Offset: 0x2E852E8 VA: 0x2E892E8
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x2E87D2C Offset: 0x2E83D2C VA: 0x2E87D2C
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x2E892F4 Offset: 0x2E852F4 VA: 0x2E892F4
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x2E89304 Offset: 0x2E85304 VA: 0x2E89304
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x2E80494 Offset: 0x2E7C494 VA: 0x2E80494
	private string CreateString(char[] val) { }

	// RVA: 0x2E89314 Offset: 0x2E85314 VA: 0x2E89314
	private string CreateString(char c, int count) { }

	// RVA: 0x2E89320 Offset: 0x2E85320 VA: 0x2E89320
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x2E89334 Offset: 0x2E85334 VA: 0x2E89334
	private string CreateString(ReadOnlySpan<char> value) { }

	[Intrinsic]
	// RVA: 0x2E7D634 Offset: 0x2E79634 VA: 0x2E7D634
	public char get_Chars(int index) { }
}
