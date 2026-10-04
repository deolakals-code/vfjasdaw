// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
internal class ArraySortHelper<TKey, TValue> // TypeDefIndex: 10971
{
	// Fields
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; // 0x0

	// Properties
	public static ArraySortHelper<TKey, TValue> Default { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42450 Offset: 0x2B3E450 VA: 0x2B42450
	|-ArraySortHelper<ulong, object>.Sort
	|
	|-RVA: 0x2B437A4 Offset: 0x2B3F7A4 VA: 0x2B437A4
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42624 Offset: 0x2B3E624 VA: 0x2B42624
	|-ArraySortHelper<ulong, object>.SwapIfGreaterWithItems
	|
	|-RVA: 0x2B43984 Offset: 0x2B3F984 VA: 0x2B43984
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SwapIfGreaterWithItems
	*/

	// RVA: -1 Offset: -1
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B427D4 Offset: 0x2B3E7D4 VA: 0x2B427D4
	|-ArraySortHelper<ulong, object>.Swap
	|
	|-RVA: 0x2B43F68 Offset: 0x2B3FF68 VA: 0x2B43F68
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B428A4 Offset: 0x2B3E8A4 VA: 0x2B428A4
	|-ArraySortHelper<ulong, object>.IntrospectiveSort
	|
	|-RVA: 0x2B443E0 Offset: 0x2B403E0 VA: 0x2B443E0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IntrospectiveSort
	*/

	// RVA: -1 Offset: -1
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42970 Offset: 0x2B3E970 VA: 0x2B42970
	|-ArraySortHelper<ulong, object>.IntroSort
	|
	|-RVA: 0x2B444F4 Offset: 0x2B404F4 VA: 0x2B444F4
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IntroSort
	*/

	// RVA: -1 Offset: -1
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42CBC Offset: 0x2B3ECBC VA: 0x2B42CBC
	|-ArraySortHelper<ulong, object>.PickPivotAndPartition
	|
	|-RVA: 0x2B44A00 Offset: 0x2B40A00 VA: 0x2B44A00
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.PickPivotAndPartition
	*/

	// RVA: -1 Offset: -1
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B43028 Offset: 0x2B3F028 VA: 0x2B43028
	|-ArraySortHelper<ulong, object>.Heapsort
	|
	|-RVA: 0x2B450E4 Offset: 0x2B410E4 VA: 0x2B450E4
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Heapsort
	*/

	// RVA: -1 Offset: -1
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B43194 Offset: 0x2B3F194 VA: 0x2B43194
	|-ArraySortHelper<ulong, object>.DownHeap
	|
	|-RVA: 0x2B45300 Offset: 0x2B41300 VA: 0x2B45300
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DownHeap
	*/

	// RVA: -1 Offset: -1
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4346C Offset: 0x2B3F46C VA: 0x2B4346C
	|-ArraySortHelper<ulong, object>.InsertionSort
	|
	|-RVA: 0x2B45A80 Offset: 0x2B41A80 VA: 0x2B45A80
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertionSort
	*/

	// RVA: -1 Offset: -1
	public static ArraySortHelper<TKey, TValue> get_Default() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B43674 Offset: 0x2B3F674 VA: 0x2B43674
	|-ArraySortHelper<ulong, object>.get_Default
	|
	|-RVA: 0x2B460A0 Offset: 0x2B420A0 VA: 0x2B460A0
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Default
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B436E0 Offset: 0x2B3F6E0 VA: 0x2B436E0
	|-ArraySortHelper<ulong, object>..ctor
	|
	|-RVA: 0x2B4610C Offset: 0x2B4210C VA: 0x2B4610C
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B436E8 Offset: 0x2B3F6E8 VA: 0x2B436E8
	|-ArraySortHelper<ulong, object>..cctor
	|
	|-RVA: 0x2B46114 Offset: 0x2B42114 VA: 0x2B46114
	|-ArraySortHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}
