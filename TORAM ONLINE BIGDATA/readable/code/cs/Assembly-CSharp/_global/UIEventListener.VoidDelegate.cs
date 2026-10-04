// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.VoidDelegate : MulticastDelegate // TypeDefIndex: 82
{
	// Methods

	// RVA: 0x1734960 Offset: 0x1730960 VA: 0x1734960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734A10 Offset: 0x1730A10 VA: 0x1734A10 Slot: 12
	public virtual void Invoke(GameObject go) { }

	// RVA: 0x1734A24 Offset: 0x1730A24 VA: 0x1734A24 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

	// RVA: 0x1734A44 Offset: 0x1730A44 VA: 0x1734A44 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
