// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnipingAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3011
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int breakingPercent; // 0x128

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

	// RVA: 0x23007E8 Offset: 0x22FC7E8 VA: 0x23007E8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23007F0 Offset: 0x22FC7F0 VA: 0x23007F0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23007F8 Offset: 0x22FC7F8 VA: 0x23007F8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2300800 Offset: 0x22FC800 VA: 0x2300800 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2300808 Offset: 0x22FC808 VA: 0x2300808 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2300810 Offset: 0x22FC810 VA: 0x2300810 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2300818 Offset: 0x22FC818 VA: 0x2300818 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2300820 Offset: 0x22FC820 VA: 0x2300820 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2300828 Offset: 0x22FC828 VA: 0x2300828 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2300AB0 Offset: 0x22FCAB0 VA: 0x2300AB0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2300CA4 Offset: 0x22FCCA4 VA: 0x2300CA4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2300D28 Offset: 0x22FCD28 VA: 0x2300D28 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2301134 Offset: 0x22FD134 VA: 0x2301134 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2301198 Offset: 0x22FD198 VA: 0x2301198
	public void .ctor() { }
}
