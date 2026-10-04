// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexBoyerMoore // TypeDefIndex: 14076
{
	// Fields
	public readonly int[] Positive; // 0x10
	public readonly int[] NegativeASCII; // 0x18
	public readonly int[][] NegativeUnicode; // 0x20
	public readonly string Pattern; // 0x28
	public readonly int LowASCII; // 0x30
	public readonly int HighASCII; // 0x34
	public readonly bool RightToLeft; // 0x38
	public readonly bool CaseInsensitive; // 0x39
	private readonly CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x34700AC Offset: 0x346C0AC VA: 0x34700AC
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x34705CC Offset: 0x346C5CC VA: 0x34705CC
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x34706F0 Offset: 0x346C6F0 VA: 0x34706F0
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x347075C Offset: 0x346C75C VA: 0x347075C
	public int Scan(string text, int index, int beglimit, int endlimit) { }
}
