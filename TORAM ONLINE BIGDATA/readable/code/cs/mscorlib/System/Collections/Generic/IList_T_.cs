// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 10941
{
	// Properties
	public abstract T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int IndexOf(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Insert(int index, T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RemoveAt(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IList<__Il2CppFullySharedGenericType>.RemoveAt
	*/
}
