// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexCharClass // TypeDefIndex: 14080
{
	// Fields
	private static readonly string s_internalRegexIgnoreCase; // 0x0
	private static readonly string s_space; // 0x8
	private static readonly string s_notSpace; // 0x10
	private static readonly string s_word; // 0x18
	private static readonly string s_notWord; // 0x20
	public static readonly string SpaceClass; // 0x28
	public static readonly string NotSpaceClass; // 0x30
	public static readonly string WordClass; // 0x38
	public static readonly string NotWordClass; // 0x40
	public static readonly string DigitClass; // 0x48
	public static readonly string NotDigitClass; // 0x50
	private static readonly Dictionary<string, string> s_definedCategories; // 0x58
	private static readonly string[][] s_propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable; // 0x68
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28

	// Properties
	public bool CanMerge { get; }
	public bool Negate { set; }

	// Methods

	// RVA: 0x3470A40 Offset: 0x346CA40 VA: 0x3470A40
	public void .ctor() { }

	// RVA: 0x3470B0C Offset: 0x346CB0C VA: 0x3470B0C
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x3470B7C Offset: 0x346CB7C VA: 0x3470B7C
	public bool get_CanMerge() { }

	// RVA: 0x3470B9C Offset: 0x346CB9C VA: 0x3470B9C
	public void set_Negate(bool value) { }

	// RVA: 0x3470BA8 Offset: 0x346CBA8 VA: 0x3470BA8
	public void AddChar(char c) { }

	// RVA: 0x3470CCC Offset: 0x346CCCC VA: 0x3470CCC
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x3470EE4 Offset: 0x346CEE4 VA: 0x3470EE4
	private void AddSet(string set) { }

	// RVA: 0x3471108 Offset: 0x346D108 VA: 0x3471108
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x3470BB0 Offset: 0x346CBB0 VA: 0x3470BB0
	public void AddRange(char first, char last) { }

	// RVA: 0x3471110 Offset: 0x346D110 VA: 0x3471110
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x3471604 Offset: 0x346D604 VA: 0x3471604
	private void AddCategory(string category) { }

	// RVA: 0x3471620 Offset: 0x346D620 VA: 0x3471620
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x347175C Offset: 0x346D75C VA: 0x347175C
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x347198C Offset: 0x346D98C VA: 0x347198C
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x3471A88 Offset: 0x346DA88 VA: 0x3471A88
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x3471B84 Offset: 0x346DB84 VA: 0x3471B84
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x3471C38 Offset: 0x346DC38 VA: 0x3471C38
	public static char SingletonChar(string set) { }

	// RVA: 0x3471C50 Offset: 0x346DC50 VA: 0x3471C50
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x3471D6C Offset: 0x346DD6C VA: 0x3471D6C
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x3471E2C Offset: 0x346DE2C VA: 0x3471E2C
	public static bool IsSingleton(string set) { }

	// RVA: 0x3471F38 Offset: 0x346DF38 VA: 0x3471F38
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x3471D14 Offset: 0x346DD14 VA: 0x3471D14
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x3471CEC Offset: 0x346DCEC VA: 0x3471CEC
	private static bool IsNegated(string set) { }

	// RVA: 0x3472048 Offset: 0x346E048 VA: 0x3472048
	public static bool IsECMAWordChar(char ch) { }

	// RVA: 0x347211C Offset: 0x346E11C VA: 0x347211C
	public static bool IsWordChar(char ch) { }

	// RVA: 0x34720B4 Offset: 0x346E0B4 VA: 0x34720B4
	public static bool CharInClass(char ch, string set) { }

	// RVA: 0x3472198 Offset: 0x346E198 VA: 0x3472198
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x34722C0 Offset: 0x346E2C0 VA: 0x34722C0
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x34723D0 Offset: 0x346E3D0 VA: 0x34723D0
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x3472558 Offset: 0x346E558 VA: 0x3472558
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x3471320 Offset: 0x346D320 VA: 0x3471320
	private static string NegateCategory(string category) { }

	// RVA: 0x3472628 Offset: 0x346E628 VA: 0x3472628
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x3472680 Offset: 0x346E680 VA: 0x3472680
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x3470E3C Offset: 0x346CE3C VA: 0x3470E3C
	private int RangeCount() { }

	// RVA: 0x34728EC Offset: 0x346E8EC VA: 0x34728EC
	public string ToStringClass() { }

	// RVA: 0x3470E84 Offset: 0x346CE84 VA: 0x3470E84
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x3472A88 Offset: 0x346EA88 VA: 0x3472A88
	private void Canonicalize() { }

	// RVA: 0x34713A8 Offset: 0x346D3A8 VA: 0x34713A8
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x3472CC0 Offset: 0x346ECC0 VA: 0x3472CC0
	private static void .cctor() { }
}
