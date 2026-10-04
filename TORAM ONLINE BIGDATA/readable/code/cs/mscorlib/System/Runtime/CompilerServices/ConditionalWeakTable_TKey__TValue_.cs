// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 10546
{
	// Fields
	private const int INITIAL_SIZE = 13;
	private const float LOAD_FACTOR = 0.7;
	private const float COMPACT_FACTOR = 0.5;
	private const float EXPAND_FACTOR = 1.1;
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC38E8 Offset: 0x2DBF8E8 VA: 0x2DC38E8
	|-ConditionalWeakTable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC39C0 Offset: 0x2DBF9C0 VA: 0x2DC39C0
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC39D4 Offset: 0x2DBF9D4 VA: 0x2DC39D4
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC3BE4 Offset: 0x2DBFBE4 VA: 0x2DC3BE4
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC3C4C Offset: 0x2DBFC4C VA: 0x2DC3C4C
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC3EEC Offset: 0x2DBFEEC VA: 0x2DC3EEC
	|-ConditionalWeakTable<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC4228 Offset: 0x2DC0228 VA: 0x2DC4228
	|-ConditionalWeakTable<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC4478 Offset: 0x2DC0478 VA: 0x2DC4478
	|-ConditionalWeakTable<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC46D4 Offset: 0x2DC06D4 VA: 0x2DC46D4
	|-ConditionalWeakTable<object, object>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC4888 Offset: 0x2DC0888 VA: 0x2DC4888
	|-ConditionalWeakTable<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC4A64 Offset: 0x2DC0A64 VA: 0x2DC4A64
	|-ConditionalWeakTable<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}
