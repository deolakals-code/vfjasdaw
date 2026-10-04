// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class CardGameTakeBase.EventEnd : MulticastDelegate // TypeDefIndex: 4254
{
	// Methods

	// RVA: 0x24B95F8 Offset: 0x24B55F8 VA: 0x24B95F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B9694 Offset: 0x24B5694 VA: 0x24B9694 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x24B96A8 Offset: 0x24B56A8 VA: 0x24B96A8 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x24B96C8 Offset: 0x24B56C8 VA: 0x24B96C8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
