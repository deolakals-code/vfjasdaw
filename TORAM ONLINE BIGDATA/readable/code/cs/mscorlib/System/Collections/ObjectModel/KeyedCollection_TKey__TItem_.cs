// Assembly: mscorlib.dll
// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Serializable]
public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> // TypeDefIndex: 10917
{
	// Fields
	private readonly IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary<TKey, TItem> dict; // 0x0
	private int keyCount; // 0x0
	private readonly int threshold; // 0x0

	// Properties
	private List<TItem> Items { get; }
	public TItem Item { get; }
	protected IDictionary<TKey, TItem> Dictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2678 Offset: 0x2A9E678 VA: 0x2AA2678
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x2AA3388 Offset: 0x2A9F388 VA: 0x2AA3388
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2690 Offset: 0x2A9E690 VA: 0x2AA2690
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x2AA33A4 Offset: 0x2A9F3A4 VA: 0x2AA33A4
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA26A4 Offset: 0x2A9E6A4 VA: 0x2AA26A4
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x2AA33BC Offset: 0x2A9F3BC VA: 0x2AA33BC
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private List<TItem> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA27B4 Offset: 0x2A9E7B4 VA: 0x2AA27B4
	|-KeyedCollection<object, object>.get_Items
	|
	|-RVA: 0x2AA34D8 Offset: 0x2A9F4D8 VA: 0x2AA34D8
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public TItem get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2824 Offset: 0x2A9E824 VA: 0x2AA2824
	|-KeyedCollection<object, object>.get_Item
	|
	|-RVA: 0x2AA3560 Offset: 0x2A9F560 VA: 0x2AA3560
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA28CC Offset: 0x2A9E8CC VA: 0x2AA28CC
	|-KeyedCollection<object, object>.Contains
	|
	|-RVA: 0x2AA3770 Offset: 0x2A9F770 VA: 0x2AA3770
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2B04 Offset: 0x2A9EB04 VA: 0x2AA2B04
	|-KeyedCollection<object, object>.TryGetValue
	|
	|-RVA: 0x2AA3C8C Offset: 0x2A9FC8C VA: 0x2AA3C8C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	protected IDictionary<TKey, TItem> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2D84 Offset: 0x2A9ED84 VA: 0x2AA2D84
	|-KeyedCollection<object, object>.get_Dictionary
	|
	|-RVA: 0x2AA429C Offset: 0x2AA029C VA: 0x2AA429C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2D8C Offset: 0x2A9ED8C VA: 0x2AA2D8C
	|-KeyedCollection<object, object>.ClearItems
	|
	|-RVA: 0x2AA42A4 Offset: 0x2AA02A4 VA: 0x2AA42A4
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract TKey GetKeyForItem(TItem item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyForItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2DDC Offset: 0x2A9EDDC VA: 0x2AA2DDC
	|-KeyedCollection<object, object>.InsertItem
	|
	|-RVA: 0x2AA42FC Offset: 0x2AA02FC VA: 0x2AA42FC
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2E54 Offset: 0x2A9EE54 VA: 0x2AA2E54
	|-KeyedCollection<object, object>.RemoveItem
	|
	|-RVA: 0x2AA4560 Offset: 0x2AA0560 VA: 0x2AA4560
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA2F08 Offset: 0x2A9EF08 VA: 0x2AA2F08
	|-KeyedCollection<object, object>.SetItem
	|
	|-RVA: 0x2AA4750 Offset: 0x2AA0750 VA: 0x2AA4750
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	private void AddKey(TKey key, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA30C8 Offset: 0x2A9F0C8 VA: 0x2AA30C8
	|-KeyedCollection<object, object>.AddKey
	|
	|-RVA: 0x2AA4C98 Offset: 0x2AA0C98 VA: 0x2AA4C98
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddKey
	*/

	// RVA: -1 Offset: -1
	private void CreateDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA31B4 Offset: 0x2A9F1B4 VA: 0x2AA31B4
	|-KeyedCollection<object, object>.CreateDictionary
	|
	|-RVA: 0x2AA4F84 Offset: 0x2AA0F84 VA: 0x2AA4F84
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDictionary
	*/

	// RVA: -1 Offset: -1
	private void RemoveKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA335C Offset: 0x2A9F35C VA: 0x2AA335C
	|-KeyedCollection<object, object>.RemoveKey
	|
	|-RVA: 0x2AA53DC Offset: 0x2AA13DC VA: 0x2AA53DC
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveKey
	*/
}
