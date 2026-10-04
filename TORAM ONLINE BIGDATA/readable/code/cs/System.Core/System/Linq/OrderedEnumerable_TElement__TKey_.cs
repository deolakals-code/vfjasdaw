// Assembly: System.Core.dll
// Namespace: System.Linq
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement> // TypeDefIndex: 15218
{
	// Fields
	internal OrderedEnumerable<TElement> parent; // 0x0
	internal Func<TElement, TKey> keySelector; // 0x0
	internal IComparer<TKey> comparer; // 0x0
	internal bool descending; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDED34 Offset: 0x2BDAD34 VA: 0x2BDED34
	|-OrderedEnumerable<KeyValuePair<byte, byte>, byte>..ctor
	|
	|-RVA: 0x2BDEEB4 Offset: 0x2BDAEB4 VA: 0x2BDEEB4
	|-OrderedEnumerable<KeyValuePair<byte, object>, byte>..ctor
	|
	|-RVA: 0x2BDF034 Offset: 0x2BDB034 VA: 0x2BDF034
	|-OrderedEnumerable<KeyValuePair<Int16Enum, object>, Int16Enum>..ctor
	|
	|-RVA: 0x2BDF1B4 Offset: 0x2BDB1B4 VA: 0x2BDF1B4
	|-OrderedEnumerable<KeyValuePair<int, short>, short>..ctor
	|
	|-RVA: 0x2BDF334 Offset: 0x2BDB334 VA: 0x2BDF334
	|-OrderedEnumerable<KeyValuePair<int, int>, int>..ctor
	|
	|-RVA: 0x2BDF4B4 Offset: 0x2BDB4B4 VA: 0x2BDF4B4
	|-OrderedEnumerable<KeyValuePair<int, object>, DateTime>..ctor
	|
	|-RVA: 0x2BDF634 Offset: 0x2BDB634 VA: 0x2BDF634
	|-OrderedEnumerable<KeyValuePair<int, object>, int>..ctor
	|
	|-RVA: 0x2BDF7B4 Offset: 0x2BDB7B4 VA: 0x2BDF7B4
	|-OrderedEnumerable<KeyValuePair<Int32Enum, byte>, int>..ctor
	|
	|-RVA: 0x2BDF934 Offset: 0x2BDB934 VA: 0x2BDF934
	|-OrderedEnumerable<KeyValuePair<Int32Enum, object>, int>..ctor
	|
	|-RVA: 0x2BDFAB4 Offset: 0x2BDBAB4 VA: 0x2BDFAB4
	|-OrderedEnumerable<KeyValuePair<long, short>, short>..ctor
	|
	|-RVA: 0x2BDFC34 Offset: 0x2BDBC34 VA: 0x2BDFC34
	|-OrderedEnumerable<KeyValuePair<object, int>, int>..ctor
	|
	|-RVA: 0x2BDFDB4 Offset: 0x2BDBDB4 VA: 0x2BDFDB4
	|-OrderedEnumerable<ValueTuple<int, int>, int>..ctor
	|
	|-RVA: 0x2BDFF34 Offset: 0x2BDBF34 VA: 0x2BDFF34
	|-OrderedEnumerable<int, int>..ctor
	|
	|-RVA: 0x2BE00B4 Offset: 0x2BDC0B4 VA: 0x2BE00B4
	|-OrderedEnumerable<Int32Enum, int>..ctor
	|
	|-RVA: 0x2BE0234 Offset: 0x2BDC234 VA: 0x2BE0234
	|-OrderedEnumerable<object, bool>..ctor
	|
	|-RVA: 0x2BE03B4 Offset: 0x2BDC3B4 VA: 0x2BE03B4
	|-OrderedEnumerable<object, byte>..ctor
	|
	|-RVA: 0x2BE0534 Offset: 0x2BDC534 VA: 0x2BE0534
	|-OrderedEnumerable<object, DateTime>..ctor
	|
	|-RVA: 0x2BE06B4 Offset: 0x2BDC6B4 VA: 0x2BE06B4
	|-OrderedEnumerable<object, short>..ctor
	|
	|-RVA: 0x2BE0834 Offset: 0x2BDC834 VA: 0x2BE0834
	|-OrderedEnumerable<object, int>..ctor
	|
	|-RVA: 0x2BE09B4 Offset: 0x2BDC9B4 VA: 0x2BE09B4
	|-OrderedEnumerable<object, Int32Enum>..ctor
	|
	|-RVA: 0x2BE0B34 Offset: 0x2BDCB34 VA: 0x2BE0B34
	|-OrderedEnumerable<object, long>..ctor
	|
	|-RVA: 0x2BE0CB4 Offset: 0x2BDCCB4 VA: 0x2BE0CB4
	|-OrderedEnumerable<object, object>..ctor
	|
	|-RVA: 0x2BE0E34 Offset: 0x2BDCE34 VA: 0x2BE0E34
	|-OrderedEnumerable<object, float>..ctor
	|
	|-RVA: 0x2BE0FB4 Offset: 0x2BDCFB4 VA: 0x2BE0FB4
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2BE1148 Offset: 0x2BDD148 VA: 0x2BE1148
	|-OrderedEnumerable<TrophyManager.TrophyData, int>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDEE08 Offset: 0x2BDAE08 VA: 0x2BDEE08
	|-OrderedEnumerable<KeyValuePair<byte, byte>, byte>.GetEnumerableSorter
	|
	|-RVA: 0x2BDEF88 Offset: 0x2BDAF88 VA: 0x2BDEF88
	|-OrderedEnumerable<KeyValuePair<byte, object>, byte>.GetEnumerableSorter
	|
	|-RVA: 0x2BDF108 Offset: 0x2BDB108 VA: 0x2BDF108
	|-OrderedEnumerable<KeyValuePair<Int16Enum, object>, Int16Enum>.GetEnumerableSorter
	|
	|-RVA: 0x2BDF288 Offset: 0x2BDB288 VA: 0x2BDF288
	|-OrderedEnumerable<KeyValuePair<int, short>, short>.GetEnumerableSorter
	|
	|-RVA: 0x2BDF408 Offset: 0x2BDB408 VA: 0x2BDF408
	|-OrderedEnumerable<KeyValuePair<int, int>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BDF588 Offset: 0x2BDB588 VA: 0x2BDF588
	|-OrderedEnumerable<KeyValuePair<int, object>, DateTime>.GetEnumerableSorter
	|
	|-RVA: 0x2BDF708 Offset: 0x2BDB708 VA: 0x2BDF708
	|-OrderedEnumerable<KeyValuePair<int, object>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BDF888 Offset: 0x2BDB888 VA: 0x2BDF888
	|-OrderedEnumerable<KeyValuePair<Int32Enum, byte>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BDFA08 Offset: 0x2BDBA08 VA: 0x2BDFA08
	|-OrderedEnumerable<KeyValuePair<Int32Enum, object>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BDFB88 Offset: 0x2BDBB88 VA: 0x2BDFB88
	|-OrderedEnumerable<KeyValuePair<long, short>, short>.GetEnumerableSorter
	|
	|-RVA: 0x2BDFD08 Offset: 0x2BDBD08 VA: 0x2BDFD08
	|-OrderedEnumerable<KeyValuePair<object, int>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BDFE88 Offset: 0x2BDBE88 VA: 0x2BDFE88
	|-OrderedEnumerable<ValueTuple<int, int>, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0008 Offset: 0x2BDC008 VA: 0x2BE0008
	|-OrderedEnumerable<int, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0188 Offset: 0x2BDC188 VA: 0x2BE0188
	|-OrderedEnumerable<Int32Enum, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0308 Offset: 0x2BDC308 VA: 0x2BE0308
	|-OrderedEnumerable<object, bool>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0488 Offset: 0x2BDC488 VA: 0x2BE0488
	|-OrderedEnumerable<object, byte>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0608 Offset: 0x2BDC608 VA: 0x2BE0608
	|-OrderedEnumerable<object, DateTime>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0788 Offset: 0x2BDC788 VA: 0x2BE0788
	|-OrderedEnumerable<object, short>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0908 Offset: 0x2BDC908 VA: 0x2BE0908
	|-OrderedEnumerable<object, int>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0A88 Offset: 0x2BDCA88 VA: 0x2BE0A88
	|-OrderedEnumerable<object, Int32Enum>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0C08 Offset: 0x2BDCC08 VA: 0x2BE0C08
	|-OrderedEnumerable<object, long>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0D88 Offset: 0x2BDCD88 VA: 0x2BE0D88
	|-OrderedEnumerable<object, object>.GetEnumerableSorter
	|
	|-RVA: 0x2BE0F08 Offset: 0x2BDCF08 VA: 0x2BE0F08
	|-OrderedEnumerable<object, float>.GetEnumerableSorter
	|
	|-RVA: 0x2BE1098 Offset: 0x2BDD098 VA: 0x2BE1098
	|-OrderedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerableSorter
	|
	|-RVA: 0x2BE121C Offset: 0x2BDD21C VA: 0x2BE121C
	|-OrderedEnumerable<TrophyManager.TrophyData, int>.GetEnumerableSorter
	*/
}
