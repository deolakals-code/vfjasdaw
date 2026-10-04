// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 16099
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	[Nullable(2)]
	public override string Value { get; }
	[Nullable(2)]
	public override string LocalName { get; }
	[Nullable(2)]
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x30E3718 Offset: 0x30DF718 VA: 0x30E3718
	private XElement get_Element() { }

	// RVA: 0x30E297C Offset: 0x30DE97C VA: 0x30E297C
	public void .ctor(XElement element) { }

	// RVA: 0x30E3790 Offset: 0x30DF790 VA: 0x30E3790 Slot: 22
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x30E383C Offset: 0x30DF83C VA: 0x30E383C Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0x30E3DC4 Offset: 0x30DFDC4 VA: 0x30E3DC4
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0x30E42B0 Offset: 0x30E02B0 VA: 0x30E42B0 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(2)]
	// RVA: 0x30E42E4 Offset: 0x30E02E4 VA: 0x30E42E4 Slot: 18
	public override string get_Value() { }

	[NullableContext(2)]
	// RVA: 0x30E4300 Offset: 0x30E0300 VA: 0x30E4300 Slot: 14
	public override string get_LocalName() { }

	[NullableContext(2)]
	// RVA: 0x30E4324 Offset: 0x30E0324 VA: 0x30E4324 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0x30E4270 Offset: 0x30E0270 VA: 0x30E4270 Slot: 23
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x30E4348 Offset: 0x30E0348 VA: 0x30E4348 Slot: 24
	public bool get_IsEmpty() { }
}
