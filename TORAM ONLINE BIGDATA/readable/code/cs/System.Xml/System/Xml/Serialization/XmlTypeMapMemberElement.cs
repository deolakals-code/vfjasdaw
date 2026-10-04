// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 13560
{
	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0x3410B2C Offset: 0x340CB2C VA: 0x3410B2C
	public void .ctor() { }

	// RVA: 0x340AC44 Offset: 0x3406C44 VA: 0x340AC44
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x3410B30 Offset: 0x340CB30 VA: 0x3410B30
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x3410B38 Offset: 0x340CB38 VA: 0x3410B38
	public string get_ChoiceMember() { }

	// RVA: 0x3410B40 Offset: 0x340CB40 VA: 0x3410B40
	public void set_ChoiceMember(string value) { }

	// RVA: 0x3410B48 Offset: 0x340CB48 VA: 0x3410B48
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x3410B50 Offset: 0x340CB50 VA: 0x3410B50
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x340C0A0 Offset: 0x34080A0 VA: 0x340C0A0
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x3410B58 Offset: 0x340CB58 VA: 0x3410B58
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x3410B68 Offset: 0x340CB68 VA: 0x3410B68
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x3410B70 Offset: 0x340CB70 VA: 0x3410B70
	public void set_IsXmlTextCollector(bool value) { }
}
