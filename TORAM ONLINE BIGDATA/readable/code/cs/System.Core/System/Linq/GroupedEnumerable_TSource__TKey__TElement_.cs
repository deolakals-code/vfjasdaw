// Assembly: System.Core.dll
// Namespace: System.Linq
internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 15215
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A124B8 Offset: 0x2A0E4B8 VA: 0x2A124B8
	|-GroupedEnumerable<int, int, int>..ctor
	|
	|-RVA: 0x2A125C8 Offset: 0x2A0E5C8 VA: 0x2A125C8
	|-GroupedEnumerable<object, byte, object>..ctor
	|
	|-RVA: 0x2A126D8 Offset: 0x2A0E6D8 VA: 0x2A126D8
	|-GroupedEnumerable<object, object, object>..ctor
	|
	|-RVA: 0x2A127E8 Offset: 0x2A0E7E8 VA: 0x2A127E8
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A12578 Offset: 0x2A0E578 VA: 0x2A12578
	|-GroupedEnumerable<int, int, int>.GetEnumerator
	|
	|-RVA: 0x2A12688 Offset: 0x2A0E688 VA: 0x2A12688
	|-GroupedEnumerable<object, byte, object>.GetEnumerator
	|
	|-RVA: 0x2A12798 Offset: 0x2A0E798 VA: 0x2A12798
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|
	|-RVA: 0x2A128A8 Offset: 0x2A0E8A8 VA: 0x2A128A8
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A125B8 Offset: 0x2A0E5B8 VA: 0x2A125B8
	|-GroupedEnumerable<int, int, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A126C8 Offset: 0x2A0E6C8 VA: 0x2A126C8
	|-GroupedEnumerable<object, byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A127D8 Offset: 0x2A0E7D8 VA: 0x2A127D8
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A128F0 Offset: 0x2A0E8F0 VA: 0x2A128F0
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
