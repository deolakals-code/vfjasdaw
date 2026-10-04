// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XObjectWrapper : IXmlNode // TypeDefIndex: 16097
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x30E1B58 Offset: 0x30DDB58 VA: 0x30E1B58
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x30E34D0 Offset: 0x30DF4D0 VA: 0x30E34D0 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0x30E34D8 Offset: 0x30DF4D8 VA: 0x30E34D8 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x30E34F0 Offset: 0x30DF4F0 VA: 0x30E34F0 Slot: 14
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x30E34F8 Offset: 0x30DF4F8 VA: 0x30E34F8 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x30E3550 Offset: 0x30DF550 VA: 0x30E3550 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x30E35A8 Offset: 0x30DF5A8 VA: 0x30E35A8 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x30E35B0 Offset: 0x30DF5B0 VA: 0x30E35B0 Slot: 18
	public virtual string get_Value() { }

	[NullableContext(1)]
	// RVA: 0x30E35B8 Offset: 0x30DF5B8 VA: 0x30E35B8 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x30E35F0 Offset: 0x30DF5F0 VA: 0x30E35F0 Slot: 20
	public virtual string get_NamespaceUri() { }
}
