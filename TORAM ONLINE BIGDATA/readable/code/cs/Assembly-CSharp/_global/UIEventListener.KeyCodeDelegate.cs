// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.KeyCodeDelegate : MulticastDelegate // TypeDefIndex: 88
{
	// Methods

	// RVA: 0x1734F20 Offset: 0x1730F20 VA: 0x1734F20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734FD4 Offset: 0x1730FD4 VA: 0x1734FD4 Slot: 12
	public virtual void Invoke(GameObject go, KeyCode key) { }

	// RVA: 0x1734FE8 Offset: 0x1730FE8 VA: 0x1734FE8 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, KeyCode key, AsyncCallback callback, object object) { }

	// RVA: 0x173507C Offset: 0x173107C VA: 0x173507C Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
