// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 10890
{
	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x2FBAD50 Offset: 0x2FB6D50 VA: 0x2FBAD50
	internal void .ctor(Stack stack) { }

	// RVA: 0x2FBAFF0 Offset: 0x2FB6FF0 VA: 0x2FBAFF0 Slot: 7
	public object Clone() { }

	// RVA: 0x2FBAFF8 Offset: 0x2FB6FF8 VA: 0x2FBAFF8 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x2FBB10C Offset: 0x2FB710C VA: 0x2FBB10C Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x2FBB198 Offset: 0x2FB7198 VA: 0x2FBB198 Slot: 10
	public virtual void Reset() { }
}
