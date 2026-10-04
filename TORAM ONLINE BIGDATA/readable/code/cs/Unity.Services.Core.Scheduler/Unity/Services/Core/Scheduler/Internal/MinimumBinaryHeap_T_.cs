// Assembly: Unity.Services.Core.Scheduler.dll
// Namespace: Unity.Services.Core.Scheduler.Internal
internal class MinimumBinaryHeap<T> : MinimumBinaryHeap // TypeDefIndex: 17902
{
	// Fields
	private readonly object m_Lock; // 0x0
	private readonly IComparer<T> m_Comparer; // 0x0
	private readonly int m_MinimumCapacity; // 0x0
	private T[] m_HeapArray; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x0

	// Properties
	public int Count { get; set; }
	public T Min { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8290 Offset: 0x2BA4290 VA: 0x2BA8290
	|-MinimumBinaryHeap<object>.get_Count
	|
	|-RVA: 0x2BA934C Offset: 0x2BA534C VA: 0x2BA934C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Count
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Count(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8298 Offset: 0x2BA4298 VA: 0x2BA8298
	|-MinimumBinaryHeap<object>.set_Count
	|
	|-RVA: 0x2BA9354 Offset: 0x2BA5354 VA: 0x2BA9354
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.set_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Min() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA82A0 Offset: 0x2BA42A0 VA: 0x2BA82A0
	|-MinimumBinaryHeap<object>.get_Min
	|
	|-RVA: 0x2BA935C Offset: 0x2BA535C VA: 0x2BA935C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.get_Min
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA82C8 Offset: 0x2BA42C8 VA: 0x2BA82C8
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x2BA9404 Offset: 0x2BA5404 VA: 0x2BA9404
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA82E8 Offset: 0x2BA42E8 VA: 0x2BA82E8
	|-MinimumBinaryHeap<object>..ctor
	|
	|-RVA: 0x2BA9428 Offset: 0x2BA5428 VA: 0x2BA9428
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Insert(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8854 Offset: 0x2BA4854 VA: 0x2BA8854
	|-MinimumBinaryHeap<object>.Insert
	|
	|-RVA: 0x2BA9AB4 Offset: 0x2BA5AB4 VA: 0x2BA9AB4
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	private void IncreaseHeapCapacityWhenFull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8AD8 Offset: 0x2BA4AD8 VA: 0x2BA8AD8
	|-MinimumBinaryHeap<object>.IncreaseHeapCapacityWhenFull
	|
	|-RVA: 0x2BA9F2C Offset: 0x2BA5F2C VA: 0x2BA9F2C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IncreaseHeapCapacityWhenFull
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8BDC Offset: 0x2BA4BDC VA: 0x2BA8BDC
	|-MinimumBinaryHeap<object>.Remove
	|
	|-RVA: 0x2BAA07C Offset: 0x2BA607C VA: 0x2BAA07C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	private int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8D58 Offset: 0x2BA4D58 VA: 0x2BA8D58
	|-MinimumBinaryHeap<object>.IndexOf
	|
	|-RVA: 0x2BAA2D8 Offset: 0x2BA62D8 VA: 0x2BAA2D8
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public T ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8DD8 Offset: 0x2BA4DD8 VA: 0x2BA8DD8
	|-MinimumBinaryHeap<object>.ExtractMin
	|
	|-RVA: 0x2BAA4B8 Offset: 0x2BA64B8 VA: 0x2BAA4B8
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	private void DecreaseHeapCapacityWhenSpare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8FB4 Offset: 0x2BA4FB4 VA: 0x2BA8FB4
	|-MinimumBinaryHeap<object>.DecreaseHeapCapacityWhenSpare
	|
	|-RVA: 0x2BAAA1C Offset: 0x2BA6A1C VA: 0x2BAAA1C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.DecreaseHeapCapacityWhenSpare
	*/

	// RVA: -1 Offset: -1
	private void MinHeapify() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA90BC Offset: 0x2BA50BC VA: 0x2BA90BC
	|-MinimumBinaryHeap<object>.MinHeapify
	|
	|-RVA: 0x2BAAB9C Offset: 0x2BA6B9C VA: 0x2BAAB9C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.MinHeapify
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref T lhs, ref T rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA9188 Offset: 0x2BA5188 VA: 0x2BA9188
	|-MinimumBinaryHeap<object>.Swap
	|
	|-RVA: 0x2BAAC60 Offset: 0x2BA6C60 VA: 0x2BAAC60
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	private static int GetParentIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA91BC Offset: 0x2BA51BC VA: 0x2BA91BC
	|-MinimumBinaryHeap<object>.GetParentIndex
	|
	|-RVA: 0x2BAAE48 Offset: 0x2BA6E48 VA: 0x2BAAE48
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetParentIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetLeftChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA91D0 Offset: 0x2BA51D0 VA: 0x2BA91D0
	|-MinimumBinaryHeap<object>.GetLeftChildIndex
	|
	|-RVA: 0x2BAAE5C Offset: 0x2BA6E5C VA: 0x2BAAE5C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetLeftChildIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetRightChildIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA91E0 Offset: 0x2BA51E0 VA: 0x2BA91E0
	|-MinimumBinaryHeap<object>.GetRightChildIndex
	|
	|-RVA: 0x2BAAE6C Offset: 0x2BA6E6C VA: 0x2BAAE6C
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.GetRightChildIndex
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIndex|21_0(ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA91EC Offset: 0x2BA51EC VA: 0x2BA91EC
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIndex|21_0
	|
	|-RVA: 0x2BAAE78 Offset: 0x2BA6E78 VA: 0x2BAAE78
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIndex|21_0
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref MinimumBinaryHeap.<>c__DisplayClass21_0<T> ) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA9258 Offset: 0x2BA5258 VA: 0x2BA9258
	|-MinimumBinaryHeap<object>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	|
	|-RVA: 0x2BAAF20 Offset: 0x2BA6F20 VA: 0x2BAAF20
	|-MinimumBinaryHeap<__Il2CppFullySharedGenericType>.<MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1
	*/
}
