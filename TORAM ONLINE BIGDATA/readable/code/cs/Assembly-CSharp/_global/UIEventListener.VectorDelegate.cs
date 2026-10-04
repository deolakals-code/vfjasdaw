// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.VectorDelegate : MulticastDelegate // TypeDefIndex: 85
{
	// Methods

	// RVA: 0x1725730 Offset: 0x1721730 VA: 0x1725730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734C74 Offset: 0x1730C74 VA: 0x1734C74 Slot: 12
	public virtual void Invoke(GameObject go, Vector2 delta) { }

	// RVA: 0x1734C88 Offset: 0x1730C88 VA: 0x1734C88 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, Vector2 delta, AsyncCallback callback, object object) { }

	// RVA: 0x1734D1C Offset: 0x1730D1C VA: 0x1734D1C Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
