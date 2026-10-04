// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
public interface IReadOnlyList<T> : IReadOnlyCollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 10944
{
	// Properties
	public abstract T Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IReadOnlyList<__Il2CppFullySharedGenericType>.get_Item
	*/
}
