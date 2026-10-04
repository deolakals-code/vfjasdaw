// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class ForwardAxis // TypeDefIndex: 13579
{
	// Fields
	private DoubleLinkAxis _topNode; // 0x10
	private DoubleLinkAxis _rootNode; // 0x18
	private bool _isAttribute; // 0x20
	private bool _isDss; // 0x21
	private bool _isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x3415A24 Offset: 0x3411A24 VA: 0x3415A24
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x3415A2C Offset: 0x3411A2C VA: 0x3415A2C
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x3415A34 Offset: 0x3411A34 VA: 0x3415A34
	internal bool get_IsAttribute() { }

	// RVA: 0x3415A3C Offset: 0x3411A3C VA: 0x3415A3C
	internal bool get_IsDss() { }

	// RVA: 0x3415A44 Offset: 0x3411A44 VA: 0x3415A44
	internal bool get_IsSelfAxis() { }

	// RVA: 0x3415A4C Offset: 0x3411A4C VA: 0x3415A4C
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }
}
