// Assembly: mscorlib.dll
// Namespace: 
private class ListDictionaryInternal.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 10871
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2FB4720 Offset: 0x2FB0720 VA: 0x2FB4720
	public void .ctor(ListDictionaryInternal list) { }

	// RVA: 0x2FB48D4 Offset: 0x2FB08D4 VA: 0x2FB48D4 Slot: 8
	public object get_Current() { }

	// RVA: 0x2FB4938 Offset: 0x2FB0938 VA: 0x2FB4938 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x2FB49D0 Offset: 0x2FB09D0 VA: 0x2FB49D0 Slot: 4
	public object get_Key() { }

	// RVA: 0x2FB4A30 Offset: 0x2FB0A30 VA: 0x2FB4A30 Slot: 5
	public object get_Value() { }

	// RVA: 0x2FB4A90 Offset: 0x2FB0A90 VA: 0x2FB4A90 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x2FB4B54 Offset: 0x2FB0B54 VA: 0x2FB4B54 Slot: 9
	public void Reset() { }
}
