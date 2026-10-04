// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class EventDelegate.Callback : MulticastDelegate // TypeDefIndex: 70
{
	// Methods

	// RVA: 0x172625C Offset: 0x172225C VA: 0x172625C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x172B444 Offset: 0x1727444 VA: 0x172B444 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x172B458 Offset: 0x1727458 VA: 0x172B458 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x172B478 Offset: 0x1727478 VA: 0x172B478 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
