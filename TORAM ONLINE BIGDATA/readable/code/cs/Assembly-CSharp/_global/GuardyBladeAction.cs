// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuardyBladeAction : PlayerAttackBase // TypeDefIndex: 3667
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }

	// Methods

	// RVA: 0x23BEFF0 Offset: 0x23BAFF0 VA: 0x23BEFF0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BEFF8 Offset: 0x23BAFF8 VA: 0x23BEFF8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BF000 Offset: 0x23BB000 VA: 0x23BF000 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BF008 Offset: 0x23BB008 VA: 0x23BF008 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BF010 Offset: 0x23BB010 VA: 0x23BF010 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BF018 Offset: 0x23BB018 VA: 0x23BF018 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BF020 Offset: 0x23BB020 VA: 0x23BF020 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BF028 Offset: 0x23BB028 VA: 0x23BF028 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BF030 Offset: 0x23BB030 VA: 0x23BF030 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BF038 Offset: 0x23BB038 VA: 0x23BF038 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23BF040 Offset: 0x23BB040 VA: 0x23BF040 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BF134 Offset: 0x23BB134 VA: 0x23BF134 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BF284 Offset: 0x23BB284 VA: 0x23BF284 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BF304 Offset: 0x23BB304 VA: 0x23BF304
	public void .ctor() { }
}
