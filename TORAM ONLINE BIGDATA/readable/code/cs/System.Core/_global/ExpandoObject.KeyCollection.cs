// Assembly: System.Core.dll
// Namespace: 
[DebuggerTypeProxy(typeof(ExpandoObject.KeyCollectionDebugView))]
[DebuggerDisplay("Count = {Count}")]
private class ExpandoObject.KeyCollection : ICollection<string>, IEnumerable<string>, IEnumerable // TypeDefIndex: 15774
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

	// RVA: 0x3184F00 Offset: 0x3180F00 VA: 0x3184F00
	internal void .ctor(ExpandoObject expando) { }

	// RVA: 0x3185DAC Offset: 0x3181DAC VA: 0x3185DAC
	private void CheckVersion() { }

	// RVA: 0x3185E0C Offset: 0x3181E0C VA: 0x3185E0C Slot: 6
	public void Add(string item) { }

	// RVA: 0x3185E34 Offset: 0x3181E34 VA: 0x3185E34 Slot: 7
	public void Clear() { }

	// RVA: 0x3185E5C Offset: 0x3181E5C VA: 0x3185E5C Slot: 8
	public bool Contains(string item) { }

	// RVA: 0x3185F50 Offset: 0x3181F50 VA: 0x3185F50 Slot: 9
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x31861D4 Offset: 0x31821D4 VA: 0x31861D4 Slot: 4
	public int get_Count() { }

	// RVA: 0x31861EC Offset: 0x31821EC VA: 0x31861EC Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x31861F4 Offset: 0x31821F4 VA: 0x31861F4 Slot: 10
	public bool Remove(string item) { }

	[IteratorStateMachine(typeof(ExpandoObject.KeyCollection.<GetEnumerator>d__15))]
	// RVA: 0x318621C Offset: 0x318221C VA: 0x318621C Slot: 11
	public IEnumerator<string> GetEnumerator() { }

	// RVA: 0x3186290 Offset: 0x3182290 VA: 0x3186290 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}
