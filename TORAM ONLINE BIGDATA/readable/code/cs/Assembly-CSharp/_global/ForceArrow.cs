// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ForceArrow : PlayerAttackBase // TypeDefIndex: 3658
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x23BBC9C Offset: 0x23B7C9C VA: 0x23BBC9C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BBCA4 Offset: 0x23B7CA4 VA: 0x23BBCA4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BBCAC Offset: 0x23B7CAC VA: 0x23BBCAC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BBCB4 Offset: 0x23B7CB4 VA: 0x23BBCB4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BBCBC Offset: 0x23B7CBC VA: 0x23BBCBC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BBCC4 Offset: 0x23B7CC4 VA: 0x23BBCC4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BBCCC Offset: 0x23B7CCC VA: 0x23BBCCC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BBCD4 Offset: 0x23B7CD4 VA: 0x23BBCD4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BBCDC Offset: 0x23B7CDC VA: 0x23BBCDC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BBCE4 Offset: 0x23B7CE4 VA: 0x23BBCE4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BBE18 Offset: 0x23B7E18 VA: 0x23BBE18 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BBEE8 Offset: 0x23B7EE8 VA: 0x23BBEE8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BC114 Offset: 0x23B8114 VA: 0x23BC114
	public void .ctor() { }
}
