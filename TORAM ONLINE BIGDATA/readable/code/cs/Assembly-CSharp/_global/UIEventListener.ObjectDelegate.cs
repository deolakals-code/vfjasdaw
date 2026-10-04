// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIEventListener.ObjectDelegate : MulticastDelegate // TypeDefIndex: 87
{
	// Methods

	// RVA: 0x1734E24 Offset: 0x1730E24 VA: 0x1734E24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734ED8 Offset: 0x1730ED8 VA: 0x1734ED8 Slot: 12
	public virtual void Invoke(GameObject go, GameObject draggedObject) { }

	// RVA: 0x1734EEC Offset: 0x1730EEC VA: 0x1734EEC Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject go, GameObject draggedObject, AsyncCallback callback, object object) { }

	// RVA: 0x1734F14 Offset: 0x1730F14 VA: 0x1734F14 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
