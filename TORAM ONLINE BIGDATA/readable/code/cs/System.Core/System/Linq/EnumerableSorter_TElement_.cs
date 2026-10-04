// Assembly: System.Core.dll
// Namespace: System.Linq
internal abstract class EnumerableSorter<TElement> // TypeDefIndex: 15219
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ComputeKeys(TElement[] elements, int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.ComputeKeys
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int CompareKeys(int index1, int index2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.CompareKeys
	*/

	// RVA: -1 Offset: -1
	internal int[] Sort(TElement[] elements, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29631AC Offset: 0x295F1AC VA: 0x29631AC
	|-EnumerableSorter<KeyValuePair<byte, byte>>.Sort
	|
	|-RVA: 0x2963450 Offset: 0x295F450 VA: 0x2963450
	|-EnumerableSorter<KeyValuePair<byte, object>>.Sort
	|
	|-RVA: 0x29636F4 Offset: 0x295F6F4 VA: 0x29636F4
	|-EnumerableSorter<KeyValuePair<Int16Enum, object>>.Sort
	|
	|-RVA: 0x2963998 Offset: 0x295F998 VA: 0x2963998
	|-EnumerableSorter<KeyValuePair<int, short>>.Sort
	|
	|-RVA: 0x2963C3C Offset: 0x295FC3C VA: 0x2963C3C
	|-EnumerableSorter<KeyValuePair<int, int>>.Sort
	|
	|-RVA: 0x2963EE0 Offset: 0x295FEE0 VA: 0x2963EE0
	|-EnumerableSorter<KeyValuePair<int, object>>.Sort
	|
	|-RVA: 0x2964184 Offset: 0x2960184 VA: 0x2964184
	|-EnumerableSorter<KeyValuePair<Int32Enum, byte>>.Sort
	|
	|-RVA: 0x2964428 Offset: 0x2960428 VA: 0x2964428
	|-EnumerableSorter<KeyValuePair<Int32Enum, object>>.Sort
	|
	|-RVA: 0x29646CC Offset: 0x29606CC VA: 0x29646CC
	|-EnumerableSorter<KeyValuePair<long, short>>.Sort
	|
	|-RVA: 0x2964970 Offset: 0x2960970 VA: 0x2964970
	|-EnumerableSorter<KeyValuePair<object, int>>.Sort
	|
	|-RVA: 0x2964C14 Offset: 0x2960C14 VA: 0x2964C14
	|-EnumerableSorter<ValueTuple<int, int>>.Sort
	|
	|-RVA: 0x2964EB8 Offset: 0x2960EB8 VA: 0x2964EB8
	|-EnumerableSorter<int>.Sort
	|
	|-RVA: 0x296515C Offset: 0x296115C VA: 0x296515C
	|-EnumerableSorter<Int32Enum>.Sort
	|
	|-RVA: 0x2965400 Offset: 0x2961400 VA: 0x2965400
	|-EnumerableSorter<object>.Sort
	|
	|-RVA: 0x29656A4 Offset: 0x29616A4 VA: 0x29656A4
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.Sort
	|
	|-RVA: 0x2965954 Offset: 0x2961954 VA: 0x2965954
	|-EnumerableSorter<TrophyManager.TrophyData>.Sort
	*/

	// RVA: -1 Offset: -1
	private void QuickSort(int[] map, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296328C Offset: 0x295F28C VA: 0x296328C
	|-EnumerableSorter<KeyValuePair<byte, byte>>.QuickSort
	|
	|-RVA: 0x2963530 Offset: 0x295F530 VA: 0x2963530
	|-EnumerableSorter<KeyValuePair<byte, object>>.QuickSort
	|
	|-RVA: 0x29637D4 Offset: 0x295F7D4 VA: 0x29637D4
	|-EnumerableSorter<KeyValuePair<Int16Enum, object>>.QuickSort
	|
	|-RVA: 0x2963A78 Offset: 0x295FA78 VA: 0x2963A78
	|-EnumerableSorter<KeyValuePair<int, short>>.QuickSort
	|
	|-RVA: 0x2963D1C Offset: 0x295FD1C VA: 0x2963D1C
	|-EnumerableSorter<KeyValuePair<int, int>>.QuickSort
	|
	|-RVA: 0x2963FC0 Offset: 0x295FFC0 VA: 0x2963FC0
	|-EnumerableSorter<KeyValuePair<int, object>>.QuickSort
	|
	|-RVA: 0x2964264 Offset: 0x2960264 VA: 0x2964264
	|-EnumerableSorter<KeyValuePair<Int32Enum, byte>>.QuickSort
	|
	|-RVA: 0x2964508 Offset: 0x2960508 VA: 0x2964508
	|-EnumerableSorter<KeyValuePair<Int32Enum, object>>.QuickSort
	|
	|-RVA: 0x29647AC Offset: 0x29607AC VA: 0x29647AC
	|-EnumerableSorter<KeyValuePair<long, short>>.QuickSort
	|
	|-RVA: 0x2964A50 Offset: 0x2960A50 VA: 0x2964A50
	|-EnumerableSorter<KeyValuePair<object, int>>.QuickSort
	|
	|-RVA: 0x2964CF4 Offset: 0x2960CF4 VA: 0x2964CF4
	|-EnumerableSorter<ValueTuple<int, int>>.QuickSort
	|
	|-RVA: 0x2964F98 Offset: 0x2960F98 VA: 0x2964F98
	|-EnumerableSorter<int>.QuickSort
	|
	|-RVA: 0x296523C Offset: 0x296123C VA: 0x296523C
	|-EnumerableSorter<Int32Enum>.QuickSort
	|
	|-RVA: 0x29654E0 Offset: 0x29614E0 VA: 0x29654E0
	|-EnumerableSorter<object>.QuickSort
	|
	|-RVA: 0x2965788 Offset: 0x2961788 VA: 0x2965788
	|-EnumerableSorter<__Il2CppFullySharedGenericType>.QuickSort
	|
	|-RVA: 0x2965A34 Offset: 0x2961A34 VA: 0x2965A34
	|-EnumerableSorter<TrophyManager.TrophyData>.QuickSort
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2963448 Offset: 0x295F448 VA: 0x2963448
	|-EnumerableSorter<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x29636EC Offset: 0x295F6EC VA: 0x29636EC
	|-EnumerableSorter<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2963990 Offset: 0x295F990 VA: 0x2963990
	|-EnumerableSorter<KeyValuePair<Int16Enum, object>>..ctor
	|
	|-RVA: 0x2963C34 Offset: 0x295FC34 VA: 0x2963C34
	|-EnumerableSorter<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2963ED8 Offset: 0x295FED8 VA: 0x2963ED8
	|-EnumerableSorter<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x296417C Offset: 0x296017C VA: 0x296417C
	|-EnumerableSorter<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2964420 Offset: 0x2960420 VA: 0x2964420
	|-EnumerableSorter<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x29646C4 Offset: 0x29606C4 VA: 0x29646C4
	|-EnumerableSorter<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2964968 Offset: 0x2960968 VA: 0x2964968
	|-EnumerableSorter<KeyValuePair<long, short>>..ctor
	|
	|-RVA: 0x2964C0C Offset: 0x2960C0C VA: 0x2964C0C
	|-EnumerableSorter<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2964EB0 Offset: 0x2960EB0 VA: 0x2964EB0
	|-EnumerableSorter<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2965154 Offset: 0x2961154 VA: 0x2965154
	|-EnumerableSorter<int>..ctor
	|
	|-RVA: 0x29653F8 Offset: 0x29613F8 VA: 0x29653F8
	|-EnumerableSorter<Int32Enum>..ctor
	|
	|-RVA: 0x296569C Offset: 0x296169C VA: 0x296569C
	|-EnumerableSorter<object>..ctor
	|
	|-RVA: 0x296594C Offset: 0x296194C VA: 0x296594C
	|-EnumerableSorter<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2965BF0 Offset: 0x2961BF0 VA: 0x2965BF0
	|-EnumerableSorter<TrophyManager.TrophyData>..ctor
	*/
}
