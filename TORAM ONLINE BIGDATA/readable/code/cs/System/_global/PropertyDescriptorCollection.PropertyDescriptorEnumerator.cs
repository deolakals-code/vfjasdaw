// Assembly: System.dll
// Namespace: 
private class PropertyDescriptorCollection.PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 14223
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x34AFF28 Offset: 0x34ABF28 VA: 0x34AFF28
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x34B0B58 Offset: 0x34ACB58 VA: 0x34B0B58 Slot: 8
	public object get_Current() { }

	// RVA: 0x34B0BBC Offset: 0x34ACBBC VA: 0x34B0BBC Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x34B0C24 Offset: 0x34ACC24 VA: 0x34B0C24 Slot: 4
	public object get_Key() { }

	// RVA: 0x34B0C60 Offset: 0x34ACC60 VA: 0x34B0C60 Slot: 5
	public object get_Value() { }

	// RVA: 0x34B0C9C Offset: 0x34ACC9C VA: 0x34B0C9C Slot: 7
	public bool MoveNext() { }

	// RVA: 0x34B0CD8 Offset: 0x34ACCD8 VA: 0x34B0CD8 Slot: 9
	public void Reset() { }
}
