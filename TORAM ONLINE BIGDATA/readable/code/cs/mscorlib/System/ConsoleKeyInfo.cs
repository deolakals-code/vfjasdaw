// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct ConsoleKeyInfo // TypeDefIndex: 9712
{
	// Fields
	private readonly char _keyChar; // 0x0
	private readonly ConsoleKey _key; // 0x4
	private readonly ConsoleModifiers _mods; // 0x8

	// Properties
	public char KeyChar { get; }
	public ConsoleKey Key { get; }

	// Methods

	// RVA: 0x3005430 Offset: 0x3001430 VA: 0x3005430
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x30054CC Offset: 0x30014CC VA: 0x30054CC
	public char get_KeyChar() { }

	// RVA: 0x30054D4 Offset: 0x30014D4 VA: 0x30054D4
	public ConsoleKey get_Key() { }

	// RVA: 0x30054DC Offset: 0x30014DC VA: 0x30054DC Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3005574 Offset: 0x3001574 VA: 0x3005574
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x30055A8 Offset: 0x30015A8 VA: 0x30055A8 Slot: 2
	public override int GetHashCode() { }
}
