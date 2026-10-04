// Assembly: mscorlib.dll
// Namespace: 
private struct Array.SorterGenericArray // TypeDefIndex: 9727
{
	// Fields
	private Array keys; // 0x0
	private Array items; // 0x8
	private IComparer comparer; // 0x10

	// Methods

	// RVA: 0x300C748 Offset: 0x3008748 VA: 0x300C748
	internal void .ctor(Array keys, Array items, IComparer comparer) { }

	// RVA: 0x300C7E8 Offset: 0x30087E8 VA: 0x300C7E8
	internal void SwapIfGreaterWithItems(int a, int b) { }

	// RVA: 0x300C9B8 Offset: 0x30089B8 VA: 0x300C9B8
	private void Swap(int i, int j) { }

	// RVA: 0x300CAA4 Offset: 0x3008AA4 VA: 0x300CAA4
	internal void Sort(int left, int length) { }

	// RVA: 0x300CAA8 Offset: 0x3008AA8 VA: 0x300CAA8
	private void IntrospectiveSort(int left, int length) { }

	// RVA: 0x300CBFC Offset: 0x3008BFC VA: 0x300CBFC
	private void IntroSort(int lo, int hi, int depthLimit) { }

	// RVA: 0x300CF98 Offset: 0x3008F98 VA: 0x300CF98
	private int PickPivotAndPartition(int lo, int hi) { }

	// RVA: 0x300CEF8 Offset: 0x3008EF8 VA: 0x300CEF8
	private void Heapsort(int lo, int hi) { }

	// RVA: 0x300D1B4 Offset: 0x30091B4 VA: 0x300D1B4
	private void DownHeap(int i, int n, int lo) { }

	// RVA: 0x300CD10 Offset: 0x3008D10 VA: 0x300CD10
	private void InsertionSort(int lo, int hi) { }
}
