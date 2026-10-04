// Assembly: System.Core.dll
// Namespace: 
[Serializable]
private class ReadOnlyCollectionBuilder.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 15750
{
	// Fields
	private readonly ReadOnlyCollectionBuilder<T> _builder; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ReadOnlyCollectionBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973ED8 Offset: 0x296FED8 VA: 0x2973ED8
	|-ReadOnlyCollectionBuilder.Enumerator<object>..ctor
	|
	|-RVA: 0x297A9AC Offset: 0x29769AC VA: 0x297A9AC
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973F20 Offset: 0x296FF20 VA: 0x2973F20
	|-ReadOnlyCollectionBuilder.Enumerator<object>.get_Current
	|
	|-RVA: 0x297AA74 Offset: 0x2976A74 VA: 0x297AA74
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973F28 Offset: 0x296FF28 VA: 0x2973F28
	|-ReadOnlyCollectionBuilder.Enumerator<object>.Dispose
	|
	|-RVA: 0x297AB10 Offset: 0x2976B10 VA: 0x297AB10
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973F2C Offset: 0x296FF2C VA: 0x2973F2C
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x297AB14 Offset: 0x2976B14 VA: 0x297AB14
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2973F70 Offset: 0x296FF70 VA: 0x2973F70
	|-ReadOnlyCollectionBuilder.Enumerator<object>.MoveNext
	|
	|-RVA: 0x297AC44 Offset: 0x2976C44 VA: 0x297AC44
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x297400C Offset: 0x297000C VA: 0x297400C
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297AE80 Offset: 0x2976E80 VA: 0x297AE80
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
