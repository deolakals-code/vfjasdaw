// Assembly: System.Core.dll
// Namespace: System.Linq
public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 15207
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IOrderedEnumerable<__Il2CppFullySharedGenericType>.CreateOrderedEnumerable<__Il2CppFullySharedGenericType>
	*/
}
