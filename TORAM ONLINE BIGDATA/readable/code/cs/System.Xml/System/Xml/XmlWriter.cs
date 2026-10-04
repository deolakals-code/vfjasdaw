// Assembly: System.Xml.dll
// Namespace: System.Xml
public abstract class XmlWriter : IDisposable // TypeDefIndex: 13375
{
	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x33A96E4 Offset: 0x33A56E4 VA: 0x33A96E4
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x33A96FC Offset: 0x33A56FC VA: 0x33A96FC
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x33A9758 Offset: 0x33A5758 VA: 0x33A9758
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x33A97B4 Offset: 0x33A57B4 VA: 0x33A97B4
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x33A9804 Offset: 0x33A5804 VA: 0x33A9804 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x33A9820 Offset: 0x33A5820 VA: 0x33A9820 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x33A9824 Offset: 0x33A5824 VA: 0x33A9824 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x33A983C Offset: 0x33A583C VA: 0x33A983C Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x33A9AB8 Offset: 0x33A5AB8 VA: 0x33A9AB8 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x33A9F2C Offset: 0x33A5F2C VA: 0x33A9F2C
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x33A9F90 Offset: 0x33A5F90 VA: 0x33A9F90 Slot: 4
	public void Dispose() { }

	// RVA: 0x33A9FA4 Offset: 0x33A5FA4 VA: 0x33A9FA4 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x33A9FE8 Offset: 0x33A5FE8 VA: 0x33A9FE8
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x33AA558 Offset: 0x33A6558 VA: 0x33AA558
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x33AA8BC Offset: 0x33A68BC VA: 0x33AA8BC
	protected void .ctor() { }
}
