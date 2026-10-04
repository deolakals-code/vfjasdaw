// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 13777
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[Xml("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation { get; set; }
	[XmlIgnore]
	public XmlSchema Schema { get; set; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x333802C Offset: 0x333402C VA: 0x333802C
	public string get_SchemaLocation() { }

	// RVA: 0x3338034 Offset: 0x3334034 VA: 0x3338034
	public void set_SchemaLocation(string value) { }

	// RVA: 0x333803C Offset: 0x333403C VA: 0x333803C
	public XmlSchema get_Schema() { }

	// RVA: 0x3338044 Offset: 0x3334044 VA: 0x3338044
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x333804C Offset: 0x333404C VA: 0x333804C
	public string get_Id() { }

	// RVA: 0x3338054 Offset: 0x3334054 VA: 0x3338054
	public void set_Id(string value) { }

	// RVA: 0x333805C Offset: 0x333405C VA: 0x333805C
	internal Uri get_BaseUri() { }

	// RVA: 0x3338064 Offset: 0x3334064 VA: 0x3338064
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x333806C Offset: 0x333406C VA: 0x333806C Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x3338074 Offset: 0x3334074 VA: 0x3338074 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x333807C Offset: 0x333407C VA: 0x333807C Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x3338084 Offset: 0x3334084 VA: 0x3338084
	internal Compositor get_Compositor() { }

	// RVA: 0x333808C Offset: 0x333408C VA: 0x333808C
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x3338094 Offset: 0x3334094 VA: 0x3338094
	protected void .ctor() { }
}
