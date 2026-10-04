// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HolyGraceAction : PlayerAttackBase // TypeDefIndex: 3681
{
	// Fields
	private float actionRange; // 0x120

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

	// RVA: 0x23C3FE4 Offset: 0x23BFFE4 VA: 0x23C3FE4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C3FEC Offset: 0x23BFFEC VA: 0x23C3FEC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C3FF4 Offset: 0x23BFFF4 VA: 0x23C3FF4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C3FFC Offset: 0x23BFFFC VA: 0x23C3FFC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C4004 Offset: 0x23C0004 VA: 0x23C4004 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C400C Offset: 0x23C000C VA: 0x23C400C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C4014 Offset: 0x23C0014 VA: 0x23C4014 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C401C Offset: 0x23C001C VA: 0x23C401C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C4024 Offset: 0x23C0024 VA: 0x23C4024 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C402C Offset: 0x23C002C VA: 0x23C402C Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23C4034 Offset: 0x23C0034 VA: 0x23C4034 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C4170 Offset: 0x23C0170 VA: 0x23C4170 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23C41FC Offset: 0x23C01FC VA: 0x23C41FC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C43F8 Offset: 0x23C03F8 VA: 0x23C43F8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C44B0 Offset: 0x23C04B0 VA: 0x23C44B0
	public static bool CheckPursuitAttack(PlayerAttackBase skill, PlayerActionManagerBase playerAction) { }

	// RVA: 0x23C4568 Offset: 0x23C0568 VA: 0x23C4568
	public void .ctor() { }
}
