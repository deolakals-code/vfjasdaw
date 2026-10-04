// Assembly: System.Data.dll
// Namespace: 
internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 14760
{
	// Fields
	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Properties
	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF11C8 Offset: 0x2BED1C8 VA: 0x2BF11C8
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x2BF141C Offset: 0x2BED41C VA: 0x2BF141C
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x2BF1640 Offset: 0x2BED640 VA: 0x2BF1640
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF1204 Offset: 0x2BED204 VA: 0x2BF1204
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x2BF145C Offset: 0x2BED45C VA: 0x2BF145C
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x2BF178C Offset: 0x2BED78C VA: 0x2BF178C
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF12A8 Offset: 0x2BED2A8 VA: 0x2BF12A8
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|
	|-RVA: 0x2BF1500 Offset: 0x2BED500 VA: 0x2BF1500
	|-RBTree.RBTreeEnumerator<object>.Dispose
	|
	|-RVA: 0x2BF1A00 Offset: 0x2BEDA00 VA: 0x2BF1A00
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF12AC Offset: 0x2BED2AC VA: 0x2BF12AC
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x2BF1504 Offset: 0x2BED504 VA: 0x2BF1504
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	|
	|-RVA: 0x2BF1A04 Offset: 0x2BEDA04 VA: 0x2BF1A04
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF1364 Offset: 0x2BED364 VA: 0x2BF1364
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0x2BF15C4 Offset: 0x2BED5C4 VA: 0x2BF15C4
	|-RBTree.RBTreeEnumerator<object>.get_Current
	|
	|-RVA: 0x2BF1D38 Offset: 0x2BEDD38 VA: 0x2BF1D38
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF136C Offset: 0x2BED36C VA: 0x2BF136C
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF15CC Offset: 0x2BED5CC VA: 0x2BF15CC
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2BF1E28 Offset: 0x2BEDE28 VA: 0x2BF1E28
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF13D4 Offset: 0x2BED3D4 VA: 0x2BF13D4
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF15F4 Offset: 0x2BED5F4 VA: 0x2BF15F4
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2BF1F4C Offset: 0x2BEDF4C VA: 0x2BF1F4C
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
