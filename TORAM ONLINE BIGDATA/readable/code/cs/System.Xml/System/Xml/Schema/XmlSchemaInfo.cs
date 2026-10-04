// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 13804
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x3338748 Offset: 0x3334748 VA: 0x3338748
	public void .ctor() { }

	// RVA: 0x33387C0 Offset: 0x33347C0 VA: 0x33387C0
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x33387F0 Offset: 0x33347F0 VA: 0x33387F0 Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x33387F8 Offset: 0x33347F8 VA: 0x33387F8
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x3338800 Offset: 0x3334800 VA: 0x3338800 Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x3338808 Offset: 0x3334808 VA: 0x3338808
	public void set_IsDefault(bool value) { }

	// RVA: 0x3338814 Offset: 0x3334814 VA: 0x3338814 Slot: 6
	public bool get_IsNil() { }

	// RVA: 0x333881C Offset: 0x333481C VA: 0x333881C
	public void set_IsNil(bool value) { }

	// RVA: 0x3338828 Offset: 0x3334828 VA: 0x3338828 Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x3338830 Offset: 0x3334830 VA: 0x3338830
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x3338838 Offset: 0x3334838 VA: 0x3338838 Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x3338840 Offset: 0x3334840 VA: 0x3338840
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x3338880 Offset: 0x3334880 VA: 0x3338880 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x3338888 Offset: 0x3334888 VA: 0x3338888
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x33388C8 Offset: 0x33348C8 VA: 0x33388C8 Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x33388D0 Offset: 0x33348D0 VA: 0x33388D0
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x3338910 Offset: 0x3334910 VA: 0x3338910
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x3338918 Offset: 0x3334918 VA: 0x3338918
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x3338934 Offset: 0x3334934 VA: 0x3338934
	internal bool get_HasDefaultValue() { }

	// RVA: 0x3338968 Offset: 0x3334968 VA: 0x3338968
	internal bool get_IsUnionType() { }

	// RVA: 0x3338764 Offset: 0x3334764 VA: 0x3338764
	internal void Clear() { }
}
