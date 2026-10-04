// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
public interface ICollection<T> : IEnumerable<T>, IEnumerable // TypeDefIndex: 10931
{
	// Properties
	public abstract int Count { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Count();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Contains(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void CopyTo(T[] array, int arrayIndex);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Remove(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ICollection<__Il2CppFullySharedGenericType>.Remove
	*/
}
