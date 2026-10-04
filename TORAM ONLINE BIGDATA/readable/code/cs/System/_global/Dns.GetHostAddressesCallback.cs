// Assembly: System.dll
// Namespace: 
private sealed class Dns.GetHostAddressesCallback : MulticastDelegate // TypeDefIndex: 14477
{
	// Methods

	// RVA: 0x350B1A0 Offset: 0x35071A0 VA: 0x350B1A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x350BE50 Offset: 0x3507E50 VA: 0x350BE50 Slot: 12
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x350B250 Offset: 0x3507250 VA: 0x350B250 Slot: 13
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x350B378 Offset: 0x3507378 VA: 0x350B378 Slot: 14
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }
}
