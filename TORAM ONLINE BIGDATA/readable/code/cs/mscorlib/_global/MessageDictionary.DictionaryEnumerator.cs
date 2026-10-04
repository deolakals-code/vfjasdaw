// Assembly: mscorlib.dll
// Namespace: 
private class MessageDictionary.DictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 10312
{
	// Fields
	private MessageDictionary _methodDictionary; // 0x10
	private IDictionaryEnumerator _hashtableEnum; // 0x18
	private int _posMethod; // 0x20

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2EF62C8 Offset: 0x2EF22C8 VA: 0x2EF62C8
	public void .ctor(MessageDictionary methodDictionary) { }

	// RVA: 0x2EF6424 Offset: 0x2EF2424 VA: 0x2EF6424 Slot: 8
	public object get_Current() { }

	// RVA: 0x2EF65F0 Offset: 0x2EF25F0 VA: 0x2EF65F0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x2EF67BC Offset: 0x2EF27BC VA: 0x2EF67BC Slot: 9
	public void Reset() { }

	// RVA: 0x2EF6488 Offset: 0x2EF2488 VA: 0x2EF6488 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x2EF6868 Offset: 0x2EF2868 VA: 0x2EF6868 Slot: 4
	public object get_Key() { }

	// RVA: 0x2EF686C Offset: 0x2EF286C VA: 0x2EF686C Slot: 5
	public object get_Value() { }
}
