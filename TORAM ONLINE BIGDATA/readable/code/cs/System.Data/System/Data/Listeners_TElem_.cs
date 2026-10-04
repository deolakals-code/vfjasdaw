// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class Listeners<TElem> // TypeDefIndex: 14774
{
	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D8CC Offset: 0x2B998CC VA: 0x2B9D8CC
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D954 Offset: 0x2B99954 VA: 0x2B9D954
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D978 Offset: 0x2B99978 VA: 0x2B9D978
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D9E8 Offset: 0x2B999E8 VA: 0x2B9D9E8
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9D9FC Offset: 0x2B999FC VA: 0x2B9D9FC
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2679BE0 Offset: 0x2675BE0 VA: 0x2679BE0
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0x2679DD8 Offset: 0x2675DD8 VA: 0x2679DD8
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0x2679FD4 Offset: 0x2675FD4 VA: 0x2679FD4
	|-Listeners<object>.Notify<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B9DAA8 Offset: 0x2B99AA8 VA: 0x2B9DAA8
	|-Listeners<object>.RemoveNullListeners
	*/
}
