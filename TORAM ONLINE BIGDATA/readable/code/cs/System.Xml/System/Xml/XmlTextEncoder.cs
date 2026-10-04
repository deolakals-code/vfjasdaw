// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlTextEncoder // TypeDefIndex: 13330
{
	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0x3394774 Offset: 0x3390774 VA: 0x3394774
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x33947C4 Offset: 0x33907C4 VA: 0x33947C4
	internal void set_QuoteChar(char value) { }

	// RVA: 0x33947CC Offset: 0x33907CC VA: 0x33947CC
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x339487C Offset: 0x339087C VA: 0x339487C
	internal void EndAttribute() { }

	// RVA: 0x33948B4 Offset: 0x33908B4 VA: 0x33948B4
	internal string get_AttributeValue() { }

	// RVA: 0x3394928 Offset: 0x3390928 VA: 0x3394928
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0x33949DC Offset: 0x33909DC VA: 0x33949DC
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0x3394EE8 Offset: 0x3390EE8 VA: 0x3394EE8
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x3395074 Offset: 0x3391074 VA: 0x3395074
	internal void Write(string text) { }

	// RVA: 0x3395558 Offset: 0x3391558 VA: 0x3395558
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x3395748 Offset: 0x3391748 VA: 0x3395748
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0x3395874 Offset: 0x3391874 VA: 0x3395874
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x3395A48 Offset: 0x3391A48 VA: 0x3395A48
	internal void WriteEntityRef(string name) { }

	// RVA: 0x33954B0 Offset: 0x33914B0 VA: 0x33954B0
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0x3394DFC Offset: 0x3390DFC VA: 0x3394DFC
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0x33959B0 Offset: 0x33919B0 VA: 0x33959B0
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x3394E78 Offset: 0x3390E78 VA: 0x3394E78
	private void WriteEntityRefImpl(string name) { }
}
