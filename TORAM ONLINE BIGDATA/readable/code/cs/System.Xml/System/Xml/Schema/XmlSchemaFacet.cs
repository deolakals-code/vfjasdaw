// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 13779
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[Xml("value")]
	public string Value { get; set; }
	[Xml("fixed")]
	[DefaultValue(False)]
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x333809C Offset: 0x333409C VA: 0x333809C
	public string get_Value() { }

	// RVA: 0x33380A4 Offset: 0x33340A4 VA: 0x33380A4
	public void set_Value(string value) { }

	// RVA: 0x33380AC Offset: 0x33340AC VA: 0x33380AC Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x33380B4 Offset: 0x33340B4 VA: 0x33380B4 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x3338168 Offset: 0x3334168 VA: 0x3338168
	internal FacetType get_FacetType() { }

	// RVA: 0x3338170 Offset: 0x3334170 VA: 0x3338170
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x3338178 Offset: 0x3334178 VA: 0x3338178
	protected void .ctor() { }
}
