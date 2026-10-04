// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 13315
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x3389BF0 Offset: 0x3385BF0 VA: 0x3389BF0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x338AAB8 Offset: 0x3386AB8 VA: 0x338AAB8 Slot: 56
	public virtual bool HasLineInfo() { }

	// RVA: 0x338AB58 Offset: 0x3386B58 VA: 0x338AB58 Slot: 57
	public virtual int get_LineNumber() { }

	// RVA: 0x338ABFC Offset: 0x3386BFC VA: 0x338ABFC Slot: 58
	public virtual int get_LinePosition() { }
}
