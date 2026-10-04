// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlashGrenadeAction : GolemGrenadeSkillBase, IAbnormalStateSkill // TypeDefIndex: 3362
{
	// Fields
	private int percent; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override int GrenadeEffectColor { get; }

	// Methods

	// RVA: 0x234F548 Offset: 0x234B548 VA: 0x234F548 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x234F550 Offset: 0x234B550 VA: 0x234F550 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x234F558 Offset: 0x234B558 VA: 0x234F558 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x234F560 Offset: 0x234B560 VA: 0x234F560 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x234F568 Offset: 0x234B568 VA: 0x234F568 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x234F570 Offset: 0x234B570 VA: 0x234F570 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x234F578 Offset: 0x234B578 VA: 0x234F578 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x234F580 Offset: 0x234B580 VA: 0x234F580 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x234F588 Offset: 0x234B588 VA: 0x234F588 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x234F590 Offset: 0x234B590 VA: 0x234F590 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x234F598 Offset: 0x234B598 VA: 0x234F598 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x234F5A0 Offset: 0x234B5A0 VA: 0x234F5A0 Slot: 91
	protected override int get_GrenadeEffectColor() { }

	// RVA: 0x234F5B0 Offset: 0x234B5B0 VA: 0x234F5B0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x234F80C Offset: 0x234B80C VA: 0x234F80C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x234FE40 Offset: 0x234BE40 VA: 0x234FE40 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23500F4 Offset: 0x234C0F4 VA: 0x23500F4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2350224 Offset: 0x234C224 VA: 0x2350224 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x235046C Offset: 0x234C46C VA: 0x235046C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x23504D0 Offset: 0x234C4D0 VA: 0x23504D0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2350520 Offset: 0x234C520 VA: 0x2350520 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23507F4 Offset: 0x234C7F4 VA: 0x23507F4
	public void .ctor() { }
}
