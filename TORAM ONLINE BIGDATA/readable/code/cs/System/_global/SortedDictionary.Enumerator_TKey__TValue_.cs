// Assembly: System.dll
// Namespace: 
public struct SortedDictionary.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator // TypeDefIndex: 14315
{
	// Fields
	private SortedSet.Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; // 0x0
	private int _getEnumeratorRetType; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	internal bool NotStartedOrEnded { get; }
	private object System.Collections.IEnumerator.Current { get; }
	private object System.Collections.IDictionaryEnumerator.Key { get; }
	private object System.Collections.IDictionaryEnumerator.Value { get; }
	private DictionaryEntry System.Collections.IDictionaryEnumerator.Entry { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x298806C Offset: 0x298406C VA: 0x298806C
	|-SortedDictionary.Enumerator<byte, object>..ctor
	|
	|-RVA: 0x298BA68 Offset: 0x2987A68 VA: 0x298BA68
	|-SortedDictionary.Enumerator<double, int>..ctor
	|
	|-RVA: 0x29AE4FC Offset: 0x29AA4FC VA: 0x29AE4FC
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29880F0 Offset: 0x29840F0 VA: 0x29880F0
	|-SortedDictionary.Enumerator<byte, object>.MoveNext
	|
	|-RVA: 0x298BAEC Offset: 0x2987AEC VA: 0x298BAEC
	|-SortedDictionary.Enumerator<double, int>.MoveNext
	|
	|-RVA: 0x29AE5C4 Offset: 0x29AA5C4 VA: 0x29AE5C4
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2988160 Offset: 0x2984160 VA: 0x2988160
	|-SortedDictionary.Enumerator<byte, object>.Dispose
	|
	|-RVA: 0x298BB5C Offset: 0x2987B5C VA: 0x298BB5C
	|-SortedDictionary.Enumerator<double, int>.Dispose
	|
	|-RVA: 0x29AE674 Offset: 0x29AA674 VA: 0x29AE674
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29881D0 Offset: 0x29841D0 VA: 0x29881D0
	|-SortedDictionary.Enumerator<byte, object>.get_Current
	|
	|-RVA: 0x298BBCC Offset: 0x2987BCC VA: 0x298BBCC
	|-SortedDictionary.Enumerator<double, int>.get_Current
	|
	|-RVA: 0x29AE724 Offset: 0x29AA724 VA: 0x29AE724
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal bool get_NotStartedOrEnded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2988240 Offset: 0x2984240 VA: 0x2988240
	|-SortedDictionary.Enumerator<byte, object>.get_NotStartedOrEnded
	|
	|-RVA: 0x298BC3C Offset: 0x2987C3C VA: 0x298BC3C
	|-SortedDictionary.Enumerator<double, int>.get_NotStartedOrEnded
	|
	|-RVA: 0x29AE878 Offset: 0x29AA878 VA: 0x29AE878
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_NotStartedOrEnded
	*/

	// RVA: -1 Offset: -1
	internal void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29882B0 Offset: 0x29842B0 VA: 0x29882B0
	|-SortedDictionary.Enumerator<byte, object>.Reset
	|
	|-RVA: 0x298BCAC Offset: 0x2987CAC VA: 0x298BCAC
	|-SortedDictionary.Enumerator<double, int>.Reset
	|
	|-RVA: 0x29AE928 Offset: 0x29AA928 VA: 0x29AE928
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2988320 Offset: 0x2984320 VA: 0x2988320
	|-SortedDictionary.Enumerator<byte, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x298BD1C Offset: 0x2987D1C VA: 0x298BD1C
	|-SortedDictionary.Enumerator<double, int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x29AE9D8 Offset: 0x29AA9D8 VA: 0x29AE9D8
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2988390 Offset: 0x2984390 VA: 0x2988390
	|-SortedDictionary.Enumerator<byte, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x298BD8C Offset: 0x2987D8C VA: 0x298BD8C
	|-SortedDictionary.Enumerator<double, int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29AEA88 Offset: 0x29AAA88 VA: 0x29AEA88
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IDictionaryEnumerator.get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29885A4 Offset: 0x29845A4 VA: 0x29885A4
	|-SortedDictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x298BFD8 Offset: 0x2987FD8 VA: 0x298BFD8
	|-SortedDictionary.Enumerator<double, int>.System.Collections.IDictionaryEnumerator.get_Key
	|
	|-RVA: 0x29AF0B0 Offset: 0x29AB0B0 VA: 0x29AF0B0
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private object System.Collections.IDictionaryEnumerator.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2988694 Offset: 0x2984694 VA: 0x2988694
	|-SortedDictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x298C0C8 Offset: 0x29880C8 VA: 0x298C0C8
	|-SortedDictionary.Enumerator<double, int>.System.Collections.IDictionaryEnumerator.get_Value
	|
	|-RVA: 0x29AF354 Offset: 0x29AB354 VA: 0x29AF354
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2988750 Offset: 0x2984750 VA: 0x2988750
	|-SortedDictionary.Enumerator<byte, object>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x298C1AC Offset: 0x29881AC VA: 0x298C1AC
	|-SortedDictionary.Enumerator<double, int>.System.Collections.IDictionaryEnumerator.get_Entry
	|
	|-RVA: 0x29AF5F8 Offset: 0x29AB5F8 VA: 0x29AF5F8
	|-SortedDictionary.Enumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionaryEnumerator.get_Entry
	*/
}
