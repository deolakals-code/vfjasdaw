// Assembly: Assembly-CSharp.dll
// Namespace: 
public sealed class SkillActionManagerBase.SkillActionDamageHandler : MulticastDelegate // TypeDefIndex: 357
{
	// Methods

	// RVA: 0x247FFFC Offset: 0x247BFFC VA: 0x247FFFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x248BB7C Offset: 0x2487B7C VA: 0x248BB7C Slot: 12
	public virtual void Invoke(GameObject target, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x248BB90 Offset: 0x2487B90 VA: 0x248BB90 Slot: 13
	public virtual IAsyncResult BeginInvoke(GameObject target, SkillActionBase action, SkillDamageData damageData, AsyncCallback callback, object object) { }

	// RVA: 0x248BBBC Offset: 0x2487BBC VA: 0x248BBBC Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}
