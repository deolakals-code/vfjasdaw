// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 13616
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0x34222D8 Offset: 0x341E2D8 VA: 0x34222D8
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x3422400 Offset: 0x341E400 VA: 0x3422400
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x3422550 Offset: 0x341E550 VA: 0x3422550 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0x3422570 Offset: 0x341E570 VA: 0x3422570 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x342260C Offset: 0x341E60C VA: 0x342260C Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x3422754 Offset: 0x341E754 VA: 0x3422754 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x34227A4 Offset: 0x341E7A4 VA: 0x34227A4 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x3422BD4 Offset: 0x341EBD4 VA: 0x3422BD4 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
