// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal class DateTimeFormatInfoScanner // TypeDefIndex: 10776
{
	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x2F87574 Offset: 0x2F83574 VA: 0x2F87574
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x2F8796C Offset: 0x2F8396C VA: 0x2F8796C
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x2F87A68 Offset: 0x2F83A68 VA: 0x2F87A68
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x2F87EBC Offset: 0x2F83EBC VA: 0x2F87EBC
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x2F8809C Offset: 0x2F8409C VA: 0x2F8809C
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x2F87D48 Offset: 0x2F83D48 VA: 0x2F87D48
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x2F88120 Offset: 0x2F84120 VA: 0x2F88120
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x2F8635C Offset: 0x2F8235C VA: 0x2F8635C
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x2F847A8 Offset: 0x2F807A8 VA: 0x2F847A8
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x2F847E8 Offset: 0x2F807E8 VA: 0x2F847E8
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x2F848A8 Offset: 0x2F808A8 VA: 0x2F848A8
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x2F848D8 Offset: 0x2F808D8 VA: 0x2F848D8
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x2F8835C Offset: 0x2F8435C VA: 0x2F8835C
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x2F88668 Offset: 0x2F84668 VA: 0x2F88668
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x2F8840C Offset: 0x2F8440C VA: 0x2F8840C
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x2F862D4 Offset: 0x2F822D4 VA: 0x2F862D4
	public void .ctor() { }
}
