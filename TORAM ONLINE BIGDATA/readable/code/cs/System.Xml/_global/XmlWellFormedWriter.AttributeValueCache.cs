// Assembly: System.Xml.dll
// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache // TypeDefIndex: 13372
{
	// Fields
	private StringBuilder stringValue; // 0x10
	private string singleStringValue; // 0x18
	private XmlWellFormedWriter.AttributeValueCache.Item[] items; // 0x20
	private int firstItem; // 0x28
	private int lastItem; // 0x2C

	// Properties
	internal string StringValue { get; }

	// Methods

	// RVA: 0x33A862C Offset: 0x33A462C VA: 0x33A862C
	internal string get_StringValue() { }

	// RVA: 0x33A8660 Offset: 0x33A4660 VA: 0x33A8660
	internal void WriteEntityRef(string name) { }

	// RVA: 0x33A89EC Offset: 0x33A49EC VA: 0x33A89EC
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x33A8A80 Offset: 0x33A4A80 VA: 0x33A8A80
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x33A8B44 Offset: 0x33A4B44 VA: 0x33A8B44
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x33A8B94 Offset: 0x33A4B94 VA: 0x33A8B94
	internal void WriteString(string text) { }

	// RVA: 0x33A8C08 Offset: 0x33A4C08 VA: 0x33A8C08
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x33A8D08 Offset: 0x33A4D08 VA: 0x33A8D08
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x33A8DC0 Offset: 0x33A4DC0 VA: 0x33A8DC0
	internal void WriteRaw(string data) { }

	// RVA: 0x33A8E10 Offset: 0x33A4E10 VA: 0x33A8E10
	internal void WriteValue(string value) { }

	// RVA: 0x33A8E60 Offset: 0x33A4E60 VA: 0x33A8E60
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x33A9184 Offset: 0x33A5184 VA: 0x33A9184
	internal void Trim() { }

	// RVA: 0x33A961C Offset: 0x33A561C VA: 0x33A961C
	internal void Clear() { }

	// RVA: 0x33A87FC Offset: 0x33A47FC VA: 0x33A87FC
	private void StartComplexValue() { }

	// RVA: 0x33A884C Offset: 0x33A484C VA: 0x33A884C
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x33A9670 Offset: 0x33A5670 VA: 0x33A9670
	public void .ctor() { }
}
