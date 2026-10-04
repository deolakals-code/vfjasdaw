// Assembly: mscorlib.dll
// Namespace: System.Collections
public interface ICollection : IEnumerable // TypeDefIndex: 10861
{
	// Properties
	public abstract int Count { get; }
	public abstract object SyncRoot { get; }
	public abstract bool IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_SyncRoot();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsSynchronized();
}
