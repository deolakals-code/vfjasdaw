// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 13421
{
	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x33C8BF0 Offset: 0x33C4BF0 VA: 0x33C8BF0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x33C8BF8 Offset: 0x33C4BF8 VA: 0x33C8BF8 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x33C8C00 Offset: 0x33C4C00 VA: 0x33C8C00 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33C8D30 Offset: 0x33C4D30 VA: 0x33C8D30 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33C8D50 Offset: 0x33C4D50 VA: 0x33C8D50 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33C8D70 Offset: 0x33C4D70 VA: 0x33C8D70 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33C8D90 Offset: 0x33C4D90 VA: 0x33C8D90 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x33C8DB0 Offset: 0x33C4DB0 VA: 0x33C8DB0 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x33C8DD0 Offset: 0x33C4DD0 VA: 0x33C8DD0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33C8DE4 Offset: 0x33C4DE4 VA: 0x33C8DE4
	internal void SetSpecified(bool f) { }
}
