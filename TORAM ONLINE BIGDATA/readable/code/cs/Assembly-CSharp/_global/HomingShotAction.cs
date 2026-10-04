// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HomingShotAction : PlayerAttackBase // TypeDefIndex: 2703
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int hitPercent; // 0x128
	private List<Transform> arrowEffectList; // 0x130
	private Transform targetRoot; // 0x138
	private bool isBowgunHunter; // 0x140
	private byte arrowNum; // 0x141
	private int currentArrowNum; // 0x144
	private bool exp; // 0x148

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x223D508 Offset: 0x2239508 VA: 0x223D508 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223D510 Offset: 0x2239510 VA: 0x223D510 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223D518 Offset: 0x2239518 VA: 0x223D518 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223D520 Offset: 0x2239520 VA: 0x223D520 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223D528 Offset: 0x2239528 VA: 0x223D528 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223D530 Offset: 0x2239530 VA: 0x223D530 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223D538 Offset: 0x2239538 VA: 0x223D538 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223D540 Offset: 0x2239540 VA: 0x223D540 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223D548 Offset: 0x2239548 VA: 0x223D548 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x223D550 Offset: 0x2239550 VA: 0x223D550 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223D8D4 Offset: 0x22398D4 VA: 0x223D8D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223DBD8 Offset: 0x2239BD8 VA: 0x223DBD8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223DCCC Offset: 0x2239CCC VA: 0x223DCCC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223DDC0 Offset: 0x2239DC0 VA: 0x223DDC0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223E220 Offset: 0x223A220 VA: 0x223E220 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223E240 Offset: 0x223A240 VA: 0x223E240 Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x223E3FC Offset: 0x223A3FC VA: 0x223E3FC Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223E5AC Offset: 0x223A5AC VA: 0x223E5AC Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x223E664 Offset: 0x223A664 VA: 0x223E664
	public void RotationEvent() { }

	// RVA: 0x223EB98 Offset: 0x223AB98 VA: 0x223EB98
	public void ExpDefFluctuated() { }

	// RVA: 0x223EBA0 Offset: 0x223ABA0 VA: 0x223EBA0
	public void .ctor() { }
}
