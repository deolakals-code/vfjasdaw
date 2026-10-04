// Assembly: System.Xml.dll
// Namespace: 
private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 13860
{
	// Fields
	public SchemaNames.Token Name; // 0x10
	public XsdBuilder.State CurrentState; // 0x14
	public XsdBuilder.State[] NextStates; // 0x18
	public XsdBuilder.XsdAttributeEntry[] Attributes; // 0x20
	public XsdBuilder.XsdInitFunction InitFunc; // 0x28
	public XsdBuilder.XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x33783E8 Offset: 0x33743E8 VA: 0x33783E8
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }
}
