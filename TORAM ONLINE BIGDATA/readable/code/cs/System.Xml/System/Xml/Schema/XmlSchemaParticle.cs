// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 13817
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[Xml("minOccurs")]
	public string MinOccursString { get; set; }
	[Xml("maxOccurs")]
	public string MaxOccursString { get; set; }
	[XmlIgnore]
	public Decimal MinOccurs { get; set; }
	[XmlIgnore]
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x333A6B8 Offset: 0x33366B8 VA: 0x333A6B8
	public string get_MinOccursString() { }

	// RVA: 0x333A730 Offset: 0x3336730 VA: 0x333A730
	public void set_MinOccursString(string value) { }

	// RVA: 0x333A884 Offset: 0x3336884 VA: 0x333A884
	public string get_MaxOccursString() { }

	// RVA: 0x333A9A8 Offset: 0x33369A8 VA: 0x333A9A8
	public void set_MaxOccursString(string value) { }

	// RVA: 0x333ABC4 Offset: 0x3336BC4 VA: 0x333ABC4
	public Decimal get_MinOccurs() { }

	// RVA: 0x333ABD0 Offset: 0x3336BD0 VA: 0x333ABD0
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x333ACFC Offset: 0x3336CFC VA: 0x333ACFC
	public Decimal get_MaxOccurs() { }

	// RVA: 0x333AD08 Offset: 0x3336D08 VA: 0x333AD08
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x333AE6C Offset: 0x3336E6C VA: 0x333AE6C Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x333AED8 Offset: 0x3336ED8 VA: 0x333AED8 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x333AF20 Offset: 0x3336F20 VA: 0x333AF20
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x333B0A0 Offset: 0x33370A0 VA: 0x333B0A0
	protected void .ctor() { }

	// RVA: 0x333B114 Offset: 0x3337114 VA: 0x333B114
	private static void .cctor() { }
}
