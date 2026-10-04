// Assembly: System.Core.dll
// Namespace: 
[DebuggerTypeProxy(typeof(ExpandoObject.ValueCollectionDebugView))]
[DebuggerDisplay("Count = {Count}")]
private class ExpandoObject.ValueCollection : ICollection<object>, IEnumerable<object>, IEnumerable // TypeDefIndex: 15777
{
	// Fields
	private readonly ExpandoObject _expando; // 0x10
	private readonly int _expandoVersion; // 0x18
	private readonly int _expandoCount; // 0x1C
	private readonly ExpandoObject.ExpandoData _expandoData; // 0x20

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x318648C Offset: 0x318248C VA: 0x318648C
	internal void .ctor(ExpandoObject expando) { }

	// RVA: 0x3186598 Offset: 0x3182598 VA: 0x3186598
	private void CheckVersion() { }

	// RVA: 0x31865F8 Offset: 0x31825F8 VA: 0x31865F8 Slot: 6
	public void Add(object item) { }

	// RVA: 0x3186620 Offset: 0x3182620 VA: 0x3186620 Slot: 7
	public void Clear() { }

	// RVA: 0x3186648 Offset: 0x3182648 VA: 0x3186648 Slot: 8
	public bool Contains(object item) { }

	// RVA: 0x31867A8 Offset: 0x31827A8 VA: 0x31867A8 Slot: 9
	public void CopyTo(object[] array, int arrayIndex) { }

	// RVA: 0x3186A70 Offset: 0x3182A70 VA: 0x3186A70 Slot: 4
	public int get_Count() { }

	// RVA: 0x3186A88 Offset: 0x3182A88 VA: 0x3186A88 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x3186A90 Offset: 0x3182A90 VA: 0x3186A90 Slot: 10
	public bool Remove(object item) { }

	[IteratorStateMachine(typeof(ExpandoObject.ValueCollection.<GetEnumerator>d__15))]
	// RVA: 0x3186AB8 Offset: 0x3182AB8 VA: 0x3186AB8 Slot: 11
	public IEnumerator<object> GetEnumerator() { }

	// RVA: 0x3186B4C Offset: 0x3182B4C VA: 0x3186B4C Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}
