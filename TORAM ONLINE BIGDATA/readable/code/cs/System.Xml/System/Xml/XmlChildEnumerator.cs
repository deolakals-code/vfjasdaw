// Assembly: System.Xml.dll
// Namespace: System.Xml
internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 13391
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0x33B3634 Offset: 0x33AF634 VA: 0x33B3634
	internal void .ctor(XmlNode container) { }

	// RVA: 0x33B369C Offset: 0x33AF69C VA: 0x33B369C Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x33B36A0 Offset: 0x33AF6A0 VA: 0x33B36A0
	internal bool MoveNext() { }

	// RVA: 0x33B3730 Offset: 0x33AF730 VA: 0x33B3730 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x33B3770 Offset: 0x33AF770 VA: 0x33B3770 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x33B3774 Offset: 0x33AF774 VA: 0x33B3774
	internal XmlNode get_Current() { }
}
