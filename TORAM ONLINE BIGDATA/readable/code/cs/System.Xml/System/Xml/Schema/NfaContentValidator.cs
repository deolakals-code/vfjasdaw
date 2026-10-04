// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 13613
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x3420B84 Offset: 0x341CB84 VA: 0x3420B84
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x3420C70 Offset: 0x341CC70 VA: 0x3420C70 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x3420D44 Offset: 0x341CD44 VA: 0x3420D44 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x3420EF4 Offset: 0x341CEF4 VA: 0x3420EF4 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x3420F3C Offset: 0x341CF3C VA: 0x3420F3C Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x3421120 Offset: 0x341D120 VA: 0x3421120 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
