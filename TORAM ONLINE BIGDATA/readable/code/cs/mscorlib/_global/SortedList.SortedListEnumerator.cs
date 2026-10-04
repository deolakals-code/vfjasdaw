// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 10885
{
	// Fields
	private SortedList _sortedList; // 0x10
	private object _key; // 0x18
	private object _value; // 0x20
	private int _index; // 0x28
	private int _startIndex; // 0x2C
	private int _endIndex; // 0x30
	private int _version; // 0x34
	private bool _current; // 0x38
	private int _getObjectRetType; // 0x3C

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x2FB8040 Offset: 0x2FB4040 VA: 0x2FB8040
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0x2FB99E4 Offset: 0x2FB59E4 VA: 0x2FB99E4 Slot: 10
	public object Clone() { }

	// RVA: 0x2FB99EC Offset: 0x2FB59EC VA: 0x2FB99EC Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x2FB9A88 Offset: 0x2FB5A88 VA: 0x2FB9A88 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x2FB9BC8 Offset: 0x2FB5BC8 VA: 0x2FB9BC8 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x2FB9C9C Offset: 0x2FB5C9C VA: 0x2FB9C9C Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x2FB9D94 Offset: 0x2FB5D94 VA: 0x2FB9D94 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x2FB9E30 Offset: 0x2FB5E30 VA: 0x2FB9E30 Slot: 16
	public virtual void Reset() { }
}
