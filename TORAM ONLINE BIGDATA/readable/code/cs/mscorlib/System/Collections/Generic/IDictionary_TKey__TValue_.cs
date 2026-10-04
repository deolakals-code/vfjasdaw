// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
public interface IDictionary<TKey, TValue> : ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 10934
{
	// Properties
	public abstract TValue Item { get; set; }
	public abstract ICollection<TKey> Keys { get; }
	public abstract ICollection<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ICollection<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Add(TKey key, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool Remove(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/
}
