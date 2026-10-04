// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
internal class LowLevelDictionary<TKey, TValue> // TypeDefIndex: 10956
{
	// Fields
	private LowLevelDictionary.Entry<TKey, TValue>[] _buckets; // 0x0
	private int _numEntries; // 0x0
	private int _version; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0

	// Properties
	public TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0964 Offset: 0x2B9C964 VA: 0x2BA0964
	|-LowLevelDictionary<int, object>..ctor
	|
	|-RVA: 0x2BA1168 Offset: 0x2B9D168 VA: 0x2BA1168
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA09D4 Offset: 0x2B9C9D4 VA: 0x2BA09D4
	|-LowLevelDictionary<int, object>..ctor
	|
	|-RVA: 0x2BA11E0 Offset: 0x2B9D1E0 VA: 0x2BA11E0
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0A2C Offset: 0x2B9CA2C VA: 0x2BA0A2C
	|-LowLevelDictionary<int, object>.set_Item
	|
	|-RVA: 0x2BA123C Offset: 0x2B9D23C VA: 0x2BA123C
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void Clear(int capacity = 17) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0AA8 Offset: 0x2B9CAA8 VA: 0x2BA0AA8
	|-LowLevelDictionary<int, object>.Clear
	|
	|-RVA: 0x2BA14A8 Offset: 0x2B9D4A8 VA: 0x2BA14A8
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0B04 Offset: 0x2B9CB04 VA: 0x2BA0B04
	|-LowLevelDictionary<int, object>.Remove
	|
	|-RVA: 0x2BA1504 Offset: 0x2B9D504 VA: 0x2BA1504
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private LowLevelDictionary.Entry<TKey, TValue> Find(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0C74 Offset: 0x2B9CC74 VA: 0x2BA0C74
	|-LowLevelDictionary<int, object>.Find
	|
	|-RVA: 0x2BA1894 Offset: 0x2B9D894 VA: 0x2BA1894
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private LowLevelDictionary.Entry<TKey, TValue> UncheckedAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0D78 Offset: 0x2B9CD78 VA: 0x2BA0D78
	|-LowLevelDictionary<int, object>.UncheckedAdd
	|
	|-RVA: 0x2BA1AF0 Offset: 0x2B9DAF0 VA: 0x2BA1AF0
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.UncheckedAdd
	*/

	// RVA: -1 Offset: -1
	private void ExpandBuckets() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA0EA8 Offset: 0x2B9CEA8 VA: 0x2BA0EA8
	|-LowLevelDictionary<int, object>.ExpandBuckets
	|
	|-RVA: 0x2BA1D80 Offset: 0x2B9DD80 VA: 0x2BA1D80
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ExpandBuckets
	*/

	// RVA: -1 Offset: -1
	private int GetBucket(TKey key, int numBuckets = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA109C Offset: 0x2B9D09C VA: 0x2BA109C
	|-LowLevelDictionary<int, object>.GetBucket
	|
	|-RVA: 0x2BA2044 Offset: 0x2B9E044 VA: 0x2BA2044
	|-LowLevelDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/
}
