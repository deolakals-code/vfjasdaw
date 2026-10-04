// Assembly: mscorlib.dll
// Namespace: 
private sealed class Array.ArrayEnumerator : IEnumerator, ICloneable // TypeDefIndex: 9722
{
	// Fields
	private Array _array; // 0x10
	private int _index; // 0x18
	private int _endIndex; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x300B56C Offset: 0x300756C VA: 0x300B56C
	internal void .ctor(Array array) { }

	// RVA: 0x300B5C4 Offset: 0x30075C4 VA: 0x300B5C4 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x300B5EC Offset: 0x30075EC VA: 0x300B5EC Slot: 6
	public void Reset() { }

	// RVA: 0x300B5F8 Offset: 0x30075F8 VA: 0x300B5F8 Slot: 7
	public object Clone() { }

	// RVA: 0x300B600 Offset: 0x3007600 VA: 0x300B600 Slot: 5
	public object get_Current() { }
}
