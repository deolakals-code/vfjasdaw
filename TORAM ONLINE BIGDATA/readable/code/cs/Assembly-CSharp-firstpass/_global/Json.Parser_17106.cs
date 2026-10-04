// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
private sealed class Json.Parser : IDisposable // TypeDefIndex: 17106
{
	// Fields
	private const string WORD_BREAK = "{}[],:\"";
	private StringReader json; // 0x10

	// Properties
	private char PeekChar { get; }
	private char NextChar { get; }
	private string NextWord { get; }
	private Json.Parser.TOKEN NextToken { get; }

	// Methods

	// RVA: 0x1704FF4 Offset: 0x1700FF4 VA: 0x1704FF4
	public static bool IsWordBreak(char c) { }

	// RVA: 0x1705090 Offset: 0x1701090 VA: 0x1705090
	private void .ctor(string jsonString) { }

	// RVA: 0x1704DD4 Offset: 0x1700DD4 VA: 0x1704DD4
	public static object Parse(string jsonString) { }

	// RVA: 0x1705128 Offset: 0x1701128 VA: 0x1705128 Slot: 4
	public void Dispose() { }

	// RVA: 0x1705158 Offset: 0x1701158 VA: 0x1705158
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x17056C0 Offset: 0x17016C0 VA: 0x17056C0
	private List<object> ParseArray() { }

	// RVA: 0x170510C Offset: 0x170110C VA: 0x170510C
	private object ParseValue() { }

	// RVA: 0x17057EC Offset: 0x17017EC VA: 0x17057EC
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x1705440 Offset: 0x1701440 VA: 0x1705440
	private string ParseString() { }

	// RVA: 0x17058DC Offset: 0x17018DC VA: 0x17058DC
	private object ParseNumber() { }

	// RVA: 0x1705AD8 Offset: 0x1701AD8 VA: 0x1705AD8
	private void EatWhitespace() { }

	// RVA: 0x1705B7C Offset: 0x1701B7C VA: 0x1705B7C
	private char get_PeekChar() { }

	// RVA: 0x17059AC Offset: 0x17019AC VA: 0x17059AC
	private char get_NextChar() { }

	// RVA: 0x1705A24 Offset: 0x1701A24 VA: 0x1705A24
	private string get_NextWord() { }

	// RVA: 0x170527C Offset: 0x170127C VA: 0x170527C
	private Json.Parser.TOKEN get_NextToken() { }
}
