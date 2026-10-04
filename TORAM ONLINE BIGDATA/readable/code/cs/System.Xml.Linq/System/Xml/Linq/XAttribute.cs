// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XAttribute : XObject // TypeDefIndex: 17503
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x32BAC0C Offset: 0x32B6C0C VA: 0x32BAC0C
	public void .ctor(XName name, object value) { }

	// RVA: 0x32BB344 Offset: 0x32B7344 VA: 0x32BB344
	public void .ctor(XAttribute other) { }

	// RVA: 0x32BB3D0 Offset: 0x32B73D0 VA: 0x32BB3D0
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x32BB488 Offset: 0x32B7488 VA: 0x32BB488
	public XName get_Name() { }

	// RVA: 0x32BB490 Offset: 0x32B7490 VA: 0x32BB490 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32BB498 Offset: 0x32B7498 VA: 0x32BB498
	public string get_Value() { }

	// RVA: 0x32BB4A0 Offset: 0x32B74A0 VA: 0x32BB4A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x32BB87C Offset: 0x32B787C VA: 0x32BB87C
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x32BB114 Offset: 0x32B7114 VA: 0x32BB114
	private static void ValidateAttribute(XName name, string value) { }
}
