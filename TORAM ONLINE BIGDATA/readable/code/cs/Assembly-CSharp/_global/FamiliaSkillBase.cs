// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class FamiliaSkillBase : PlayerAttackBase // TypeDefIndex: 3359
{
	// Fields
	[CompilerGenerated]
	private bool <IsCastEnd>k__BackingField; // 0x120
	protected SkillActionBase baseSkill; // 0x128

	// Properties
	public bool IsFamilia { get; }
	public bool IsCastEnd { get; set; }

	// Methods

	// RVA: 0x234C4A0 Offset: 0x23484A0 VA: 0x234C4A0
	public bool get_IsFamilia() { }

	[CompilerGenerated]
	// RVA: 0x234C4A8 Offset: 0x23484A8 VA: 0x234C4A8
	public bool get_IsCastEnd() { }

	[CompilerGenerated]
	// RVA: 0x234C4B0 Offset: 0x23484B0 VA: 0x234C4B0
	protected void set_IsCastEnd(bool value) { }

	// RVA: 0x234BCF4 Offset: 0x2347CF4 VA: 0x234BCF4 Slot: 91
	public virtual void ReceiveSkillFlag(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x234C4BC Offset: 0x23484BC VA: 0x234C4BC
	public void SetCallSkill(SkillActionBase baseSkill) { }

	// RVA: 0x234C4CC Offset: 0x23484CC VA: 0x234C4CC
	public bool CheckBaseSkill(SkillActionBase skill) { }

	// RVA: 0x234ACCC Offset: 0x2346CCC VA: 0x234ACCC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x234A434 Offset: 0x2346434 VA: 0x234A434
	protected void .ctor() { }
}
