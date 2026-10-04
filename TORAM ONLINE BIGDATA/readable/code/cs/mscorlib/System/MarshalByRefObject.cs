// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
[Serializable]
public abstract class MarshalByRefObject // TypeDefIndex: 9799
{
	// Fields
	private object _identity; // 0x10

	// Properties
	internal ServerIdentity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x302A3B0 Offset: 0x30263B0 VA: 0x302A3B0
	protected void .ctor() { }

	// RVA: 0x3031204 Offset: 0x302D204 VA: 0x3031204
	internal ServerIdentity get_ObjectIdentity() { }

	// RVA: 0x303123C Offset: 0x302D23C VA: 0x303123C
	internal void set_ObjectIdentity(ServerIdentity value) { }

	// RVA: 0x3031274 Offset: 0x302D274 VA: 0x3031274 Slot: 4
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x30312AC Offset: 0x302D2AC VA: 0x30312AC Slot: 5
	public virtual object InitializeLifetimeService() { }
}
