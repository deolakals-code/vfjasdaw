// Assembly: mscorlib.dll
// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
[Serializable]
public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 10882
{
	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x2FB62F0 Offset: 0x2FB22F0 VA: 0x2FB62F0
	public void .ctor() { }

	// RVA: 0x2FB64C4 Offset: 0x2FB24C4 VA: 0x2FB64C4
	public void .ctor(int capacity) { }

	// RVA: 0x2FB62FC Offset: 0x2FB22FC VA: 0x2FB62FC
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x2FB64CC Offset: 0x2FB24CC VA: 0x2FB64CC
	public void .ctor(ICollection col) { }

	// RVA: 0x2FB6744 Offset: 0x2FB2744 VA: 0x2FB6744 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x2FB674C Offset: 0x2FB274C VA: 0x2FB674C Slot: 11
	public virtual object Clone() { }

	// RVA: 0x2FB6830 Offset: 0x2FB2830 VA: 0x2FB6830 Slot: 12
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FB6838 Offset: 0x2FB2838 VA: 0x2FB6838 Slot: 13
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FB68AC Offset: 0x2FB28AC VA: 0x2FB68AC Slot: 14
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x2FB6A90 Offset: 0x2FB2A90 VA: 0x2FB6A90 Slot: 15
	public virtual void Enqueue(object obj) { }

	// RVA: 0x2FB6C8C Offset: 0x2FB2C8C VA: 0x2FB6C8C Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FB6D5C Offset: 0x2FB2D5C VA: 0x2FB6D5C Slot: 17
	public virtual object Dequeue() { }

	// RVA: 0x2FB6E3C Offset: 0x2FB2E3C VA: 0x2FB6E3C Slot: 18
	public virtual object Peek() { }

	// RVA: 0x2FB6ECC Offset: 0x2FB2ECC VA: 0x2FB6ECC
	internal object GetElement(int i) { }

	// RVA: 0x2FB6B94 Offset: 0x2FB2B94 VA: 0x2FB6B94
	private void SetCapacity(int capacity) { }
}
