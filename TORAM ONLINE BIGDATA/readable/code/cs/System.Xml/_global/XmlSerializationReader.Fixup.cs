// Assembly: System.Xml.dll
// Namespace: 
protected class XmlSerializationReader.Fixup // TypeDefIndex: 13539
{
	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Properties
	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }

	// Methods

	// RVA: 0x33FED54 Offset: 0x33FAD54 VA: 0x33FED54
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x33FEDF4 Offset: 0x33FADF4 VA: 0x33FEDF4
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x33FEDFC Offset: 0x33FADFC VA: 0x33FEDFC
	public string[] get_Ids() { }

	// RVA: 0x33FEE04 Offset: 0x33FAE04 VA: 0x33FEE04
	public object get_Source() { }
}
