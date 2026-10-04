// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlReflectionImporter // TypeDefIndex: 13529
{
	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x33F2C90 Offset: 0x33EEC90 VA: 0x33F2C90
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x33F2DCC Offset: 0x33EEDCC VA: 0x33F2DCC
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x33F2FB4 Offset: 0x33EEFB4 VA: 0x33F2FB4
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x33F2DD8 Offset: 0x33EEDD8 VA: 0x33F2DD8
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F2FC0 Offset: 0x33EEFC0 VA: 0x33F2FC0
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F5B88 Offset: 0x33F1B88 VA: 0x33F5B88
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x33F6070 Offset: 0x33F2070 VA: 0x33F6070
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x33F3440 Offset: 0x33EF440 VA: 0x33F3440
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x33F7A80 Offset: 0x33F3A80 VA: 0x33F7A80
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x33F6100 Offset: 0x33F2100 VA: 0x33F6100
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F7CD4 Offset: 0x33F3CD4 VA: 0x33F7CD4
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x33F4428 Offset: 0x33F0428 VA: 0x33F4428
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x33F51D4 Offset: 0x33F11D4 VA: 0x33F51D4
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F53B4 Offset: 0x33F13B4 VA: 0x33F53B4
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F5468 Offset: 0x33F1468 VA: 0x33F5468
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F5A74 Offset: 0x33F1A74 VA: 0x33F5A74
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x33F7B9C Offset: 0x33F3B9C VA: 0x33F7B9C
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x33F620C Offset: 0x33F220C VA: 0x33F620C
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x33F6FFC Offset: 0x33F2FFC VA: 0x33F6FFC
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x33F8474 Offset: 0x33F4474 VA: 0x33F8474
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x33F7DD4 Offset: 0x33F3DD4 VA: 0x33F7DD4
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x33F9744 Offset: 0x33F5744 VA: 0x33F9744
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x33F5FDC Offset: 0x33F1FDC VA: 0x33F5FDC
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x33F9A90 Offset: 0x33F5A90 VA: 0x33F9A90
	public void IncludeType(Type type) { }

	// RVA: 0x33F9578 Offset: 0x33F5578 VA: 0x33F9578
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x33F9F88 Offset: 0x33F5F88 VA: 0x33F9F88
	private static void .cctor() { }
}
