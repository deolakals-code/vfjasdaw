// Assembly: Newtonsoft.Json.dll
// Namespace: 
[Nullable(0)]
[DefaultMember("Item")]
private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 16045
{
	// Fields
	[Nullable(2)]
	internal JToken _token; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }

	// Methods

	[IteratorStateMachine(typeof(JProperty.JPropertyList.<GetEnumerator>d__1))]
	// RVA: 0x30C94C8 Offset: 0x30C54C8 VA: 0x30C94C8 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x30C955C Offset: 0x30C555C VA: 0x30C955C Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x30C9560 Offset: 0x30C5560 VA: 0x30C9560 Slot: 11
	public void Add(JToken item) { }

	// RVA: 0x30C9568 Offset: 0x30C5568 VA: 0x30C9568 Slot: 12
	public void Clear() { }

	// RVA: 0x30C9574 Offset: 0x30C5574 VA: 0x30C9574 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0x30C9584 Offset: 0x30C5584 VA: 0x30C9584 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x30C95F8 Offset: 0x30C55F8 VA: 0x30C95F8 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0x30C9630 Offset: 0x30C5630 VA: 0x30C9630 Slot: 9
	public int get_Count() { }

	// RVA: 0x30C9640 Offset: 0x30C5640 VA: 0x30C9640 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x30C8FF0 Offset: 0x30C4FF0 VA: 0x30C8FF0 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0x30C9648 Offset: 0x30C5648 VA: 0x30C9648 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0x30C965C Offset: 0x30C565C VA: 0x30C965C Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x30C9670 Offset: 0x30C5670 VA: 0x30C9670 Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0x30C96B8 Offset: 0x30C56B8 VA: 0x30C96B8 Slot: 5
	public void set_Item(int index, JToken value) { }

	// RVA: 0x30C8CC8 Offset: 0x30C4CC8 VA: 0x30C8CC8
	public void .ctor() { }
}
