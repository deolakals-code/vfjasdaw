// Assembly: mscorlib.dll
// Namespace: System.Security.Util
internal sealed class Tokenizer // TypeDefIndex: 10083
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x2EA7868 Offset: 0x2EA3868 VA: 0x2EA7868
	internal void BasicInitialization() { }

	// RVA: 0x2EA78E8 Offset: 0x2EA38E8 VA: 0x2EA78E8
	public void Recycle() { }

	// RVA: 0x2EA7814 Offset: 0x2EA3814 VA: 0x2EA7814
	internal void .ctor(string input) { }

	// RVA: 0x2EA7044 Offset: 0x2EA3044 VA: 0x2EA7044
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x2EA67F0 Offset: 0x2EA27F0 VA: 0x2EA67F0
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x2EA7A78 Offset: 0x2EA3A78 VA: 0x2EA7A78
	private string GetStringToken() { }
}
