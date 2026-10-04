// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 16096
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(2)]
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0x30E3414 Offset: 0x30DF414 VA: 0x30E3414
	private XContainer get_Container() { }

	// RVA: 0x30E1D7C Offset: 0x30DDD7C VA: 0x30E1D7C
	public void .ctor(XContainer container) { }

	// RVA: 0x30E1F18 Offset: 0x30DDF18 VA: 0x30E1F18 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x30E2374 Offset: 0x30DE374 VA: 0x30E2374 Slot: 21
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(2)]
	// RVA: 0x30E348C Offset: 0x30DF48C VA: 0x30E348C Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0x30E2F54 Offset: 0x30DEF54 VA: 0x30E2F54
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0x30E2D70 Offset: 0x30DED70 VA: 0x30E2D70 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}
