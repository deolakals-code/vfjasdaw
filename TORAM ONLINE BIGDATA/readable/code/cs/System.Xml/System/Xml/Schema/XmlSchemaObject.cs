// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject // TypeDefIndex: 13806
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnore]
	public int LineNumber { get; set; }
	[XmlIgnore]
	public int LinePosition { get; set; }
	[XmlIgnore]
	public string SourceUri { get; set; }
	[XmlIgnore]
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnore]
	internal virtual string IdAttribute { get; set; }
	[XmlIgnore]
	internal virtual string NameAttribute { get; set; }
	[XmlIgnore]
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x3338A60 Offset: 0x3334A60 VA: 0x3338A60
	public int get_LineNumber() { }

	// RVA: 0x3338A68 Offset: 0x3334A68 VA: 0x3338A68
	public void set_LineNumber(int value) { }

	// RVA: 0x3338A70 Offset: 0x3334A70 VA: 0x3338A70
	public int get_LinePosition() { }

	// RVA: 0x3338A78 Offset: 0x3334A78 VA: 0x3338A78
	public void set_LinePosition(int value) { }

	// RVA: 0x3338A80 Offset: 0x3334A80 VA: 0x3338A80
	public string get_SourceUri() { }

	// RVA: 0x3338A88 Offset: 0x3334A88 VA: 0x3338A88
	public void set_SourceUri(string value) { }

	// RVA: 0x3338A90 Offset: 0x3334A90 VA: 0x3338A90
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x3338A98 Offset: 0x3334A98 VA: 0x3338A98
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x3331340 Offset: 0x332D340 VA: 0x3331340
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x3338AA0 Offset: 0x3334AA0 VA: 0x3338AA0
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x3338AA8 Offset: 0x3334AA8 VA: 0x3338AA8 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x3338AAC Offset: 0x3334AAC VA: 0x3338AAC Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x3338AB0 Offset: 0x3334AB0 VA: 0x3338AB0 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x3338AB4 Offset: 0x3334AB4 VA: 0x3338AB4 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x3338ABC Offset: 0x3334ABC VA: 0x3338ABC Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x3338AC0 Offset: 0x3334AC0 VA: 0x3338AC0 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x3338AC4 Offset: 0x3334AC4 VA: 0x3338AC4 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x3338AC8 Offset: 0x3334AC8 VA: 0x3338AC8 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x3338AD0 Offset: 0x3334AD0 VA: 0x3338AD0 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x3338AD4 Offset: 0x3334AD4 VA: 0x3338AD4
	internal bool get_IsProcessing() { }

	// RVA: 0x3338ADC Offset: 0x3334ADC VA: 0x3338ADC
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x3338AE8 Offset: 0x3334AE8 VA: 0x3338AE8 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x3330A64 Offset: 0x332CA64 VA: 0x3330A64
	protected void .ctor() { }
}
