// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.BoolDelegate : MulticastDelegate // TypeDefIndex: 83
{
	// Methods

	// RVA: 0x172567C Offset: 0x172167C VA: 0x172567C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734A50 Offset: 0x1730A50 VA: 0x1734A50 Slot: 12
	public virtual void Invoke(GameObject go, bool state) { }

	// RVA: 0x1734A68 Offset: 0x1730A68 VA: 0x1734A68 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, bool state, AsyncCallback callback, object object) { }

	// RVA: 0x1734B00 Offset: 0x1730B00 VA: 0x1734B00 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
