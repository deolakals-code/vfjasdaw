// Assembly: System.Core.dll
// Namespace: System.Dynamic.Utils
[DefaultMember("Item")]
internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 15793
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C739F8 Offset: 0x2C6F9F8 VA: 0x2C739F8
	|-CacheDict<object, object>..ctor
	|
	|-RVA: 0x2C73C84 Offset: 0x2C6FC84 VA: 0x2C73C84
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C73A68 Offset: 0x2C6FA68 VA: 0x2C73A68
	|-CacheDict<object, object>.AlignSize
	|
	|-RVA: 0x2C73CFC Offset: 0x2C6FCFC VA: 0x2C73CFC
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C73A88 Offset: 0x2C6FA88 VA: 0x2C73A88
	|-CacheDict<object, object>.TryGetValue
	|
	|-RVA: 0x2C73D1C Offset: 0x2C6FD1C VA: 0x2C73D1C
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C73B44 Offset: 0x2C6FB44 VA: 0x2C73B44
	|-CacheDict<object, object>.Add
	|
	|-RVA: 0x2C74098 Offset: 0x2C70098 VA: 0x2C74098
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C73C74 Offset: 0x2C6FC74 VA: 0x2C73C74
	|-CacheDict<object, object>.set_Item
	|
	|-RVA: 0x2C74490 Offset: 0x2C70490 VA: 0x2C74490
	|-CacheDict<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/
}
