// Assembly: System.Core.dll
// Namespace: System.Linq
internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable // TypeDefIndex: 15217
{
	// Fields
	internal IEnumerable<TElement> source; // 0x0

	// Methods

	[IteratorStateMachine(typeof(OrderedEnumerable.<GetEnumerator>d__1<TElement>))]
	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<TElement> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE41C Offset: 0x2BDA41C VA: 0x2BDE41C
	|-OrderedEnumerable<KeyValuePair<byte, byte>>.GetEnumerator
	|
	|-RVA: 0x2BDE4AC Offset: 0x2BDA4AC VA: 0x2BDE4AC
	|-OrderedEnumerable<KeyValuePair<byte, object>>.GetEnumerator
	|
	|-RVA: 0x2BDE53C Offset: 0x2BDA53C VA: 0x2BDE53C
	|-OrderedEnumerable<KeyValuePair<Int16Enum, object>>.GetEnumerator
	|
	|-RVA: 0x2BDE5CC Offset: 0x2BDA5CC VA: 0x2BDE5CC
	|-OrderedEnumerable<KeyValuePair<int, short>>.GetEnumerator
	|
	|-RVA: 0x2BDE65C Offset: 0x2BDA65C VA: 0x2BDE65C
	|-OrderedEnumerable<KeyValuePair<int, int>>.GetEnumerator
	|
	|-RVA: 0x2BDE6EC Offset: 0x2BDA6EC VA: 0x2BDE6EC
	|-OrderedEnumerable<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x2BDE77C Offset: 0x2BDA77C VA: 0x2BDE77C
	|-OrderedEnumerable<KeyValuePair<Int32Enum, byte>>.GetEnumerator
	|
	|-RVA: 0x2BDE80C Offset: 0x2BDA80C VA: 0x2BDE80C
	|-OrderedEnumerable<KeyValuePair<Int32Enum, object>>.GetEnumerator
	|
	|-RVA: 0x2BDE89C Offset: 0x2BDA89C VA: 0x2BDE89C
	|-OrderedEnumerable<KeyValuePair<long, short>>.GetEnumerator
	|
	|-RVA: 0x2BDE92C Offset: 0x2BDA92C VA: 0x2BDE92C
	|-OrderedEnumerable<KeyValuePair<object, int>>.GetEnumerator
	|
	|-RVA: 0x2BDE9BC Offset: 0x2BDA9BC VA: 0x2BDE9BC
	|-OrderedEnumerable<ValueTuple<int, int>>.GetEnumerator
	|
	|-RVA: 0x2BDEA4C Offset: 0x2BDAA4C VA: 0x2BDEA4C
	|-OrderedEnumerable<int>.GetEnumerator
	|
	|-RVA: 0x2BDEADC Offset: 0x2BDAADC VA: 0x2BDEADC
	|-OrderedEnumerable<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x2BDEB6C Offset: 0x2BDAB6C VA: 0x2BDEB6C
	|-OrderedEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x2BDEBFC Offset: 0x2BDABFC VA: 0x2BDEBFC
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x2BDECA4 Offset: 0x2BDACA4 VA: 0x2BDECA4
	|-OrderedEnumerable<TrophyManager.TrophyData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.GetEnumerableSorter
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE494 Offset: 0x2BDA494 VA: 0x2BDE494
	|-OrderedEnumerable<KeyValuePair<byte, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE524 Offset: 0x2BDA524 VA: 0x2BDE524
	|-OrderedEnumerable<KeyValuePair<byte, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE5B4 Offset: 0x2BDA5B4 VA: 0x2BDE5B4
	|-OrderedEnumerable<KeyValuePair<Int16Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE644 Offset: 0x2BDA644 VA: 0x2BDE644
	|-OrderedEnumerable<KeyValuePair<int, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE6D4 Offset: 0x2BDA6D4 VA: 0x2BDE6D4
	|-OrderedEnumerable<KeyValuePair<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE764 Offset: 0x2BDA764 VA: 0x2BDE764
	|-OrderedEnumerable<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE7F4 Offset: 0x2BDA7F4 VA: 0x2BDE7F4
	|-OrderedEnumerable<KeyValuePair<Int32Enum, byte>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE884 Offset: 0x2BDA884 VA: 0x2BDE884
	|-OrderedEnumerable<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE914 Offset: 0x2BDA914 VA: 0x2BDE914
	|-OrderedEnumerable<KeyValuePair<long, short>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDE9A4 Offset: 0x2BDA9A4 VA: 0x2BDE9A4
	|-OrderedEnumerable<KeyValuePair<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDEA34 Offset: 0x2BDAA34 VA: 0x2BDEA34
	|-OrderedEnumerable<ValueTuple<int, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDEAC4 Offset: 0x2BDAAC4 VA: 0x2BDEAC4
	|-OrderedEnumerable<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDEB54 Offset: 0x2BDAB54 VA: 0x2BDEB54
	|-OrderedEnumerable<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDEBE4 Offset: 0x2BDABE4 VA: 0x2BDEBE4
	|-OrderedEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDEC88 Offset: 0x2BDAC88 VA: 0x2BDEC88
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BDED1C Offset: 0x2BDAD1C VA: 0x2BDED1C
	|-OrderedEnumerable<TrophyManager.TrophyData>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IOrderedEnumerable<TElement> System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x267B678 Offset: 0x2677678 VA: 0x267B678
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<byte>
	|
	|-RVA: 0x267B718 Offset: 0x2677718 VA: 0x267B718
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<short>
	|
	|-RVA: 0x267B7B8 Offset: 0x26777B8 VA: 0x267B7B8
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<int>
	|
	|-RVA: 0x267B858 Offset: 0x2677858 VA: 0x267B858
	|-OrderedEnumerable<object>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<long>
	|
	|-RVA: 0x267B8F8 Offset: 0x26778F8 VA: 0x267B8F8
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>.System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BDE4A4 Offset: 0x2BDA4A4 VA: 0x2BDE4A4
	|-OrderedEnumerable<KeyValuePair<byte, byte>>..ctor
	|
	|-RVA: 0x2BDE534 Offset: 0x2BDA534 VA: 0x2BDE534
	|-OrderedEnumerable<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2BDE5C4 Offset: 0x2BDA5C4 VA: 0x2BDE5C4
	|-OrderedEnumerable<KeyValuePair<Int16Enum, object>>..ctor
	|
	|-RVA: 0x2BDE654 Offset: 0x2BDA654 VA: 0x2BDE654
	|-OrderedEnumerable<KeyValuePair<int, short>>..ctor
	|
	|-RVA: 0x2BDE6E4 Offset: 0x2BDA6E4 VA: 0x2BDE6E4
	|-OrderedEnumerable<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2BDE774 Offset: 0x2BDA774 VA: 0x2BDE774
	|-OrderedEnumerable<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2BDE804 Offset: 0x2BDA804 VA: 0x2BDE804
	|-OrderedEnumerable<KeyValuePair<Int32Enum, byte>>..ctor
	|
	|-RVA: 0x2BDE894 Offset: 0x2BDA894 VA: 0x2BDE894
	|-OrderedEnumerable<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2BDE924 Offset: 0x2BDA924 VA: 0x2BDE924
	|-OrderedEnumerable<KeyValuePair<long, short>>..ctor
	|
	|-RVA: 0x2BDE9B4 Offset: 0x2BDA9B4 VA: 0x2BDE9B4
	|-OrderedEnumerable<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2BDEA44 Offset: 0x2BDAA44 VA: 0x2BDEA44
	|-OrderedEnumerable<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x2BDEAD4 Offset: 0x2BDAAD4 VA: 0x2BDEAD4
	|-OrderedEnumerable<int>..ctor
	|
	|-RVA: 0x2BDEB64 Offset: 0x2BDAB64 VA: 0x2BDEB64
	|-OrderedEnumerable<Int32Enum>..ctor
	|
	|-RVA: 0x2BDEBF4 Offset: 0x2BDABF4 VA: 0x2BDEBF4
	|-OrderedEnumerable<object>..ctor
	|
	|-RVA: 0x2BDEC9C Offset: 0x2BDAC9C VA: 0x2BDEC9C
	|-OrderedEnumerable<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2BDED2C Offset: 0x2BDAD2C VA: 0x2BDED2C
	|-OrderedEnumerable<TrophyManager.TrophyData>..ctor
	*/
}
