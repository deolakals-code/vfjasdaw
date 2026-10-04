// Assembly: System.Xml.dll
// Namespace: System.Xml
public class NameTable : XmlNameTable // TypeDefIndex: 13431
{
	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x33C9950 Offset: 0x33C5950 VA: 0x33C9950
	public void .ctor() { }

	// RVA: 0x33C99CC Offset: 0x33C59CC VA: 0x33C99CC Slot: 6
	public override string Add(string key) { }

	// RVA: 0x33C9C54 Offset: 0x33C5C54 VA: 0x33C9C54 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0x33C9E90 Offset: 0x33C5E90 VA: 0x33C9E90 Slot: 4
	public override string Get(string value) { }

	// RVA: 0x33C9B44 Offset: 0x33C5B44 VA: 0x33C9B44
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x33CA048 Offset: 0x33C6048 VA: 0x33CA048
	private void Grow() { }

	// RVA: 0x33C9DD4 Offset: 0x33C5DD4 VA: 0x33C9DD4
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}
