// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class ContentValidator // TypeDefIndex: 13610
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x341E2B4 Offset: 0x341A2B4 VA: 0x341E2B4
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x341E2E4 Offset: 0x341A2E4 VA: 0x341E2E4
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x341E324 Offset: 0x341A324 VA: 0x341E324
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x341E32C Offset: 0x341A32C VA: 0x341E32C
	public bool get_PreserveWhitespace() { }

	// RVA: 0x341E348 Offset: 0x341A348 VA: 0x341E348 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x341E350 Offset: 0x341A350 VA: 0x341E350
	public bool get_IsOpen() { }

	// RVA: 0x341E374 Offset: 0x341A374 VA: 0x341E374
	public void set_IsOpen(bool value) { }

	// RVA: 0x341E380 Offset: 0x341A380 VA: 0x341E380 Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x341E384 Offset: 0x341A384 VA: 0x341E384 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x341E3B4 Offset: 0x341A3B4 VA: 0x341E3B4 Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x341E3BC Offset: 0x341A3BC VA: 0x341E3BC Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x341E3C4 Offset: 0x341A3C4 VA: 0x341E3C4 Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x341E3CC Offset: 0x341A3CC VA: 0x341E3CC
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x341E43C Offset: 0x341A43C VA: 0x341E43C
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x341E664 Offset: 0x341A664 VA: 0x341E664
	private static void .cctor() { }
}
