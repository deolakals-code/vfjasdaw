// Assembly: mscorlib.dll
// Namespace: 
private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 10228
{
	// Methods

	// RVA: 0x2EE348C Offset: 0x2EDF48C VA: 0x2EE348C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2EE37D0 Offset: 0x2EDF7D0 VA: 0x2EE37D0 Slot: 12
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x2EE3594 Offset: 0x2EDF594 VA: 0x2EE3594 Slot: 13
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x2EE37A8 Offset: 0x2EDF7A8 VA: 0x2EE37A8 Slot: 14
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }
}
