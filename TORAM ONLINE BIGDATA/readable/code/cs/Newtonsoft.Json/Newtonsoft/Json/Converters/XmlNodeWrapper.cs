// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 16084
{
	// Fields
	[Nullable(1)]
	private readonly XmlNode _node; // 0x10
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public List<IXmlNode> Attributes { get; }
	private bool HasAttributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x30E02EC Offset: 0x30DC2EC VA: 0x30E02EC
	public void .ctor(XmlNode node) { }

	// RVA: 0x30E0DF8 Offset: 0x30DCDF8 VA: 0x30E0DF8 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0x30E0E00 Offset: 0x30DCE00 VA: 0x30E0E00 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0x30E0E20 Offset: 0x30DCE20 VA: 0x30E0E20 Slot: 13
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x30E0E44 Offset: 0x30DCE44 VA: 0x30E0E44 Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x30E1290 Offset: 0x30DD290 VA: 0x30E1290
	internal static IXmlNode WrapNode(XmlNode node) { }

	[NullableContext(1)]
	// RVA: 0x30E1474 Offset: 0x30DD474 VA: 0x30E1474 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0x30E18B8 Offset: 0x30DD8B8 VA: 0x30E18B8
	private bool get_HasAttributes() { }

	// RVA: 0x30E196C Offset: 0x30DD96C VA: 0x30E196C Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0x30E1A0C Offset: 0x30DDA0C VA: 0x30E1A0C Slot: 9
	public string get_Value() { }

	// RVA: 0x30E0A5C Offset: 0x30DCA5C VA: 0x30E0A5C Slot: 14
	public void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x30E1A2C Offset: 0x30DDA2C VA: 0x30E1A2C Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x30E1AEC Offset: 0x30DDAEC VA: 0x30E1AEC Slot: 11
	public string get_NamespaceUri() { }
}
