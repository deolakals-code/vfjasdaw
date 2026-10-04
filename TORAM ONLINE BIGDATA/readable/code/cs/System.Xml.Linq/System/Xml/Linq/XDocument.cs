// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XDocument : XContainer // TypeDefIndex: 17510
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x32BFBDC Offset: 0x32BBBDC VA: 0x32BFBDC
	public void .ctor() { }

	// RVA: 0x32BFBE4 Offset: 0x32BBBE4 VA: 0x32BFBE4
	public void .ctor(XDocument other) { }

	// RVA: 0x32BFC70 Offset: 0x32BBC70 VA: 0x32BFC70
	public XDeclaration get_Declaration() { }

	// RVA: 0x32BFC78 Offset: 0x32BBC78 VA: 0x32BFC78
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x32BFC80 Offset: 0x32BBC80 VA: 0x32BFC80 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32BFC88 Offset: 0x32BBC88 VA: 0x32BFC88
	public XElement get_Root() { }

	// RVA: 0x32BFCD0 Offset: 0x32BBCD0 VA: 0x32BFCD0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x32BFDFC Offset: 0x32BBDFC VA: 0x32BFDFC Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x32BFE48 Offset: 0x32BBE48 VA: 0x32BFE48 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x32BFE94 Offset: 0x32BBE94 VA: 0x32BFE94 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBFF4 Offset: 0x26F7FF4 VA: 0x26FBFF4
	|-XDocument.GetFirstNode<object>
	*/

	// RVA: 0x32BFEEC Offset: 0x32BBEEC VA: 0x32BFEEC
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x32BFF80 Offset: 0x32BBF80 VA: 0x32BFF80 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x32C0124 Offset: 0x32BC124 VA: 0x32C0124
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x32C0248 Offset: 0x32BC248 VA: 0x32C0248 Slot: 14
	internal override void ValidateString(string s) { }
}
