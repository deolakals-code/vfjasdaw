// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class ReaderPositionInfo : PositionInfo // TypeDefIndex: 13427
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Properties
	public override int LineNumber { get; }
	public override int LinePosition { get; }

	// Methods

	// RVA: 0x33C9720 Offset: 0x33C5720 VA: 0x33C9720
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x33C9758 Offset: 0x33C5758 VA: 0x33C9758 Slot: 7
	public override bool HasLineInfo() { }

	// RVA: 0x33C97F8 Offset: 0x33C57F8 VA: 0x33C97F8 Slot: 8
	public override int get_LineNumber() { }

	// RVA: 0x33C989C Offset: 0x33C589C VA: 0x33C989C Slot: 9
	public override int get_LinePosition() { }
}
