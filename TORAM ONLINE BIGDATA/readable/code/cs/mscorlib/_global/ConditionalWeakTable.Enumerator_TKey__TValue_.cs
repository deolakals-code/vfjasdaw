// Assembly: mscorlib.dll
// Namespace: 
private sealed class ConditionalWeakTable.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 10545
{
	// Fields
	private ConditionalWeakTable<TKey, TValue> _table; // 0x0
	private int _currentIndex; // 0x0
	private KeyValuePair<TKey, TValue> _current; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ConditionalWeakTable<TKey, TValue> table) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8AC8 Offset: 0x29A4AC8 VA: 0x29A8AC8
	|-ConditionalWeakTable.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8B08 Offset: 0x29A4B08 VA: 0x29A8B08
	|-ConditionalWeakTable.Enumerator<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8BA0 Offset: 0x29A4BA0 VA: 0x29A8BA0
	|-ConditionalWeakTable.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8C18 Offset: 0x29A4C18 VA: 0x29A8C18
	|-ConditionalWeakTable.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8E5C Offset: 0x29A4E5C VA: 0x29A8E5C
	|-ConditionalWeakTable.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8E80 Offset: 0x29A4E80 VA: 0x29A8E80
	|-ConditionalWeakTable.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29A8ED0 Offset: 0x29A4ED0 VA: 0x29A8ED0
	|-ConditionalWeakTable.Enumerator<object, object>.Reset
	*/
}
