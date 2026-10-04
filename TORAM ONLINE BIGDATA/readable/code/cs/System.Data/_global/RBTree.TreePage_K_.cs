// Assembly: System.Data.dll
// Namespace: 
private sealed class RBTree.TreePage<K> // TypeDefIndex: 14759
{
	// Fields
	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	// Properties
	internal int InUseCount { get; set; }
	internal int PageId { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBBF0 Offset: 0x2CB7BF0 VA: 0x2CBBBF0
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x2CBBE14 Offset: 0x2CB7E14 VA: 0x2CBBE14
	|-RBTree.TreePage<object>..ctor
	|
	|-RVA: 0x2CBC038 Offset: 0x2CB8038 VA: 0x2CBC038
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBCC0 Offset: 0x2CB7CC0 VA: 0x2CBBCC0
	|-RBTree.TreePage<int>.AllocSlot
	|
	|-RVA: 0x2CBBEE4 Offset: 0x2CB7EE4 VA: 0x2CBBEE4
	|-RBTree.TreePage<object>.AllocSlot
	|
	|-RVA: 0x2CBC108 Offset: 0x2CB8108 VA: 0x2CBC108
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.AllocSlot
	*/

	// RVA: -1 Offset: -1
	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBDF4 Offset: 0x2CB7DF4 VA: 0x2CBBDF4
	|-RBTree.TreePage<int>.get_InUseCount
	|
	|-RVA: 0x2CBC018 Offset: 0x2CB8018 VA: 0x2CBC018
	|-RBTree.TreePage<object>.get_InUseCount
	|
	|-RVA: 0x2CBC25C Offset: 0x2CB825C VA: 0x2CBC25C
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBDFC Offset: 0x2CB7DFC VA: 0x2CBBDFC
	|-RBTree.TreePage<int>.set_InUseCount
	|
	|-RVA: 0x2CBC020 Offset: 0x2CB8020 VA: 0x2CBC020
	|-RBTree.TreePage<object>.set_InUseCount
	|
	|-RVA: 0x2CBC264 Offset: 0x2CB8264 VA: 0x2CBC264
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBE04 Offset: 0x2CB7E04 VA: 0x2CBBE04
	|-RBTree.TreePage<int>.get_PageId
	|
	|-RVA: 0x2CBC028 Offset: 0x2CB8028 VA: 0x2CBC028
	|-RBTree.TreePage<object>.get_PageId
	|
	|-RVA: 0x2CBC26C Offset: 0x2CB826C VA: 0x2CBC26C
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_PageId
	*/

	// RVA: -1 Offset: -1
	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CBBE0C Offset: 0x2CB7E0C VA: 0x2CBBE0C
	|-RBTree.TreePage<int>.set_PageId
	|
	|-RVA: 0x2CBC030 Offset: 0x2CB8030 VA: 0x2CBC030
	|-RBTree.TreePage<object>.set_PageId
	|
	|-RVA: 0x2CBC274 Offset: 0x2CB8274 VA: 0x2CBC274
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_PageId
	*/
}
