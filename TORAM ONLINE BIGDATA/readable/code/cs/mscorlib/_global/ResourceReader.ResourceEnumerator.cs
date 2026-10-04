// Assembly: mscorlib.dll
// Namespace: 
internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 10564
{
	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2F25CB0 Offset: 0x2F21CB0 VA: 0x2F25CB0
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0x2F242B4 Offset: 0x2F202B4 VA: 0x2F242B4 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x2F24204 Offset: 0x2F20204 VA: 0x2F24204 Slot: 4
	public object get_Key() { }

	// RVA: 0x2F28754 Offset: 0x2F24754 VA: 0x2F28754 Slot: 8
	public object get_Current() { }

	// RVA: 0x2F28AF8 Offset: 0x2F24AF8 VA: 0x2F28AF8
	internal int get_DataPosition() { }

	// RVA: 0x2F287B8 Offset: 0x2F247B8 VA: 0x2F287B8 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x2F28B00 Offset: 0x2F24B00 VA: 0x2F28B00 Slot: 5
	public object get_Value() { }

	// RVA: 0x2F28BA8 Offset: 0x2F24BA8 VA: 0x2F28BA8 Slot: 9
	public void Reset() { }
}
