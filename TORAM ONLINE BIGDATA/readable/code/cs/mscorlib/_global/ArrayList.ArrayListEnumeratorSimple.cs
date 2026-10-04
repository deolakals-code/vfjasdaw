// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private sealed class ArrayList.ArrayListEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 10897
{
	// Fields
	private ArrayList _list; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20
	private bool _isArrayList; // 0x28
	private static object s_dummyObject; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x2FBCF28 Offset: 0x2FB8F28 VA: 0x2FBCF28
	internal void .ctor(ArrayList list) { }

	// RVA: 0x2FBFBEC Offset: 0x2FBBBEC VA: 0x2FBFBEC Slot: 7
	public object Clone() { }

	// RVA: 0x2FBFBF4 Offset: 0x2FBBBF4 VA: 0x2FBFBF4 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x2FBFDD0 Offset: 0x2FBBDD0 VA: 0x2FBFDD0 Slot: 5
	public object get_Current() { }

	// RVA: 0x2FBFE9C Offset: 0x2FBBE9C VA: 0x2FBFE9C Slot: 6
	public void Reset() { }

	// RVA: 0x2FBFF70 Offset: 0x2FBBF70 VA: 0x2FBFF70
	private static void .cctor() { }
}
