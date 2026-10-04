// Assembly: mscorlib.dll
// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 10566
{
	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0x2F28C2C Offset: 0x2F24C2C VA: 0x2F28C2C
	protected void .ctor() { }

	// RVA: 0x2F22AB4 Offset: 0x2F1EAB4 VA: 0x2F22AB4
	internal void .ctor(bool junk) { }

	// RVA: 0x2F28C48 Offset: 0x2F24C48 VA: 0x2F28C48
	private void CommonInit() { }

	// RVA: 0x2F22E94 Offset: 0x2F1EE94 VA: 0x2F22E94 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2F28CA8 Offset: 0x2F24CA8 VA: 0x2F28CA8 Slot: 4
	public void Dispose() { }

	[ComVisible(False)]
	// RVA: 0x2F28CB8 Offset: 0x2F24CB8 VA: 0x2F28CB8 Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2F28D38 Offset: 0x2F24D38 VA: 0x2F28D38 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2F28CBC Offset: 0x2F24CBC VA: 0x2F28CBC
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x2F28D3C Offset: 0x2F24D3C VA: 0x2F28D3C Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0x2F28F64 Offset: 0x2F24F64 VA: 0x2F28F64 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0x2F29438 Offset: 0x2F25438 VA: 0x2F29438 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0x2F2943C Offset: 0x2F2543C VA: 0x2F2943C Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0x2F28E9C Offset: 0x2F24E9C VA: 0x2F28E9C
	private object GetObjectInternal(string name) { }

	// RVA: 0x2F29160 Offset: 0x2F25160 VA: 0x2F29160
	private object GetCaseInsensitiveObjectInternal(string name) { }
}
