// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[IsReadOnly]
[DefaultMember("Item")]
[NullableContext(1)]
[Nullable(0)]
internal struct StringReference // TypeDefIndex: 15959
{
	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x308A2E0 Offset: 0x30862E0 VA: 0x308A2E0
	public char get_Item(int i) { }

	// RVA: 0x3099B20 Offset: 0x3095B20 VA: 0x3099B20
	public char[] get_Chars() { }

	// RVA: 0x3099B28 Offset: 0x3095B28 VA: 0x3099B28
	public int get_StartIndex() { }

	// RVA: 0x3099B30 Offset: 0x3095B30 VA: 0x3099B30
	public int get_Length() { }

	// RVA: 0x308A9CC Offset: 0x30869CC VA: 0x308A9CC
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x308A608 Offset: 0x3086608 VA: 0x308A608 Slot: 3
	public override string ToString() { }
}
