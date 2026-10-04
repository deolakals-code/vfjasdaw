// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ElegantStanceAction : PlayerAttackBase // TypeDefIndex: 3643
{
	// Fields
	private float timer; // 0x120
	private bool holdOff; // 0x124
	private const float HoldTime = 2;

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }

	// Methods

	// RVA: 0x23B74F0 Offset: 0x23B34F0 VA: 0x23B74F0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B74F8 Offset: 0x23B34F8 VA: 0x23B74F8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B7500 Offset: 0x23B3500 VA: 0x23B7500 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B7508 Offset: 0x23B3508 VA: 0x23B7508 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B7510 Offset: 0x23B3510 VA: 0x23B7510 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B7518 Offset: 0x23B3518 VA: 0x23B7518 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B7520 Offset: 0x23B3520 VA: 0x23B7520 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B7528 Offset: 0x23B3528 VA: 0x23B7528 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B7530 Offset: 0x23B3530 VA: 0x23B7530 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B7538 Offset: 0x23B3538 VA: 0x23B7538 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23B7540 Offset: 0x23B3540 VA: 0x23B7540 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B769C Offset: 0x23B369C VA: 0x23B769C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B775C Offset: 0x23B375C VA: 0x23B775C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23B7B70 Offset: 0x23B3B70 VA: 0x23B7B70 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x23B7C30 Offset: 0x23B3C30 VA: 0x23B7C30 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B7D68 Offset: 0x23B3D68 VA: 0x23B7D68 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23B7DEC Offset: 0x23B3DEC VA: 0x23B7DEC
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x23B7FA0 Offset: 0x23B3FA0 VA: 0x23B7FA0
	public void .ctor() { }
}
