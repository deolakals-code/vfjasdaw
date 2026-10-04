// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class SkillActionManagerBase.SkillActionHandler : MulticastDelegate // TypeDefIndex: 356
{
	// Methods

	// RVA: 0x247FEAC Offset: 0x247BEAC VA: 0x247FEAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x248BB34 Offset: 0x2487B34 VA: 0x248BB34 Slot: 12
	public virtual void Invoke(GameObject target, SkillActionBase action) { }

	// RVA: 0x248BB48 Offset: 0x2487B48 VA: 0x248BB48 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject target, SkillActionBase action, AsyncCallback callback, object object) { }

	// RVA: 0x248BB70 Offset: 0x2487B70 VA: 0x248BB70 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
