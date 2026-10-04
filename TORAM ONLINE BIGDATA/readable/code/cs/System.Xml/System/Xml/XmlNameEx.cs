// Assembly: System.Xml.dll
// Namespace: System.Xml
internal sealed class XmlNameEx : XmlName // TypeDefIndex: 13406
{
	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x33BF2BC Offset: 0x33BB2BC VA: 0x33BF2BC
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33BF9AC Offset: 0x33BB9AC VA: 0x33BF9AC Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x33BF9DC Offset: 0x33BB9DC VA: 0x33BF9DC Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x33BF9E8 Offset: 0x33BB9E8 VA: 0x33BF9E8 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x33BF9F4 Offset: 0x33BB9F4 VA: 0x33BF9F4 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x33BF9FC Offset: 0x33BB9FC VA: 0x33BF9FC Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x33BFA04 Offset: 0x33BBA04 VA: 0x33BFA04 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x33BFA80 Offset: 0x33BBA80 VA: 0x33BFA80 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x33BF958 Offset: 0x33BB958 VA: 0x33BF958
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x33BF96C Offset: 0x33BB96C VA: 0x33BF96C
	public void SetIsDefault(bool value) { }

	// RVA: 0x33BF98C Offset: 0x33BB98C VA: 0x33BF98C
	public void SetIsNil(bool value) { }

	// RVA: 0x33BFAFC Offset: 0x33BBAFC VA: 0x33BFAFC Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }
}
