// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class NinjaSkillBase : PlayerAttackBase // TypeDefIndex: 3388
{
	// Fields
	[CompilerGenerated]
	private bool <IsNinjutsu>k__BackingField; // 0x120

	// Properties
	protected bool IsNinjutsu { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2356478 Offset: 0x2352478 VA: 0x2356478
	protected bool get_IsNinjutsu() { }

	[CompilerGenerated]
	// RVA: 0x2356480 Offset: 0x2352480 VA: 0x2356480
	private void set_IsNinjutsu(bool value) { }

	// RVA: 0x235648C Offset: 0x235248C VA: 0x235648C
	public void Ninjutsu(PlayerActionManagerBase playerAction, SkillActionBase action) { }

	// RVA: 0x23564F4 Offset: 0x23524F4 VA: 0x23564F4
	protected int CalcNinjaSkillBaseMp(int baseMp, PlayerActionManagerBase playerAction) { }

	// RVA: 0x23565BC Offset: 0x23525BC VA: 0x23565BC
	protected void CalcNinjaSkillCastTime(float baseCastTime, PlayerStatusBase status) { }

	// RVA: 0x23566C4 Offset: 0x23526C4 VA: 0x23566C4
	protected int GetNinko(PlayerStatusBase status) { }

	// RVA: 0x2356734 Offset: 0x2352734 VA: 0x2356734
	protected int GetNinjutsuTraining(PlayerStatusBase status) { }

	// RVA: 0x2356818 Offset: 0x2352818 VA: 0x2356818
	protected void .ctor() { }
}
