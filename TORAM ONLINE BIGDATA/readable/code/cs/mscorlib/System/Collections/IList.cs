// Assembly: mscorlib.dll
// Namespace: System.Collections
[DefaultMember("Item")]
public interface IList : ICollection, IEnumerable // TypeDefIndex: 10868
{
	// Properties
	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RemoveAt(int index);
}
