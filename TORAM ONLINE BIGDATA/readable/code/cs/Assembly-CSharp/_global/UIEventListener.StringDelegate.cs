// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.StringDelegate : MulticastDelegate // TypeDefIndex: 86
{
	// Methods

	// RVA: 0x1734D28 Offset: 0x1730D28 VA: 0x1734D28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734DDC Offset: 0x1730DDC VA: 0x1734DDC Slot: 12
	public virtual void Invoke(GameObject go, string text) { }

	// RVA: 0x1734DF0 Offset: 0x1730DF0 VA: 0x1734DF0 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, string text, AsyncCallback callback, object object) { }

	// RVA: 0x1734E18 Offset: 0x1730E18 VA: 0x1734E18 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
