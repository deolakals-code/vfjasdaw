// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class UIInput.Validator : MulticastDelegate // TypeDefIndex: 163
{
	// Methods

	// RVA: 0x1FD4934 Offset: 0x1FD0934 VA: 0x1FD4934
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FD49E8 Offset: 0x1FD09E8 VA: 0x1FD49E8 Slot: 12
	public virtual char Invoke(string currentText, char nextChar) { }

	// RVA: 0x1FD49FC Offset: 0x1FD09FC VA: 0x1FD49FC Slot: 13
	public virtual IAsyncResult BeginInvoke(string currentText, char nextChar, AsyncCallback callback, object object) { }

	// RVA: 0x1FD4A90 Offset: 0x1FD0A90 VA: 0x1FD4A90 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }
}
