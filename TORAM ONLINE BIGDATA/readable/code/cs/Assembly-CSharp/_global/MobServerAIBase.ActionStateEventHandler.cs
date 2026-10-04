// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class MobServerAIBase.ActionStateEventHandler : MulticastDelegate // TypeDefIndex: 713
{
	// Methods

	// RVA: 0x1B8CBD0 Offset: 0x1B88BD0 VA: 0x1B8CBD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B8CC6C Offset: 0x1B88C6C VA: 0x1B8CC6C Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x1B8CC80 Offset: 0x1B88C80 VA: 0x1B8CC80 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1B8CCA0 Offset: 0x1B88CA0 VA: 0x1B8CCA0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
