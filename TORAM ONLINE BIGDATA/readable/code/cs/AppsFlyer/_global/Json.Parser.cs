// Assembly: AppsFlyer.dll
// Namespace: 
private sealed class Json.Parser : IDisposable // TypeDefIndex: 17272
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

	// RVA: 0x16ED34C Offset: 0x16E934C VA: 0x16ED34C
	public static bool IsWordBreak(char c) { }

	// RVA: 0x16ED3E8 Offset: 0x16E93E8 VA: 0x16ED3E8
	private void .ctor(string jsonString) { }

	// RVA: 0x16ED12C Offset: 0x16E912C VA: 0x16ED12C
	public static object Parse(string jsonString) { }

	// RVA: 0x16ED480 Offset: 0x16E9480 VA: 0x16ED480 Slot: 4
	public void Dispose() { }

	// RVA: 0x16ED4B0 Offset: 0x16E94B0 VA: 0x16ED4B0
	private Dictionary<string, object> ParseObject() { }

	// RVA: 0x16EDA18 Offset: 0x16E9A18 VA: 0x16EDA18
	private List<object> ParseArray() { }

	// RVA: 0x16ED464 Offset: 0x16E9464 VA: 0x16ED464
	private object ParseValue() { }

	// RVA: 0x16EDB44 Offset: 0x16E9B44 VA: 0x16EDB44
	private object ParseByToken(Json.Parser.TOKEN token) { }

	// RVA: 0x16ED798 Offset: 0x16E9798 VA: 0x16ED798
	private string ParseString() { }

	// RVA: 0x16EDC34 Offset: 0x16E9C34 VA: 0x16EDC34
	private object ParseNumber() { }

	// RVA: 0x16EDE30 Offset: 0x16E9E30 VA: 0x16EDE30
	private void EatWhitespace() { }

	// RVA: 0x16EDED4 Offset: 0x16E9ED4 VA: 0x16EDED4
	private char get_PeekChar() { }

	// RVA: 0x16EDD04 Offset: 0x16E9D04 VA: 0x16EDD04
	private char get_NextChar() { }

	// RVA: 0x16EDD7C Offset: 0x16E9D7C VA: 0x16EDD7C
	private string get_NextWord() { }

	// RVA: 0x16ED5D4 Offset: 0x16E95D4 VA: 0x16ED5D4
	private Json.Parser.TOKEN get_NextToken() { }
}
