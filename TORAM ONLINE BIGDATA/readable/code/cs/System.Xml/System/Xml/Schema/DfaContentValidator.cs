// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 13612
{
	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x3420430 Offset: 0x341C430 VA: 0x3420430
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x34206A8 Offset: 0x341C6A8 VA: 0x34206A8 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x342070C Offset: 0x341C70C VA: 0x342070C Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x342081C Offset: 0x341C81C VA: 0x342081C Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x3420834 Offset: 0x341C834 VA: 0x3420834 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x3420A00 Offset: 0x341CA00 VA: 0x3420A00 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
