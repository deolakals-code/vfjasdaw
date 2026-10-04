// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlLoader // TypeDefIndex: 13404
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x33B1848 Offset: 0x33AD848 VA: 0x33B1848
	public void .ctor() { }

	// RVA: 0x33B7830 Offset: 0x33B3830 VA: 0x33B7830
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x33BBAE4 Offset: 0x33B7AE4 VA: 0x33BBAE4
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x33B7580 Offset: 0x33B3580 VA: 0x33B7580
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x33BBB50 Offset: 0x33B7B50 VA: 0x33BBB50
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x33BC0D4 Offset: 0x33B80D4 VA: 0x33BC0D4
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x33BCA50 Offset: 0x33B8A50 VA: 0x33BCA50
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x33BCBEC Offset: 0x33B8BEC VA: 0x33BCBEC
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x33BC408 Offset: 0x33B8408 VA: 0x33BC408
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x33BC5F0 Offset: 0x33B85F0 VA: 0x33BC5F0
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x33BC794 Offset: 0x33B8794 VA: 0x33BC794
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x33BCEF8 Offset: 0x33B8EF8 VA: 0x33BCEF8
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x33BDE88 Offset: 0x33B9E88 VA: 0x33BDE88
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x33B9128 Offset: 0x33B5128 VA: 0x33B9128
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x33BDFC8 Offset: 0x33B9FC8 VA: 0x33BDFC8
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x33BD334 Offset: 0x33B9334 VA: 0x33BD334
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x33BE2A0 Offset: 0x33BA2A0 VA: 0x33BE2A0
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x33B8A48 Offset: 0x33B4A48 VA: 0x33B8A48
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x33BA880 Offset: 0x33B6880 VA: 0x33BA880
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x33B1850 Offset: 0x33AD850 VA: 0x33B1850
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x33BEE10 Offset: 0x33BAE10 VA: 0x33BEE10
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x33BF0B0 Offset: 0x33BB0B0 VA: 0x33BF0B0
	private string EntitizeName(string name) { }

	// RVA: 0x33BAC28 Offset: 0x33B6C28 VA: 0x33BAC28
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x33BAE9C Offset: 0x33B6E9C VA: 0x33BAE9C
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x33BEB88 Offset: 0x33BAB88 VA: 0x33BEB88
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x33B4194 Offset: 0x33B0194 VA: 0x33B4194
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x33BC940 Offset: 0x33B8940 VA: 0x33BC940
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }
}
