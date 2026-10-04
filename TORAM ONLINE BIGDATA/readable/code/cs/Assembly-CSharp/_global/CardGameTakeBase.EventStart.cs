// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class CardGameTakeBase.EventStart : MulticastDelegate // TypeDefIndex: 4252
{
	// Methods

	// RVA: 0x24B942C Offset: 0x24B542C VA: 0x24B942C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B94C8 Offset: 0x24B54C8 VA: 0x24B94C8 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x24B94DC Offset: 0x24B54DC VA: 0x24B94DC Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x24B94FC Offset: 0x24B54FC VA: 0x24B94FC Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
