// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 10901
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x2FC18AC Offset: 0x2FBD8AC VA: 0x2FC18AC
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x2FC2B50 Offset: 0x2FBEB50 VA: 0x2FC2B50 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FC2CCC Offset: 0x2FBECCC VA: 0x2FC2CCC Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FC2D2C Offset: 0x2FBED2C VA: 0x2FC2D2C Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FC2D50 Offset: 0x2FBED50 VA: 0x2FC2D50 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FC2D74 Offset: 0x2FBED74 VA: 0x2FC2D74 Slot: 13
	public virtual int get_Count() { }
}
