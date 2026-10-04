// Assembly: Assembly-CSharp.dll
// Namespace: OldSong
public class FairySongAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 9137
{
	// Fields
	private byte song_buff_lv; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x1EB1508 Offset: 0x1EAD508 VA: 0x1EB1508 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1EB1510 Offset: 0x1EAD510 VA: 0x1EB1510 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x1EB1518 Offset: 0x1EAD518 VA: 0x1EB1518 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x1EB1520 Offset: 0x1EAD520 VA: 0x1EB1520 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x1EB1528 Offset: 0x1EAD528 VA: 0x1EB1528 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1EB1530 Offset: 0x1EAD530 VA: 0x1EB1530 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1EB1538 Offset: 0x1EAD538 VA: 0x1EB1538 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1EB1540 Offset: 0x1EAD540 VA: 0x1EB1540 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1EB1548 Offset: 0x1EAD548 VA: 0x1EB1548 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1EB1550 Offset: 0x1EAD550 VA: 0x1EB1550 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1EB1558 Offset: 0x1EAD558 VA: 0x1EB1558 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x1EB1560 Offset: 0x1EAD560 VA: 0x1EB1560 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1EB17B4 Offset: 0x1EAD7B4 VA: 0x1EB17B4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x1EB1954 Offset: 0x1EAD954 VA: 0x1EB1954 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1EB1A50 Offset: 0x1EADA50 VA: 0x1EB1A50 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1EB1A58 Offset: 0x1EADA58 VA: 0x1EB1A58 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x1EB1C3C Offset: 0x1EADC3C VA: 0x1EB1C3C
	public void .ctor() { }
}
