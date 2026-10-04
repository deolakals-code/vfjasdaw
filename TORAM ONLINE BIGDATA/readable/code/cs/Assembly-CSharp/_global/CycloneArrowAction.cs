// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CycloneArrowAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2698
{
	// Fields
	private float rad; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private GameObject skillTarget; // 0x130
	private SkillLinkedTake storm; // 0x138

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

	// RVA: 0x223A04C Offset: 0x223604C VA: 0x223A04C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223A054 Offset: 0x2236054 VA: 0x223A054 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223A05C Offset: 0x223605C VA: 0x223A05C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223A064 Offset: 0x2236064 VA: 0x223A064 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223A06C Offset: 0x223606C VA: 0x223A06C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223A074 Offset: 0x2236074 VA: 0x223A074 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223A07C Offset: 0x223607C VA: 0x223A07C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223A084 Offset: 0x2236084 VA: 0x223A084 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223A08C Offset: 0x223608C VA: 0x223A08C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223A370 Offset: 0x2236370 VA: 0x223A370 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223A4A8 Offset: 0x22364A8 VA: 0x223A4A8 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223A5A0 Offset: 0x22365A0 VA: 0x223A5A0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223A698 Offset: 0x2236698 VA: 0x223A698 Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x223A884 Offset: 0x2236884 VA: 0x223A884 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x223A9BC Offset: 0x22369BC VA: 0x223A9BC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223AEA8 Offset: 0x2236EA8 VA: 0x223AEA8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x223AF88 Offset: 0x2236F88 VA: 0x223AF88 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x223AFFC Offset: 0x2236FFC VA: 0x223AFFC
	public void .ctor() { }
}
