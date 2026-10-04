// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 10943
{
	// Properties
	public abstract TValue Item { get; }
	public abstract IEnumerable<TKey> Keys { get; }
	public abstract IEnumerable<TValue> Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ContainsKey(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool TryGetValue(TKey key, out TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TValue get_Item(TKey key);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<TKey> get_Keys();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IEnumerable<TValue> get_Values();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/
}
