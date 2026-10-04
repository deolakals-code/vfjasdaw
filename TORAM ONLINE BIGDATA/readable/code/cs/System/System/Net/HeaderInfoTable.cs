// Assembly: System.dll
// Namespace: System.Net
[DefaultMember("Item")]
internal class HeaderInfoTable // TypeDefIndex: 14421
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x34F47F8 Offset: 0x34F07F8 VA: 0x34F47F8
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x34F4870 Offset: 0x34F0870 VA: 0x34F4870
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x34F4A74 Offset: 0x34F0A74 VA: 0x34F4A74
	private static void .cctor() { }

	// RVA: 0x34F0038 Offset: 0x34EC038 VA: 0x34F0038
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x34F2634 Offset: 0x34EE634 VA: 0x34F2634
	public void .ctor() { }
}
