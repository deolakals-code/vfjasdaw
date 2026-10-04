// Assembly: mscorlib.dll
// Namespace: System.Security
[MonoTODO("CAS support is experimental (and unsupported).")]
[ComVisible(True)]
[Serializable]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 10071
{
	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x2EA2E20 Offset: 0x2E9EE20 VA: 0x2EA2E20
	internal void .ctor() { }

	// RVA: 0x2EA2F0C Offset: 0x2E9EF0C VA: 0x2EA2F0C
	public void .ctor(PermissionState state) { }

	// RVA: 0x2EA2AEC Offset: 0x2E9EAEC VA: 0x2EA2AEC
	internal void .ctor(IPermission perm) { }

	// RVA: 0x2EA37A4 Offset: 0x2E9F7A4 VA: 0x2EA37A4 Slot: 11
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x2EA390C Offset: 0x2E9F90C VA: 0x2EA390C Slot: 12
	public void Demand() { }

	// RVA: 0x2EA2B38 Offset: 0x2E9EB38 VA: 0x2EA2B38
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x2EA3EF0 Offset: 0x2E9FEF0 VA: 0x2EA3EF0 Slot: 9
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2EA3B44 Offset: 0x2E9FB44 VA: 0x2EA3B44
	public bool IsEmpty() { }

	// RVA: 0x2EA3EE0 Offset: 0x2E9FEE0 VA: 0x2EA3EE0
	public bool IsUnrestricted() { }

	// RVA: 0x2EA3F14 Offset: 0x2E9FF14 VA: 0x2EA3F14 Slot: 3
	public override string ToString() { }

	// RVA: 0x2EA30A4 Offset: 0x2E9F0A4 VA: 0x2EA30A4 Slot: 13
	public virtual SecurityElement ToXml() { }

	// RVA: 0x2EA3F40 Offset: 0x2E9FF40 VA: 0x2EA3F40 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x2EA3F64 Offset: 0x2E9FF64 VA: 0x2EA3F64 Slot: 15
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2EA3F88 Offset: 0x2E9FF88 VA: 0x2EA3F88 Slot: 16
	public virtual object get_SyncRoot() { }

	[MonoTODO("may not be required")]
	// RVA: 0x2EA3F8C Offset: 0x2E9FF8C VA: 0x2EA3F8C Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisible(False)]
	// RVA: 0x2EA358C Offset: 0x2E9F58C VA: 0x2EA358C Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x2EA3760 Offset: 0x2E9F760 VA: 0x2EA3760 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2EA3F90 Offset: 0x2E9FF90 VA: 0x2EA3F90
	private static void .cctor() { }
}
