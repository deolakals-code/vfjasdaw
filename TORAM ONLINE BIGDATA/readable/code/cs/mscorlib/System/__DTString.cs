// Assembly: mscorlib.dll
// Namespace: System
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct __DTString // TypeDefIndex: 9591
{
	// Fields
	internal ReadOnlySpan<char> Value; // 0x0
	internal int Index; // 0x10
	internal char m_current; // 0x14
	private CompareInfo m_info; // 0x18
	private bool m_checkDigitToken; // 0x20
	private static readonly char[] WhiteSpaceChecks; // 0x0

	// Properties
	internal int Length { get; }
	internal CompareInfo CompareInfo { get; }

	// Methods

	// RVA: 0x2FDC664 Offset: 0x2FD8664 VA: 0x2FDC664
	internal int get_Length() { }

	// RVA: 0x2FDC6A0 Offset: 0x2FD86A0 VA: 0x2FDC6A0
	internal void .ctor(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi, bool checkDigitToken) { }

	// RVA: 0x2FDC72C Offset: 0x2FD872C VA: 0x2FDC72C
	internal void .ctor(ReadOnlySpan<char> str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FDC7F0 Offset: 0x2FD87F0 VA: 0x2FDC7F0
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x2FDC7F8 Offset: 0x2FD87F8 VA: 0x2FDC7F8
	internal bool GetNext() { }

	// RVA: 0x2FDC8A4 Offset: 0x2FD88A4 VA: 0x2FDC8A4
	internal bool AtEnd() { }

	// RVA: 0x2FDC924 Offset: 0x2FD8924 VA: 0x2FDC924
	internal bool Advance(int count) { }

	// RVA: 0x2FDC9DC Offset: 0x2FD89DC VA: 0x2FDC9DC
	internal void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FDCD10 Offset: 0x2FD8D10 VA: 0x2FDCD10
	internal TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator) { }

	// RVA: 0x2FDCF80 Offset: 0x2FD8F80 VA: 0x2FDCF80
	internal bool MatchSpecifiedWord(string target) { }

	// RVA: 0x2FDD0A4 Offset: 0x2FD90A4 VA: 0x2FDD0A4
	internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength) { }

	// RVA: 0x2FDD4F0 Offset: 0x2FD94F0 VA: 0x2FDD4F0
	internal bool Match(string str) { }

	// RVA: 0x2FDD640 Offset: 0x2FD9640 VA: 0x2FDD640
	internal bool Match(char ch) { }

	// RVA: 0x2FDD714 Offset: 0x2FD9714 VA: 0x2FDD714
	internal int MatchLongestWords(string[] words, ref int maxMatchStrLen) { }

	// RVA: 0x2FDD80C Offset: 0x2FD980C VA: 0x2FDD80C
	internal int GetRepeatCount() { }

	// RVA: 0x2FDD8E8 Offset: 0x2FD98E8 VA: 0x2FDD8E8
	internal bool GetNextDigit() { }

	// RVA: 0x2FDD9C4 Offset: 0x2FD99C4 VA: 0x2FDD9C4
	internal char GetChar() { }

	// RVA: 0x2FDD9EC Offset: 0x2FD99EC VA: 0x2FDD9EC
	internal int GetDigit() { }

	// RVA: 0x2FDDA18 Offset: 0x2FD9A18 VA: 0x2FDDA18
	internal void SkipWhiteSpaces() { }

	// RVA: 0x2FDCE18 Offset: 0x2FD8E18 VA: 0x2FDCE18
	internal bool SkipWhiteSpaceCurrent() { }

	// RVA: 0x2FDDB10 Offset: 0x2FD9B10 VA: 0x2FDDB10
	internal void TrimTail() { }

	// RVA: 0x2FDDC34 Offset: 0x2FD9C34 VA: 0x2FDDC34
	internal void RemoveTrailingInQuoteSpaces() { }

	// RVA: 0x2FDDE60 Offset: 0x2FD9E60 VA: 0x2FDDE60
	internal void RemoveLeadingInQuoteSpaces() { }

	// RVA: 0x2FDE0F0 Offset: 0x2FDA0F0 VA: 0x2FDE0F0
	internal DTSubString GetSubString() { }

	// RVA: 0x2FDE270 Offset: 0x2FDA270 VA: 0x2FDE270
	internal void ConsumeSubString(DTSubString sub) { }

	// RVA: 0x2FDE320 Offset: 0x2FDA320 VA: 0x2FDE320
	private static void .cctor() { }
}
