// Assembly: mscorlib.dll
// Namespace: 
private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 10736
{
	// Methods

	// RVA: 0x2F57214 Offset: 0x2F53214 VA: 0x2F57214
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2F58D00 Offset: 0x2F54D00 VA: 0x2F58D00 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x2F572C8 Offset: 0x2F532C8 VA: 0x2F572C8 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x2F574CC Offset: 0x2F534CC VA: 0x2F574CC Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }
}
