// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 13754
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[Xml("namespace")]
	public string Namespace { set; }
	[DefaultValue(0)]
	[Xml("processContents")]
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x3332F1C Offset: 0x332EF1C VA: 0x3332F1C
	public void set_Namespace(string value) { }

	// RVA: 0x3332F24 Offset: 0x332EF24 VA: 0x3332F24
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x3332F2C Offset: 0x332EF2C VA: 0x3332F2C
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x3332F34 Offset: 0x332EF34 VA: 0x3332F34
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x3332F3C Offset: 0x332EF3C VA: 0x3332F3C
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x3332F50 Offset: 0x332EF50 VA: 0x3332F50
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x3332FD8 Offset: 0x332EFD8 VA: 0x3332FD8
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x3333080 Offset: 0x332F080 VA: 0x3333080
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x33330A8 Offset: 0x332F0A8 VA: 0x33330A8
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x33330CC Offset: 0x332F0CC VA: 0x33330CC
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x3333198 Offset: 0x332F198 VA: 0x3333198
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x3333190 Offset: 0x332F190 VA: 0x3333190
	public void .ctor() { }
}
