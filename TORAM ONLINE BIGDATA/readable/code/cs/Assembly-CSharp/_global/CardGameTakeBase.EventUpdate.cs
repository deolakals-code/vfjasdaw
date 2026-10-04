// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class CardGameTakeBase.EventUpdate : MulticastDelegate // TypeDefIndex: 4253
{
	// Methods

	// RVA: 0x24B9508 Offset: 0x24B5508 VA: 0x24B9508
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B95B8 Offset: 0x24B55B8 VA: 0x24B95B8 Slot: 12
	public virtual void Invoke(Action callback) { }

	// RVA: 0x24B95CC Offset: 0x24B55CC VA: 0x24B95CC Slot: 13
	public virtual IAsyncResult BeginInvoke(Action callback, AsyncCallback __callback, object object) { }

	// RVA: 0x24B95EC Offset: 0x24B55EC VA: 0x24B95EC Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
