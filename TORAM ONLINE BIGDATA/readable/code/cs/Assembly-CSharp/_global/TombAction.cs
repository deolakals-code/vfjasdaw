// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TombAction : PlayerAttackBase // TypeDefIndex: 2901
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int pursuitRate; // 0x128
	private int pursuitFixDamage; // 0x12C
	private int abnormalPercent; // 0x130
	private Transform target; // 0x138
	private Dictionary<MobActionManagerBase, int> targetExpRegister; // 0x140
	private PlayerActionManagerBase playerAction; // 0x148

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

	// RVA: 0x22C754C Offset: 0x22C354C VA: 0x22C754C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22C7554 Offset: 0x22C3554 VA: 0x22C7554 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22C755C Offset: 0x22C355C VA: 0x22C755C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22C7564 Offset: 0x22C3564 VA: 0x22C7564 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22C756C Offset: 0x22C356C VA: 0x22C756C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22C7574 Offset: 0x22C3574 VA: 0x22C7574 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22C757C Offset: 0x22C357C VA: 0x22C757C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22C7584 Offset: 0x22C3584 VA: 0x22C7584 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22C758C Offset: 0x22C358C VA: 0x22C758C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C7720 Offset: 0x22C3720 VA: 0x22C7720 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22C7950 Offset: 0x22C3950 VA: 0x22C7950 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C7CA0 Offset: 0x22C3CA0 VA: 0x22C7CA0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C7D84 Offset: 0x22C3D84 VA: 0x22C7D84 Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22C7DB4 Offset: 0x22C3DB4 VA: 0x22C7DB4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22C7F68 Offset: 0x22C3F68 VA: 0x22C7F68 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22C84B0 Offset: 0x22C44B0 VA: 0x22C84B0 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22C8520 Offset: 0x22C4520 VA: 0x22C8520 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22C8584 Offset: 0x22C4584 VA: 0x22C8584
	public void .ctor() { }
}
