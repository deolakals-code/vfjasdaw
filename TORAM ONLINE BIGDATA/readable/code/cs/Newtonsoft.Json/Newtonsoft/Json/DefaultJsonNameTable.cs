// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 15828
{
	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private DefaultJsonNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x306C7C8 Offset: 0x30687C8 VA: 0x306C7C8
	private static void .cctor() { }

	// RVA: 0x306C818 Offset: 0x3068818 VA: 0x306C818
	public void .ctor() { }

	// RVA: 0x306C890 Offset: 0x3068890 VA: 0x306C890 Slot: 4
	public override string Get(char[] key, int start, int length) { }

	// RVA: 0x306CAE0 Offset: 0x3068AE0 VA: 0x306CAE0
	public string Add(string key) { }

	// RVA: 0x306CC94 Offset: 0x3068C94 VA: 0x306CC94
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x306CDFC Offset: 0x3068DFC VA: 0x306CDFC
	private void Grow() { }

	// RVA: 0x306CA24 Offset: 0x3068A24 VA: 0x306CA24
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}
