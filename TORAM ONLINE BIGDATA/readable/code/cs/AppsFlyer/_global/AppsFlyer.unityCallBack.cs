// Assembly: AppsFlyer.dll
// Namespace: 
public sealed class AppsFlyer.unityCallBack : MulticastDelegate // TypeDefIndex: 17284
{
	// Methods

	// RVA: 0x16F5300 Offset: 0x16F1300 VA: 0x16F5300
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F53B0 Offset: 0x16F13B0 VA: 0x16F53B0 Slot: 12
	public virtual void Invoke(string message) { }

	// RVA: 0x16F53C4 Offset: 0x16F13C4 VA: 0x16F53C4 Slot: 13
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x16F53E4 Offset: 0x16F13E4 VA: 0x16F53E4 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
