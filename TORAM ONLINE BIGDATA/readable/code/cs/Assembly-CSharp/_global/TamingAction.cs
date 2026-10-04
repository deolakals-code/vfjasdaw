// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TamingAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3047
{
	// Fields
	private int mp; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x2315C50 Offset: 0x2311C50 VA: 0x2315C50 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2315C58 Offset: 0x2311C58 VA: 0x2315C58 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2315C60 Offset: 0x2311C60 VA: 0x2315C60 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2315C68 Offset: 0x2311C68 VA: 0x2315C68 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2315C70 Offset: 0x2311C70 VA: 0x2315C70 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2315C78 Offset: 0x2311C78 VA: 0x2315C78 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2315C80 Offset: 0x2311C80 VA: 0x2315C80 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2315C88 Offset: 0x2311C88 VA: 0x2315C88 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2315C90 Offset: 0x2311C90 VA: 0x2315C90 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2315DF0 Offset: 0x2311DF0 VA: 0x2315DF0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2315F30 Offset: 0x2311F30 VA: 0x2315F30 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23160B4 Offset: 0x23120B4 VA: 0x23160B4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2316118 Offset: 0x2312118 VA: 0x2316118
	public void .ctor() { }
}
