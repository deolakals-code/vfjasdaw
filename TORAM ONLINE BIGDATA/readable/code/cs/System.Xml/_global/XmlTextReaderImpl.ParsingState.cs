// Assembly: System.Xml.dll
// Namespace: 
private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 13339
{
	// Fields
	internal char[] chars; // 0x0
	internal int charPos; // 0x8
	internal int charsUsed; // 0xC
	internal Encoding encoding; // 0x10
	internal bool appendMode; // 0x18
	internal Stream stream; // 0x20
	internal Decoder decoder; // 0x28
	internal byte[] bytes; // 0x30
	internal int bytePos; // 0x38
	internal int bytesUsed; // 0x3C
	internal TextReader textReader; // 0x40
	internal int lineNo; // 0x48
	internal int lineStartPos; // 0x4C
	internal string baseUriStr; // 0x50
	internal Uri baseUri; // 0x58
	internal bool isEof; // 0x60
	internal bool isStreamEof; // 0x61
	internal IDtdEntityInfo entity; // 0x68
	internal int entityId; // 0x70
	internal bool eolNormalized; // 0x74
	internal bool entityResolvedManually; // 0x75

	// Properties
	internal int LineNo { get; }
	internal int LinePos { get; }

	// Methods

	// RVA: 0x339640C Offset: 0x339240C VA: 0x339640C
	internal void Clear() { }

	// RVA: 0x33964F4 Offset: 0x33924F4 VA: 0x33964F4
	internal void Close(bool closeInput) { }

	// RVA: 0x339652C Offset: 0x339252C VA: 0x339652C
	internal int get_LineNo() { }

	// RVA: 0x3396534 Offset: 0x3392534 VA: 0x3396534
	internal int get_LinePos() { }
}
