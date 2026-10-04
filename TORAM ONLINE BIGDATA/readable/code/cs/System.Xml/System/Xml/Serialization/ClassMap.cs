// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class ClassMap : ObjectMap // TypeDefIndex: 13569
{
	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	// Properties
	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }

	// Methods

	// RVA: 0x3411C58 Offset: 0x340DC58 VA: 0x3411C58
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x3412920 Offset: 0x340E920 VA: 0x3412920
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x34129CC Offset: 0x340E9CC VA: 0x34129CC
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x3412A88 Offset: 0x340EA88 VA: 0x3412A88
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x3412E50 Offset: 0x340EE50 VA: 0x3412E50
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x3412840 Offset: 0x340E840 VA: 0x3412840
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x34131E8 Offset: 0x340F1E8 VA: 0x34131E8
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x34135C8 Offset: 0x340F5C8 VA: 0x34135C8
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x34135D0 Offset: 0x340F5D0 VA: 0x34135D0
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x34135D8 Offset: 0x340F5D8 VA: 0x34135D8
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x340A5D4 Offset: 0x34065D4 VA: 0x340A5D4
	public ICollection get_AttributeMembers() { }

	// RVA: 0x34135E0 Offset: 0x340F5E0 VA: 0x34135E0
	public ICollection get_ElementMembers() { }

	// RVA: 0x34135E8 Offset: 0x340F5E8 VA: 0x34135E8
	public ArrayList get_AllMembers() { }

	// RVA: 0x34135F0 Offset: 0x340F5F0 VA: 0x34135F0
	public ArrayList get_FlatLists() { }

	// RVA: 0x34135F8 Offset: 0x340F5F8 VA: 0x34135F8
	public ArrayList get_ListMembers() { }

	// RVA: 0x3413600 Offset: 0x340F600 VA: 0x3413600
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x3413608 Offset: 0x340F608 VA: 0x3413608
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x3413610 Offset: 0x340F610 VA: 0x3413610
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x34137E4 Offset: 0x340F7E4 VA: 0x34137E4
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x34137F0 Offset: 0x340F7F0 VA: 0x34137F0
	public bool get_HasSimpleContent() { }

	// RVA: 0x341385C Offset: 0x340F85C VA: 0x341385C
	public void .ctor() { }
}
