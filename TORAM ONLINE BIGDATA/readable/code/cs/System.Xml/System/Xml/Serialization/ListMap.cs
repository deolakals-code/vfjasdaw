// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class ListMap : ObjectMap // TypeDefIndex: 13570
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x3413910 Offset: 0x340F910 VA: 0x3413910
	public void set_ChoiceMember(string value) { }

	// RVA: 0x3413918 Offset: 0x340F918 VA: 0x3413918
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x3413920 Offset: 0x340F920 VA: 0x3413920
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x340D4A8 Offset: 0x34094A8 VA: 0x340D4A8
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x3413928 Offset: 0x340F928 VA: 0x3413928
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x3413C44 Offset: 0x340FC44 VA: 0x3413C44
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x340D278 Offset: 0x3409278 VA: 0x340D278
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x3413F30 Offset: 0x340FF30 VA: 0x3413F30 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3414094 Offset: 0x3410094 VA: 0x3414094 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x341409C Offset: 0x341009C VA: 0x341409C
	public void .ctor() { }
}
