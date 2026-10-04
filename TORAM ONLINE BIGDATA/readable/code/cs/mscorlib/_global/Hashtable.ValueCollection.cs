// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 10902
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x2FC1960 Offset: 0x2FBD960 VA: 0x2FC1960
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x2FC2D90 Offset: 0x2FBED90 VA: 0x2FC2D90 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FC2F0C Offset: 0x2FBEF0C VA: 0x2FC2F0C Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FC2F6C Offset: 0x2FBEF6C VA: 0x2FC2F6C Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FC2F90 Offset: 0x2FBEF90 VA: 0x2FC2F90 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FC2FB4 Offset: 0x2FBEFB4 VA: 0x2FC2FB4 Slot: 13
	public virtual int get_Count() { }
}
