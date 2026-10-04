// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public abstract class XmlMapping // TypeDefIndex: 13522
{
	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x33F2BC8 Offset: 0x33EEBC8 VA: 0x33F2BC8
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x33F2C0C Offset: 0x33EEC0C VA: 0x33F2C0C
	public string get_ElementName() { }

	// RVA: 0x33F2C14 Offset: 0x33EEC14 VA: 0x33F2C14
	public string get_Namespace() { }

	// RVA: 0x33F2C1C Offset: 0x33EEC1C VA: 0x33F2C1C
	public void SetKey(string key) { }

	// RVA: 0x33F2C24 Offset: 0x33EEC24 VA: 0x33F2C24
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x33F2C2C Offset: 0x33EEC2C VA: 0x33F2C2C
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x33F2C34 Offset: 0x33EEC34 VA: 0x33F2C34
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x33F2C3C Offset: 0x33EEC3C VA: 0x33F2C3C
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x33F2C44 Offset: 0x33EEC44 VA: 0x33F2C44
	internal SerializationFormat get_Format() { }

	// RVA: 0x33F2C4C Offset: 0x33EEC4C VA: 0x33F2C4C
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x33F2C54 Offset: 0x33EEC54 VA: 0x33F2C54
	internal SerializationSource get_Source() { }
}
