// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 10880
{
	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x2FB6CE4 Offset: 0x2FB2CE4 VA: 0x2FB6CE4
	internal void .ctor(Queue q) { }

	// RVA: 0x2FB6F0C Offset: 0x2FB2F0C VA: 0x2FB6F0C Slot: 7
	public object Clone() { }

	// RVA: 0x2FB6F14 Offset: 0x2FB2F14 VA: 0x2FB6F14 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x2FB6FF8 Offset: 0x2FB2FF8 VA: 0x2FB6FF8 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x2FB7088 Offset: 0x2FB3088 VA: 0x2FB7088 Slot: 10
	public virtual void Reset() { }
}
