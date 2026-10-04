// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlNode // TypeDefIndex: 16089
{
	// Properties
	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IXmlNode> get_ChildNodes();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<IXmlNode> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode get_ParentNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode AppendChild(IXmlNode newChild);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_NamespaceUri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object get_WrappedNode();
}
