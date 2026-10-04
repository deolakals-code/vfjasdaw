// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CrazyDaggerPursuitAction : PlayerAttackBase // TypeDefIndex: 2723
{
	// Fields
	private int skillRate; // 0x120
	private int damageCount; // 0x124
	private bool isDirectHit; // 0x128

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsSupport { get; }
	public override bool IsNoMotionTake { get; }
	protected override bool CheckBlank { get; }
	public bool IsDirectHit { get; }

	// Methods

	// RVA: 0x224B784 Offset: 0x2247784 VA: 0x224B784 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x224B78C Offset: 0x224778C VA: 0x224B78C Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x224B794 Offset: 0x2247794 VA: 0x224B794 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x224B79C Offset: 0x224779C VA: 0x224B79C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x224B7A4 Offset: 0x22477A4 VA: 0x224B7A4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x224B7AC Offset: 0x22477AC VA: 0x224B7AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x224B7B4 Offset: 0x22477B4 VA: 0x224B7B4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x224B7BC Offset: 0x22477BC VA: 0x224B7BC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x224B7C4 Offset: 0x22477C4 VA: 0x224B7C4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x224B7CC Offset: 0x22477CC VA: 0x224B7CC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x224B7D4 Offset: 0x22477D4 VA: 0x224B7D4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x224B7DC Offset: 0x22477DC VA: 0x224B7DC Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x224B7E4 Offset: 0x22477E4 VA: 0x224B7E4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x224B7EC Offset: 0x22477EC VA: 0x224B7EC Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x224B7F4 Offset: 0x22477F4 VA: 0x224B7F4 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x224B7FC Offset: 0x22477FC VA: 0x224B7FC
	public bool get_IsDirectHit() { }

	// RVA: 0x224B804 Offset: 0x2247804 VA: 0x224B804 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224BA98 Offset: 0x2247A98 VA: 0x224BA98 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224BB64 Offset: 0x2247B64 VA: 0x224BB64 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x224BC8C Offset: 0x2247C8C VA: 0x224BC8C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224C030 Offset: 0x2248030 VA: 0x224C030 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224C190 Offset: 0x2248190 VA: 0x224C190
	public void .ctor() { }
}
