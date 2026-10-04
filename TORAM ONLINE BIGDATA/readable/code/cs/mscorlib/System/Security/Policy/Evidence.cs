// Assembly: mscorlib.dll
// Namespace: System.Security.Policy
[MonoTODO("Serialization format not compatible with .NET")]
[ComVisible(True)]
[Serializable]
public sealed class Evidence : ICollection, IEnumerable // TypeDefIndex: 10088
{
	// Fields
	private bool _locked; // 0x10
	private ArrayList hostEvidenceList; // 0x18
	private ArrayList assemblyEvidenceList; // 0x20

	// Properties
	[Obsolete]
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x2EA7E9C Offset: 0x2EA3E9C VA: 0x2EA7E9C
	public void .ctor() { }

	// RVA: 0x2EA7EA4 Offset: 0x2EA3EA4 VA: 0x2EA7EA4 Slot: 5
	public int get_Count() { }

	// RVA: 0x2EA7F00 Offset: 0x2EA3F00 VA: 0x2EA7F00 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x2EA7F08 Offset: 0x2EA3F08 VA: 0x2EA7F08 Slot: 6
	public object get_SyncRoot() { }

	[Obsolete]
	// RVA: 0x2EA7F0C Offset: 0x2EA3F0C VA: 0x2EA7F0C Slot: 4
	public void CopyTo(Array array, int index) { }

	[Obsolete]
	// RVA: 0x2EA7FD0 Offset: 0x2EA3FD0 VA: 0x2EA7FD0 Slot: 8
	public IEnumerator GetEnumerator() { }
}
