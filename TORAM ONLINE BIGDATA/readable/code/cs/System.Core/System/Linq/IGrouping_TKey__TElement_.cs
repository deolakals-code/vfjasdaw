// Assembly: System.Core.dll
// Namespace: System.Linq
public interface IGrouping<TKey, TElement> : IEnumerable<TElement>, IEnumerable // TypeDefIndex: 15208
{
	// Properties
	public abstract TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TKey get_Key();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IGrouping<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/
}
