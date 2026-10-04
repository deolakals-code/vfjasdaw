// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 13615
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x342129C Offset: 0x341D29C VA: 0x342129C
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x342139C Offset: 0x341D39C VA: 0x342139C Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x3421574 Offset: 0x341D574 VA: 0x3421574 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x3421E54 Offset: 0x341DE54 VA: 0x3421E54 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x3421E6C Offset: 0x341DE6C VA: 0x3421E6C Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x34220D4 Offset: 0x341E0D4 VA: 0x34220D4 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}
