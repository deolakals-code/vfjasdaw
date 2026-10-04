// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
[DefaultMember("Item")]
internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 15741
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1EC58 Offset: 0x2A1AC58 VA: 0x2A1EC58
	|-HybridReferenceDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x2A1F1D0 Offset: 0x2A1B1D0 VA: 0x2A1F1D0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1ECE8 Offset: 0x2A1ACE8 VA: 0x2A1ECE8
	|-HybridReferenceDictionary<object, object>.Remove
	|
	|-RVA: 0x2A1F3A0 Offset: 0x2A1B3A0 VA: 0x2A1F3A0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1ED60 Offset: 0x2A1AD60 VA: 0x2A1ED60
	|-HybridReferenceDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x2A1F4B0 Offset: 0x2A1B4B0 VA: 0x2A1F4B0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1EDDC Offset: 0x2A1ADDC VA: 0x2A1EDDC
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x2A1F59C Offset: 0x2A1B59C VA: 0x2A1F59C
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue>))]
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1EE5C Offset: 0x2A1AE5C VA: 0x2A1EE5C
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	|
	|-RVA: 0x2A1F654 Offset: 0x2A1B654 VA: 0x2A1F654
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1EED4 Offset: 0x2A1AED4 VA: 0x2A1EED4
	|-HybridReferenceDictionary<object, object>.get_Item
	|
	|-RVA: 0x2A1F6E0 Offset: 0x2A1B6E0 VA: 0x2A1F6E0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1EF7C Offset: 0x2A1AF7C VA: 0x2A1EF7C
	|-HybridReferenceDictionary<object, object>.set_Item
	|
	|-RVA: 0x2A1F834 Offset: 0x2A1B834 VA: 0x2A1F834
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A1F1C8 Offset: 0x2A1B1C8 VA: 0x2A1F1C8
	|-HybridReferenceDictionary<object, object>..ctor
	|
	|-RVA: 0x2A1FDF4 Offset: 0x2A1BDF4 VA: 0x2A1FDF4
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>..ctor
	*/
}
