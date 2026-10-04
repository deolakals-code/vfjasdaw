// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.FloatDelegate : MulticastDelegate // TypeDefIndex: 84
{
	// Methods

	// RVA: 0x1734B0C Offset: 0x1730B0C VA: 0x1734B0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734BC0 Offset: 0x1730BC0 VA: 0x1734BC0 Slot: 12
	public virtual void Invoke(GameObject go, float delta) { }

	// RVA: 0x1734BD4 Offset: 0x1730BD4 VA: 0x1734BD4 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, float delta, AsyncCallback callback, object object) { }

	// RVA: 0x1734C68 Offset: 0x1730C68 VA: 0x1734C68 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
