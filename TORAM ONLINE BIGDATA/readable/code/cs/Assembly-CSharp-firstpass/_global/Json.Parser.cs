// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
private sealed class Json.Parser : IDisposable // TypeDefIndex: 17102
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

	// RVA: 0x1703260 Offset: 0x16FF260 VA: 0x1703260
	public static bool IsWordBreak(char c) { }

	// RVA: 0x17032FC Offset: 0x16FF2FC VA: 0x17032FC
	private void .ctor(string jsonString) { }

	// RVA: 0x1703040 Offset: 0x16FF040 VA: 0x1703040
	public static object Parse(string jsonString) { }

	// RVA: 0x1703394 Offset: 0x16FF394 VA: 0x1703394 Slot: 4
	public void Dispose() { }

	// RVA: 0x17033C4 Offset: 0x16FF3C4 VA: 0x17033C4
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x170392C Offset: 0x16FF92C VA: 0x170392C
	private List<object> ParseArray() { }

	// RVA: 0x1703378 Offset: 0x16FF378 VA: 0x1703378
	private object ParseValue() { }

	// RVA: 0x1703A58 Offset: 0x16FFA58 VA: 0x1703A58
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x17036AC Offset: 0x16FF6AC VA: 0x17036AC
	private string ParseString() { }

	// RVA: 0x1703B48 Offset: 0x16FFB48 VA: 0x1703B48
	private object ParseNumber() { }

	// RVA: 0x1703D44 Offset: 0x16FFD44 VA: 0x1703D44
	private void EatWhitespace() { }

	// RVA: 0x1703DE8 Offset: 0x16FFDE8 VA: 0x1703DE8
	private char get_PeekChar() { }

	// RVA: 0x1703C18 Offset: 0x16FFC18 VA: 0x1703C18
	private char get_NextChar() { }

	// RVA: 0x1703C90 Offset: 0x16FFC90 VA: 0x1703C90
	private string get_NextWord() { }

	// RVA: 0x17034E8 Offset: 0x16FF4E8 VA: 0x17034E8
	private Json.Parser.TOKEN get_NextToken() { }
}
