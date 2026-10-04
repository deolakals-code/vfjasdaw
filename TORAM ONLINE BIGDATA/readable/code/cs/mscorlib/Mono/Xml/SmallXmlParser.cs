// Assembly: mscorlib.dll
// Namespace: Mono.Xml
internal class SmallXmlParser // TypeDefIndex: 9451
{
	// Fields
	private SmallXmlParser.IContentHandler handler; // 0x10
	private TextReader reader; // 0x18
	private Stack elementNames; // 0x20
	private Stack xmlSpaces; // 0x28
	private string xmlSpace; // 0x30
	private StringBuilder buffer; // 0x38
	private char[] nameBuffer; // 0x40
	private bool isWhitespace; // 0x48
	private SmallXmlParser.AttrListImpl attributes; // 0x50
	private int line; // 0x58
	private int column; // 0x5C
	private bool resetColumn; // 0x60

	// Methods

	// RVA: 0x2E662CC Offset: 0x2E622CC VA: 0x2E662CC
	public void .ctor() { }

	// RVA: 0x2E66B0C Offset: 0x2E62B0C VA: 0x2E66B0C
	private Exception Error(string msg) { }

	// RVA: 0x2E66C48 Offset: 0x2E62C48 VA: 0x2E66C48
	private Exception UnexpectedEndError() { }

	// RVA: 0x2E66D34 Offset: 0x2E62D34 VA: 0x2E66D34
	private bool IsNameChar(char c, bool start) { }

	// RVA: 0x2E66E30 Offset: 0x2E62E30 VA: 0x2E66E30
	private bool IsWhitespace(int c) { }

	// RVA: 0x2E66E58 Offset: 0x2E62E58 VA: 0x2E66E58
	public void SkipWhitespaces() { }

	// RVA: 0x2E66F0C Offset: 0x2E62F0C VA: 0x2E66F0C
	private void HandleWhitespaces() { }

	// RVA: 0x2E66E60 Offset: 0x2E62E60 VA: 0x2E66E60
	public void SkipWhitespaces(bool expected) { }

	// RVA: 0x2E67028 Offset: 0x2E63028 VA: 0x2E67028
	private int Peek() { }

	// RVA: 0x2E66FCC Offset: 0x2E62FCC VA: 0x2E66FCC
	private int Read() { }

	// RVA: 0x2E67048 Offset: 0x2E63048 VA: 0x2E67048
	public void Expect(int c) { }

	// RVA: 0x2E67108 Offset: 0x2E63108 VA: 0x2E67108
	private string ReadUntil(char until, bool handleReferences) { }

	// RVA: 0x2E673AC Offset: 0x2E633AC VA: 0x2E673AC
	public string ReadName() { }

	// RVA: 0x2E664AC Offset: 0x2E624AC VA: 0x2E664AC
	public void Parse(TextReader input, SmallXmlParser.IContentHandler handler) { }

	// RVA: 0x2E67DA0 Offset: 0x2E63DA0 VA: 0x2E67DA0
	private void Cleanup() { }

	// RVA: 0x2E67564 Offset: 0x2E63564 VA: 0x2E67564
	public void ReadContent() { }

	// RVA: 0x2E67C68 Offset: 0x2E63C68 VA: 0x2E67C68
	private void HandleBufferedContent() { }

	// RVA: 0x2E681D8 Offset: 0x2E641D8 VA: 0x2E681D8
	private void ReadCharacters() { }

	// RVA: 0x2E671E4 Offset: 0x2E631E4 VA: 0x2E671E4
	private void ReadReference() { }

	// RVA: 0x2E68260 Offset: 0x2E64260 VA: 0x2E68260
	private int ReadCharacterReference() { }

	// RVA: 0x2E68068 Offset: 0x2E64068 VA: 0x2E68068
	private void ReadAttribute(SmallXmlParser.AttrListImpl a) { }

	// RVA: 0x2E67EE8 Offset: 0x2E63EE8 VA: 0x2E67EE8
	private void ReadCDATASection() { }

	// RVA: 0x2E67FE0 Offset: 0x2E63FE0 VA: 0x2E67FE0
	private void ReadComment() { }
}
