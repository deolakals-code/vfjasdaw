// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 10904
{
	// Fields
	private Hashtable _hashtable; // 0x10
	private int _bucket; // 0x18
	private int _version; // 0x1C
	private bool _current; // 0x20
	private int _getObjectRetType; // 0x24
	private object _currentKey; // 0x28
	private object _currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x2FC1588 Offset: 0x2FBD588 VA: 0x2FC1588
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0x2FC3A04 Offset: 0x2FBFA04 VA: 0x2FC3A04 Slot: 10
	public object Clone() { }

	// RVA: 0x2FC3A0C Offset: 0x2FBFA0C VA: 0x2FC3A0C Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x2FC3A6C Offset: 0x2FBFA6C VA: 0x2FC3A6C Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x2FC3BBC Offset: 0x2FBFBBC VA: 0x2FC3BBC Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x2FC3C38 Offset: 0x2FBFC38 VA: 0x2FC3C38 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x2FC3D1C Offset: 0x2FBFD1C VA: 0x2FC3D1C Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x2FC3D7C Offset: 0x2FBFD7C VA: 0x2FC3D7C Slot: 16
	public virtual void Reset() { }
}
