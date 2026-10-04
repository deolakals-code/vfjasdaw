// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 13405
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x33BF124 Offset: 0x33BB124 VA: 0x33BF124
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33BF214 Offset: 0x33BB214 VA: 0x33BF214
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x33BF6BC Offset: 0x33BB6BC VA: 0x33BF6BC
	public string get_LocalName() { }

	// RVA: 0x33BF6C4 Offset: 0x33BB6C4 VA: 0x33BF6C4
	public string get_NamespaceURI() { }

	// RVA: 0x33BF6CC Offset: 0x33BB6CC VA: 0x33BF6CC
	public string get_Prefix() { }

	// RVA: 0x33BF6D4 Offset: 0x33BB6D4 VA: 0x33BF6D4
	public int get_HashCode() { }

	// RVA: 0x33BF6DC Offset: 0x33BB6DC VA: 0x33BF6DC
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x33BF6E4 Offset: 0x33BB6E4 VA: 0x33BF6E4
	public string get_Name() { }

	// RVA: 0x33BF8B0 Offset: 0x33BB8B0 VA: 0x33BF8B0 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x33BF8B8 Offset: 0x33BB8B8 VA: 0x33BF8B8 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x33BF8C0 Offset: 0x33BB8C0 VA: 0x33BF8C0 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x33BF8C8 Offset: 0x33BB8C8 VA: 0x33BF8C8 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x33BF8D0 Offset: 0x33BB8D0 VA: 0x33BF8D0 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x33BF8D8 Offset: 0x33BB8D8 VA: 0x33BF8D8 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x33BF8E0 Offset: 0x33BB8E0 VA: 0x33BF8E0 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x33BF8E8 Offset: 0x33BB8E8 VA: 0x33BF8E8 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33BF8F4 Offset: 0x33BB8F4 VA: 0x33BF8F4
	public static int GetHashCode(string name) { }
}
