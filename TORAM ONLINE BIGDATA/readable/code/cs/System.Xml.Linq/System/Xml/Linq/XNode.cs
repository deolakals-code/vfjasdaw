// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public abstract class XNode : XObject // TypeDefIndex: 17527
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x32BBE14 Offset: 0x32B7E14 VA: 0x32BBE14
	internal void .ctor() { }

	// RVA: 0x32C2D9C Offset: 0x32BED9C VA: 0x32C2D9C
	public void Remove() { }

	// RVA: 0x32C2DFC Offset: 0x32BEDFC VA: 0x32C2DFC Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x32C3370 Offset: 0x32BF370 VA: 0x32C3370 Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x32C2EF8 Offset: 0x32BEEF8 VA: 0x32C2EF8
	private string GetXmlString(SaveOptions o) { }
}
