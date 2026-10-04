// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class AssetBundleManager.AssetBundleDecryptHandler : MulticastDelegate // TypeDefIndex: 5437
{
	// Methods

	// RVA: 0x176CEF0 Offset: 0x1768EF0 VA: 0x176CEF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x176CFF8 Offset: 0x1768FF8 VA: 0x176CFF8 Slot: 12
	public virtual IEnumerator Invoke(AssetBundleManager.AssetBundleDecryptEventArgs arg) { }

	// RVA: 0x176D00C Offset: 0x176900C VA: 0x176D00C Slot: 13
	public virtual IAsyncResult BeginInvoke(AssetBundleManager.AssetBundleDecryptEventArgs arg, AsyncCallback callback, object object) { }

	// RVA: 0x176D02C Offset: 0x176902C VA: 0x176D02C Slot: 14
	public virtual IEnumerator EndInvoke(IAsyncResult result) { }
}
