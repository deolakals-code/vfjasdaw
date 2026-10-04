// Assembly: mscorlib.dll
// Namespace: 
private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 10737
{
	// Methods

	// RVA: 0x2F57E6C Offset: 0x2F53E6C VA: 0x2F57E6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2F58D14 Offset: 0x2F54D14 VA: 0x2F58D14 Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F57F20 Offset: 0x2F53F20 VA: 0x2F57F20 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x2F58128 Offset: 0x2F54128 VA: 0x2F58128 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
