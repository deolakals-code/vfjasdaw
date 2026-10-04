// Assembly: mscorlib.dll
// Namespace: 
private struct Array.SorterObjectArray // TypeDefIndex: 9726
{
	// Fields
	private object[] keys; // 0x0
	private object[] items; // 0x8
	private IComparer comparer; // 0x10

	// Methods

	// RVA: 0x300B70C Offset: 0x300770C VA: 0x300B70C
	internal void .ctor(object[] keys, object[] items, IComparer comparer) { }

	// RVA: 0x300B7AC Offset: 0x30077AC VA: 0x300B7AC
	internal void SwapIfGreaterWithItems(int a, int b) { }

	// RVA: 0x300BA18 Offset: 0x3007A18 VA: 0x300BA18
	private void Swap(int i, int j) { }

	// RVA: 0x300BBB8 Offset: 0x3007BB8 VA: 0x300BBB8
	internal void Sort(int left, int length) { }

	// RVA: 0x300BBBC Offset: 0x3007BBC VA: 0x300BBBC
	private void IntrospectiveSort(int left, int length) { }

	// RVA: 0x300BD08 Offset: 0x3007D08 VA: 0x300BD08
	private void IntroSort(int lo, int hi, int depthLimit) { }

	// RVA: 0x300C184 Offset: 0x3008184 VA: 0x300C184
	private int PickPivotAndPartition(int lo, int hi) { }

	// RVA: 0x300C0E4 Offset: 0x30080E4 VA: 0x300C0E4
	private void Heapsort(int lo, int hi) { }

	// RVA: 0x300C3B0 Offset: 0x30083B0 VA: 0x300C3B0
	private void DownHeap(int i, int n, int lo) { }

	// RVA: 0x300BE1C Offset: 0x3007E1C VA: 0x300BE1C
	private void InsertionSort(int lo, int hi) { }
}
