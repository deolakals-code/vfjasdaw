// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class SpringPosition.OnFinished : MulticastDelegate // TypeDefIndex: 130
{
	// Methods

	// RVA: 0x1EDECE0 Offset: 0x1EDACE0 VA: 0x1EDECE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDEDE8 Offset: 0x1EDADE8 VA: 0x1EDEDE8 Slot: 12
	public virtual void Invoke(SpringPosition spring) { }

	// RVA: 0x1EDEDFC Offset: 0x1EDADFC VA: 0x1EDEDFC Slot: 13
	public virtual IAsyncResult BeginInvoke(SpringPosition spring, AsyncCallback callback, object object) { }

	// RVA: 0x1EDEE1C Offset: 0x1EDAE1C VA: 0x1EDEE1C Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
