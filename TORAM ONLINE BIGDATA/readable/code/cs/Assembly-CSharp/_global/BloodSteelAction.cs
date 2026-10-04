// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BloodSteelAction : PlayerAttackBase // TypeDefIndex: 2876
{
	// Fields
	private int percent; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x22B9078 Offset: 0x22B5078 VA: 0x22B9078 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22B9080 Offset: 0x22B5080 VA: 0x22B9080 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22B9088 Offset: 0x22B5088 VA: 0x22B9088 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22B9090 Offset: 0x22B5090 VA: 0x22B9090 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22B9098 Offset: 0x22B5098 VA: 0x22B9098 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22B90A0 Offset: 0x22B50A0 VA: 0x22B90A0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22B90A8 Offset: 0x22B50A8 VA: 0x22B90A8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22B90B0 Offset: 0x22B50B0 VA: 0x22B90B0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22B90B8 Offset: 0x22B50B8 VA: 0x22B90B8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22B9238 Offset: 0x22B5238 VA: 0x22B9238 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22B92C0 Offset: 0x22B52C0 VA: 0x22B92C0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22B9470 Offset: 0x22B5470 VA: 0x22B9470 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22B95B4 Offset: 0x22B55B4 VA: 0x22B95B4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22B9618 Offset: 0x22B5618 VA: 0x22B9618
	public void .ctor() { }
}
