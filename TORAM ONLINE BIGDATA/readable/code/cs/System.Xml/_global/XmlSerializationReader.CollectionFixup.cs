// Assembly: System.Xml.dll
// Namespace: 
protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 13538
{
	// Fields
	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	// Properties
	public XmlSerializationCollectionFixupCallback Callback { get; }
	public object Collection { get; }
	internal object Id { get; }
	public object CollectionItems { get; set; }

	// Methods

	// RVA: 0x33FECCC Offset: 0x33FACCC VA: 0x33FECCC
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x33FED2C Offset: 0x33FAD2C VA: 0x33FED2C
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x33FED34 Offset: 0x33FAD34 VA: 0x33FED34
	public object get_Collection() { }

	// RVA: 0x33FED3C Offset: 0x33FAD3C VA: 0x33FED3C
	internal object get_Id() { }

	// RVA: 0x33FED44 Offset: 0x33FAD44 VA: 0x33FED44
	public object get_CollectionItems() { }

	// RVA: 0x33FED4C Offset: 0x33FAD4C VA: 0x33FED4C
	internal void set_CollectionItems(object value) { }
}
