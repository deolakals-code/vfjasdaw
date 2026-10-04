// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 14761
{
	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF20DC Offset: 0x2BEE0DC VA: 0x2BF20DC
	|-RBTree<int>..ctor
	|
	|-RVA: 0x2BF58D8 Offset: 0x2BF18D8 VA: 0x2BF58D8
	|-RBTree<object>..ctor
	|
	|-RVA: 0x2BF918C Offset: 0x2BF518C VA: 0x2BF918C
	|-RBTree<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2118 Offset: 0x2BEE118 VA: 0x2BF2118
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x2BF5914 Offset: 0x2BF1914 VA: 0x2BF5914
	|-RBTree<object>.InitTree
	|
	|-RVA: 0x2BF91CC Offset: 0x2BF51CC VA: 0x2BF91CC
	|-RBTree<__Il2CppFullySharedGenericType>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2248 Offset: 0x2BEE248 VA: 0x2BF2248
	|-RBTree<int>.FreePage
	|
	|-RVA: 0x2BF5A44 Offset: 0x2BF1A44 VA: 0x2BF5A44
	|-RBTree<object>.FreePage
	|
	|-RVA: 0x2BF9344 Offset: 0x2BF5344 VA: 0x2BF9344
	|-RBTree<__Il2CppFullySharedGenericType>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF22B4 Offset: 0x2BEE2B4 VA: 0x2BF22B4
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x2BF5AB0 Offset: 0x2BF1AB0 VA: 0x2BF5AB0
	|-RBTree<object>.AllocPage
	|
	|-RVA: 0x2BF93CC Offset: 0x2BF53CC VA: 0x2BF93CC
	|-RBTree<__Il2CppFullySharedGenericType>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF251C Offset: 0x2BEE51C VA: 0x2BF251C
	|-RBTree<int>.MarkPageFull
	|
	|-RVA: 0x2BF5D18 Offset: 0x2BF1D18 VA: 0x2BF5D18
	|-RBTree<object>.MarkPageFull
	|
	|-RVA: 0x2BF9678 Offset: 0x2BF5678 VA: 0x2BF9678
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2574 Offset: 0x2BEE574 VA: 0x2BF2574
	|-RBTree<int>.MarkPageFree
	|
	|-RVA: 0x2BF5D70 Offset: 0x2BF1D70 VA: 0x2BF5D70
	|-RBTree<object>.MarkPageFree
	|
	|-RVA: 0x2BF970C Offset: 0x2BF570C VA: 0x2BF970C
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF25CC Offset: 0x2BEE5CC VA: 0x2BF25CC
	|-RBTree<int>.GetIntValueFromBitMap
	|
	|-RVA: 0x2BF5DC8 Offset: 0x2BF1DC8 VA: 0x2BF5DC8
	|-RBTree<object>.GetIntValueFromBitMap
	|
	|-RVA: 0x2BF97A0 Offset: 0x2BF57A0 VA: 0x2BF97A0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2630 Offset: 0x2BEE630 VA: 0x2BF2630
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x2BF5E2C Offset: 0x2BF1E2C VA: 0x2BF5E2C
	|-RBTree<object>.FreeNode
	|
	|-RVA: 0x2BF9804 Offset: 0x2BF5804 VA: 0x2BF9804
	|-RBTree<__Il2CppFullySharedGenericType>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2714 Offset: 0x2BEE714 VA: 0x2BF2714
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x2BF5F14 Offset: 0x2BF1F14 VA: 0x2BF5F14
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x2BF9988 Offset: 0x2BF5988 VA: 0x2BF9988
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2844 Offset: 0x2BEE844 VA: 0x2BF2844
	|-RBTree<int>.get_Count
	|
	|-RVA: 0x2BF6044 Offset: 0x2BF2044 VA: 0x2BF6044
	|-RBTree<object>.get_Count
	|
	|-RVA: 0x2BF9AC8 Offset: 0x2BF5AC8 VA: 0x2BF9AC8
	|-RBTree<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2850 Offset: 0x2BEE850 VA: 0x2BF2850
	|-RBTree<int>.get_HasDuplicates
	|
	|-RVA: 0x2BF6050 Offset: 0x2BF2050 VA: 0x2BF6050
	|-RBTree<object>.get_HasDuplicates
	|
	|-RVA: 0x2BF9AD4 Offset: 0x2BF5AD4 VA: 0x2BF9AD4
	|-RBTree<__Il2CppFullySharedGenericType>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2860 Offset: 0x2BEE860 VA: 0x2BF2860
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x2BF6060 Offset: 0x2BF2060 VA: 0x2BF6060
	|-RBTree<object>.GetNewNode
	|
	|-RVA: 0x2BF9AE4 Offset: 0x2BF5AE4 VA: 0x2BF9AE4
	|-RBTree<__Il2CppFullySharedGenericType>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF29C0 Offset: 0x2BEE9C0 VA: 0x2BF29C0
	|-RBTree<int>.Successor
	|
	|-RVA: 0x2BF61F4 Offset: 0x2BF21F4 VA: 0x2BF61F4
	|-RBTree<object>.Successor
	|
	|-RVA: 0x2BF9DE4 Offset: 0x2BF5DE4 VA: 0x2BF9DE4
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2A54 Offset: 0x2BEEA54 VA: 0x2BF2A54
	|-RBTree<int>.Successor
	|
	|-RVA: 0x2BF6288 Offset: 0x2BF2288 VA: 0x2BF6288
	|-RBTree<object>.Successor
	|
	|-RVA: 0x2BF9ED0 Offset: 0x2BF5ED0 VA: 0x2BF9ED0
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2B54 Offset: 0x2BEEB54 VA: 0x2BF2B54
	|-RBTree<int>.Minimum
	|
	|-RVA: 0x2BF6388 Offset: 0x2BF2388 VA: 0x2BF6388
	|-RBTree<object>.Minimum
	|
	|-RVA: 0x2BF9FF4 Offset: 0x2BF5FF4 VA: 0x2BF9FF4
	|-RBTree<__Il2CppFullySharedGenericType>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2B98 Offset: 0x2BEEB98 VA: 0x2BF2B98
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x2BF63CC Offset: 0x2BF23CC VA: 0x2BF63CC
	|-RBTree<object>.LeftRotate
	|
	|-RVA: 0x2BFA06C Offset: 0x2BF606C VA: 0x2BFA06C
	|-RBTree<__Il2CppFullySharedGenericType>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF2E08 Offset: 0x2BEEE08 VA: 0x2BF2E08
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x2BF663C Offset: 0x2BF263C VA: 0x2BF663C
	|-RBTree<object>.RightRotate
	|
	|-RVA: 0x2BFA57C Offset: 0x2BF657C VA: 0x2BFA57C
	|-RBTree<__Il2CppFullySharedGenericType>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF3078 Offset: 0x2BEF078 VA: 0x2BF3078
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x2BF68AC Offset: 0x2BF28AC VA: 0x2BF68AC
	|-RBTree<object>.RBInsert
	|
	|-RVA: 0x2BFAA90 Offset: 0x2BF6A90 VA: 0x2BFAA90
	|-RBTree<__Il2CppFullySharedGenericType>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF38B4 Offset: 0x2BEF8B4 VA: 0x2BF38B4
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x2BF70E8 Offset: 0x2BF30E8 VA: 0x2BF70E8
	|-RBTree<object>.UpdateNodeKey
	|
	|-RVA: 0x2BFBA84 Offset: 0x2BF7A84 VA: 0x2BFBA84
	|-RBTree<__Il2CppFullySharedGenericType>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF391C Offset: 0x2BEF91C VA: 0x2BF391C
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x2BF7150 Offset: 0x2BF3150 VA: 0x2BF7150
	|-RBTree<object>.DeleteByIndex
	|
	|-RVA: 0x2BFBC64 Offset: 0x2BF7C64 VA: 0x2BFBC64
	|-RBTree<__Il2CppFullySharedGenericType>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF398C Offset: 0x2BEF98C VA: 0x2BF398C
	|-RBTree<int>.RBDelete
	|
	|-RVA: 0x2BF71C0 Offset: 0x2BF31C0 VA: 0x2BF71C0
	|-RBTree<object>.RBDelete
	|
	|-RVA: 0x2BFBD64 Offset: 0x2BF7D64 VA: 0x2BFBD64
	|-RBTree<__Il2CppFullySharedGenericType>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF39AC Offset: 0x2BEF9AC VA: 0x2BF39AC
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x2BF71E0 Offset: 0x2BF31E0 VA: 0x2BF71E0
	|-RBTree<object>.RBDeleteX
	|
	|-RVA: 0x2BFBD88 Offset: 0x2BF7D88 VA: 0x2BFBD88
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF40BC Offset: 0x2BF00BC VA: 0x2BF40BC
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x2BF78F0 Offset: 0x2BF38F0 VA: 0x2BF78F0
	|-RBTree<object>.RBDeleteFixup
	|
	|-RVA: 0x2BFCAA4 Offset: 0x2BF8AA4 VA: 0x2BFCAA4
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4588 Offset: 0x2BF0588 VA: 0x2BF4588
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x2BF7DBC Offset: 0x2BF3DBC VA: 0x2BF7DBC
	|-RBTree<object>.SearchSubTree
	|
	|-RVA: 0x2BFD318 Offset: 0x2BF9318 VA: 0x2BFD318
	|-RBTree<__Il2CppFullySharedGenericType>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4644 Offset: 0x2BF0644 VA: 0x2BF4644
	|-RBTree<int>.get_Item
	|
	|-RVA: 0x2BF7E78 Offset: 0x2BF3E78 VA: 0x2BF7E78
	|-RBTree<object>.get_Item
	|
	|-RVA: 0x2BFD4EC Offset: 0x2BF94EC VA: 0x2BFD4EC
	|-RBTree<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF466C Offset: 0x2BF066C VA: 0x2BF466C
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x2BF7EA0 Offset: 0x2BF3EA0 VA: 0x2BF7EA0
	|-RBTree<object>.GetNodeByKey
	|
	|-RVA: 0x2BFD5BC Offset: 0x2BF95BC VA: 0x2BFD5BC
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4770 Offset: 0x2BF0770 VA: 0x2BF4770
	|-RBTree<int>.GetIndexByKey
	|
	|-RVA: 0x2BF7F84 Offset: 0x2BF3F84 VA: 0x2BF7F84
	|-RBTree<object>.GetIndexByKey
	|
	|-RVA: 0x2BFD8C4 Offset: 0x2BF98C4 VA: 0x2BFD8C4
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF47C4 Offset: 0x2BF07C4 VA: 0x2BF47C4
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x2BF7FD8 Offset: 0x2BF3FD8 VA: 0x2BF7FD8
	|-RBTree<object>.GetIndexByNode
	|
	|-RVA: 0x2BFD9B8 Offset: 0x2BF99B8 VA: 0x2BFD9B8
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF48A8 Offset: 0x2BF08A8 VA: 0x2BF48A8
	|-RBTree<int>.GetIndexByNodePath
	|
	|-RVA: 0x2BF80BC Offset: 0x2BF40BC VA: 0x2BF80BC
	|-RBTree<object>.GetIndexByNodePath
	|
	|-RVA: 0x2BFDB2C Offset: 0x2BF9B2C VA: 0x2BFDB2C
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4940 Offset: 0x2BF0940 VA: 0x2BF4940
	|-RBTree<int>.ComputeIndexByNode
	|
	|-RVA: 0x2BF8154 Offset: 0x2BF4154 VA: 0x2BF8154
	|-RBTree<object>.ComputeIndexByNode
	|
	|-RVA: 0x2BFDBBC Offset: 0x2BF9BBC VA: 0x2BFDBBC
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF49CC Offset: 0x2BF09CC VA: 0x2BF49CC
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x2BF81E0 Offset: 0x2BF41E0 VA: 0x2BF81E0
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x2BFDCAC Offset: 0x2BF9CAC VA: 0x2BFDCAC
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4A8C Offset: 0x2BF0A8C VA: 0x2BF4A8C
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x2BF82A0 Offset: 0x2BF42A0 VA: 0x2BF82A0
	|-RBTree<object>.GetNodeByIndex
	|
	|-RVA: 0x2BFDE00 Offset: 0x2BF9E00 VA: 0x2BFDE00
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4B5C Offset: 0x2BF0B5C VA: 0x2BF4B5C
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x2BF8370 Offset: 0x2BF4370 VA: 0x2BF8370
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x2BFDED8 Offset: 0x2BF9ED8 VA: 0x2BFDED8
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4CA8 Offset: 0x2BF0CA8 VA: 0x2BF4CA8
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x2BF84BC Offset: 0x2BF44BC VA: 0x2BF84BC
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x2BFE0D4 Offset: 0x2BFA0D4 VA: 0x2BFE0D4
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4D20 Offset: 0x2BF0D20 VA: 0x2BF4D20
	|-RBTree<int>.Insert
	|
	|-RVA: 0x2BF8534 Offset: 0x2BF4534 VA: 0x2BF8534
	|-RBTree<object>.Insert
	|
	|-RVA: 0x2BFE188 Offset: 0x2BFA188 VA: 0x2BFE188
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4D7C Offset: 0x2BF0D7C VA: 0x2BF4D7C
	|-RBTree<int>.Add
	|
	|-RVA: 0x2BF8590 Offset: 0x2BF4590 VA: 0x2BF8590
	|-RBTree<object>.Add
	|
	|-RVA: 0x2BFE288 Offset: 0x2BFA288 VA: 0x2BFE288
	|-RBTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4DD8 Offset: 0x2BF0DD8 VA: 0x2BF4DD8
	|-RBTree<int>.GetEnumerator
	|
	|-RVA: 0x2BF85EC Offset: 0x2BF45EC VA: 0x2BF85EC
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x2BFE388 Offset: 0x2BFA388 VA: 0x2BFE388
	|-RBTree<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4E28 Offset: 0x2BF0E28 VA: 0x2BF4E28
	|-RBTree<int>.IndexOf
	|
	|-RVA: 0x2BF8634 Offset: 0x2BF4634 VA: 0x2BF8634
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x2BFE438 Offset: 0x2BFA438 VA: 0x2BFE438
	|-RBTree<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4F20 Offset: 0x2BF0F20 VA: 0x2BF4F20
	|-RBTree<int>.Insert
	|
	|-RVA: 0x2BF86F0 Offset: 0x2BF46F0 VA: 0x2BF86F0
	|-RBTree<object>.Insert
	|
	|-RVA: 0x2BFE6A4 Offset: 0x2BFA6A4 VA: 0x2BFE6A4
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4F34 Offset: 0x2BF0F34 VA: 0x2BF4F34
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x2BF8704 Offset: 0x2BF4704 VA: 0x2BF8704
	|-RBTree<object>.InsertAt
	|
	|-RVA: 0x2BFE78C Offset: 0x2BFA78C VA: 0x2BFE78C
	|-RBTree<__Il2CppFullySharedGenericType>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4FA8 Offset: 0x2BF0FA8 VA: 0x2BF4FA8
	|-RBTree<int>.RemoveAt
	|
	|-RVA: 0x2BF8778 Offset: 0x2BF4778 VA: 0x2BF8778
	|-RBTree<object>.RemoveAt
	|
	|-RVA: 0x2BFE8A0 Offset: 0x2BFA8A0 VA: 0x2BFE8A0
	|-RBTree<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4FB8 Offset: 0x2BF0FB8 VA: 0x2BF4FB8
	|-RBTree<int>.Clear
	|
	|-RVA: 0x2BF8788 Offset: 0x2BF4788 VA: 0x2BF8788
	|-RBTree<object>.Clear
	|
	|-RVA: 0x2BFE92C Offset: 0x2BFA92C VA: 0x2BFE92C
	|-RBTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF4FE4 Offset: 0x2BF0FE4 VA: 0x2BF4FE4
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x2BF87B4 Offset: 0x2BF47B4 VA: 0x2BF87B4
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x2BFE95C Offset: 0x2BFA95C VA: 0x2BFE95C
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF510C Offset: 0x2BF110C VA: 0x2BF510C
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x2BF88C4 Offset: 0x2BF48C4 VA: 0x2BF88C4
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x2BFEB28 Offset: 0x2BFAB28 VA: 0x2BFEB28
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF522C Offset: 0x2BF122C VA: 0x2BF522C
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x2BF89EC Offset: 0x2BF49EC VA: 0x2BF89EC
	|-RBTree<object>.SetRight
	|
	|-RVA: 0x2BFED50 Offset: 0x2BFAD50 VA: 0x2BFED50
	|-RBTree<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5288 Offset: 0x2BF1288 VA: 0x2BF5288
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x2BF8A48 Offset: 0x2BF4A48 VA: 0x2BF8A48
	|-RBTree<object>.SetLeft
	|
	|-RVA: 0x2BFEDCC Offset: 0x2BFADCC VA: 0x2BFEDCC
	|-RBTree<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF52E4 Offset: 0x2BF12E4 VA: 0x2BF52E4
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x2BF8AA4 Offset: 0x2BF4AA4 VA: 0x2BF8AA4
	|-RBTree<object>.SetParent
	|
	|-RVA: 0x2BFEE48 Offset: 0x2BFAE48 VA: 0x2BFEE48
	|-RBTree<__Il2CppFullySharedGenericType>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5340 Offset: 0x2BF1340 VA: 0x2BF5340
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x2BF8B00 Offset: 0x2BF4B00 VA: 0x2BF8B00
	|-RBTree<object>.SetColor
	|
	|-RVA: 0x2BFEEC4 Offset: 0x2BFAEC4 VA: 0x2BFEEC4
	|-RBTree<__Il2CppFullySharedGenericType>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF539C Offset: 0x2BF139C VA: 0x2BF539C
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x2BF8B5C Offset: 0x2BF4B5C VA: 0x2BF8B5C
	|-RBTree<object>.SetKey
	|
	|-RVA: 0x2BFEF40 Offset: 0x2BFAF40 VA: 0x2BFEF40
	|-RBTree<__Il2CppFullySharedGenericType>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF53F8 Offset: 0x2BF13F8 VA: 0x2BF53F8
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x2BF8BBC Offset: 0x2BF4BBC VA: 0x2BF8BBC
	|-RBTree<object>.SetNext
	|
	|-RVA: 0x2BFF050 Offset: 0x2BFB050 VA: 0x2BFF050
	|-RBTree<__Il2CppFullySharedGenericType>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5454 Offset: 0x2BF1454 VA: 0x2BF5454
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x2BF8C18 Offset: 0x2BF4C18 VA: 0x2BF8C18
	|-RBTree<object>.SetSubTreeSize
	|
	|-RVA: 0x2BFF0CC Offset: 0x2BFB0CC VA: 0x2BFF0CC
	|-RBTree<__Il2CppFullySharedGenericType>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF54B0 Offset: 0x2BF14B0 VA: 0x2BF54B0
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x2BF8C74 Offset: 0x2BF4C74 VA: 0x2BF8C74
	|-RBTree<object>.IncreaseSize
	|
	|-RVA: 0x2BFF148 Offset: 0x2BFB148 VA: 0x2BFF148
	|-RBTree<__Il2CppFullySharedGenericType>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5514 Offset: 0x2BF1514 VA: 0x2BF5514
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x2BF8CD8 Offset: 0x2BF4CD8 VA: 0x2BF8CD8
	|-RBTree<object>.RecomputeSize
	|
	|-RVA: 0x2BFF1D4 Offset: 0x2BFB1D4 VA: 0x2BFF1D4
	|-RBTree<__Il2CppFullySharedGenericType>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF55F0 Offset: 0x2BF15F0 VA: 0x2BF55F0
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x2BF8DB4 Offset: 0x2BF4DB4 VA: 0x2BF8DB4
	|-RBTree<object>.DecreaseSize
	|
	|-RVA: 0x2BFF344 Offset: 0x2BFB344 VA: 0x2BFF344
	|-RBTree<__Il2CppFullySharedGenericType>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5654 Offset: 0x2BF1654 VA: 0x2BF5654
	|-RBTree<int>.Right
	|
	|-RVA: 0x2BF8E18 Offset: 0x2BF4E18 VA: 0x2BF8E18
	|-RBTree<object>.Right
	|
	|-RVA: 0x2BFF3D0 Offset: 0x2BFB3D0 VA: 0x2BFF3D0
	|-RBTree<__Il2CppFullySharedGenericType>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF56B0 Offset: 0x2BF16B0 VA: 0x2BF56B0
	|-RBTree<int>.Left
	|
	|-RVA: 0x2BF8E74 Offset: 0x2BF4E74 VA: 0x2BF8E74
	|-RBTree<object>.Left
	|
	|-RVA: 0x2BFF454 Offset: 0x2BFB454 VA: 0x2BFF454
	|-RBTree<__Il2CppFullySharedGenericType>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF570C Offset: 0x2BF170C VA: 0x2BF570C
	|-RBTree<int>.Parent
	|
	|-RVA: 0x2BF8ED0 Offset: 0x2BF4ED0 VA: 0x2BF8ED0
	|-RBTree<object>.Parent
	|
	|-RVA: 0x2BFF4D8 Offset: 0x2BFB4D8 VA: 0x2BFF4D8
	|-RBTree<__Il2CppFullySharedGenericType>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5768 Offset: 0x2BF1768 VA: 0x2BF5768
	|-RBTree<int>.color
	|
	|-RVA: 0x2BF8F2C Offset: 0x2BF4F2C VA: 0x2BF8F2C
	|-RBTree<object>.color
	|
	|-RVA: 0x2BFF55C Offset: 0x2BFB55C VA: 0x2BFF55C
	|-RBTree<__Il2CppFullySharedGenericType>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF57C4 Offset: 0x2BF17C4 VA: 0x2BF57C4
	|-RBTree<int>.Next
	|
	|-RVA: 0x2BF8F88 Offset: 0x2BF4F88 VA: 0x2BF8F88
	|-RBTree<object>.Next
	|
	|-RVA: 0x2BFF5E0 Offset: 0x2BFB5E0 VA: 0x2BFF5E0
	|-RBTree<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF5820 Offset: 0x2BF1820 VA: 0x2BF5820
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x2BF8FE4 Offset: 0x2BF4FE4 VA: 0x2BF8FE4
	|-RBTree<object>.SubTreeSize
	|
	|-RVA: 0x2BFF664 Offset: 0x2BFB664 VA: 0x2BFF664
	|-RBTree<__Il2CppFullySharedGenericType>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF587C Offset: 0x2BF187C VA: 0x2BF587C
	|-RBTree<int>.Key
	|
	|-RVA: 0x2BF9040 Offset: 0x2BF5040 VA: 0x2BF9040
	|-RBTree<object>.Key
	|
	|-RVA: 0x2BFF6E8 Offset: 0x2BFB6E8 VA: 0x2BFF6E8
	|-RBTree<__Il2CppFullySharedGenericType>.Key
	*/
}
