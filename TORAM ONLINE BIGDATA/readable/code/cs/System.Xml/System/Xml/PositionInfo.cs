// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class PositionInfo : IXmlLineInfo // TypeDefIndex: 13426
{
	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x33C964C Offset: 0x33C564C VA: 0x33C964C Slot: 7
	public virtual bool HasLineInfo() { }

	// RVA: 0x33C9654 Offset: 0x33C5654 VA: 0x33C9654 Slot: 8
	public virtual int get_LineNumber() { }

	// RVA: 0x33C965C Offset: 0x33C565C VA: 0x33C965C Slot: 9
	public virtual int get_LinePosition() { }

	// RVA: 0x33C9664 Offset: 0x33C5664 VA: 0x33C9664
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x33C9750 Offset: 0x33C5750 VA: 0x33C9750
	public void .ctor() { }
}
