// Assembly: System.dll
// Namespace: 
private class OrderedDictionary.OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 14295
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x34D2224 Offset: 0x34CE224 VA: 0x34D2224
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x34D28A0 Offset: 0x34CE8A0 VA: 0x34D28A0 Slot: 8
	public object get_Current() { }

	// RVA: 0x34D2A64 Offset: 0x34CEA64 VA: 0x34D2A64 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x34D2BF8 Offset: 0x34CEBF8 VA: 0x34D2BF8 Slot: 4
	public object get_Key() { }

	// RVA: 0x34D2CDC Offset: 0x34CECDC VA: 0x34D2CDC Slot: 5
	public object get_Value() { }

	// RVA: 0x34D2DC0 Offset: 0x34CEDC0 VA: 0x34D2DC0 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x34D2E60 Offset: 0x34CEE60 VA: 0x34D2E60 Slot: 9
	public void Reset() { }
}
