// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 9552
{
	// Methods

	// RVA: 0x2F73050 Offset: 0x2F6F050 VA: 0x2F73050
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2F73158 Offset: 0x2F6F158 VA: 0x2F73158 Slot: 12
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x2F7316C Offset: 0x2F6F16C VA: 0x2F7316C Slot: 13
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x2F7318C Offset: 0x2F6F18C VA: 0x2F7318C Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
