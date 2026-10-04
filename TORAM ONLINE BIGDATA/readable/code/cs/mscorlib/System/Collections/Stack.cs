// Assembly: mscorlib.dll
// Namespace: System.Collections
[DebuggerTypeProxy(typeof(Stack.StackDebugView))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 10892
{
	// Fields
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x2FBA7C4 Offset: 0x2FB67C4 VA: 0x2FBA7C4
	public void .ctor() { }

	// RVA: 0x2FBA830 Offset: 0x2FB6830 VA: 0x2FBA830
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2FBA908 Offset: 0x2FB6908 VA: 0x2FBA908 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x2FBA910 Offset: 0x2FB6910 VA: 0x2FBA910 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FBA918 Offset: 0x2FB6918 VA: 0x2FBA918 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FBA988 Offset: 0x2FB6988 VA: 0x2FBA988 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x2FBA9B8 Offset: 0x2FB69B8 VA: 0x2FBA9B8 Slot: 14
	public virtual object Clone() { }

	// RVA: 0x2FBAA48 Offset: 0x2FB6A48 VA: 0x2FBAA48 Slot: 15
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x2FBACF8 Offset: 0x2FB6CF8 VA: 0x2FBACF8 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FBADAC Offset: 0x2FB6DAC VA: 0x2FBADAC Slot: 17
	public virtual object Peek() { }

	// RVA: 0x2FBAE30 Offset: 0x2FB6E30 VA: 0x2FBAE30 Slot: 18
	public virtual object Pop() { }

	// RVA: 0x2FBAED0 Offset: 0x2FB6ED0 VA: 0x2FBAED0 Slot: 19
	public virtual void Push(object obj) { }
}
