// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 13394
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x33B3A6C Offset: 0x33AFA6C VA: 0x33B3A6C
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x33B3E48 Offset: 0x33AFE48 VA: 0x33B3E48
	public string get_Version() { }

	// RVA: 0x33B3E50 Offset: 0x33AFE50 VA: 0x33B3E50
	internal void set_Version(string value) { }

	// RVA: 0x33B3E58 Offset: 0x33AFE58 VA: 0x33B3E58
	public string get_Encoding() { }

	// RVA: 0x33B3C88 Offset: 0x33AFC88 VA: 0x33B3C88
	public void set_Encoding(string value) { }

	// RVA: 0x33B3E60 Offset: 0x33AFE60 VA: 0x33B3E60
	public string get_Standalone() { }

	// RVA: 0x33B3CF8 Offset: 0x33AFCF8 VA: 0x33B3CF8
	public void set_Standalone(string value) { }

	// RVA: 0x33B3E68 Offset: 0x33AFE68 VA: 0x33B3E68 Slot: 7
	public override string get_Value() { }

	// RVA: 0x33B3E78 Offset: 0x33AFE78 VA: 0x33B3E78 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33B3E88 Offset: 0x33AFE88 VA: 0x33B3E88 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x33B3FFC Offset: 0x33AFFFC VA: 0x33B3FFC Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33B43EC Offset: 0x33B03EC VA: 0x33B43EC Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B442C Offset: 0x33B042C VA: 0x33B442C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B4438 Offset: 0x33B0438 VA: 0x33B4438 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B4440 Offset: 0x33B0440 VA: 0x33B4440 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B447C Offset: 0x33B047C VA: 0x33B447C Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33B44E0 Offset: 0x33B04E0 VA: 0x33B44E0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33B3C0C Offset: 0x33AFC0C VA: 0x33B3C0C
	private bool IsValidXmlVersion(string ver) { }
}
