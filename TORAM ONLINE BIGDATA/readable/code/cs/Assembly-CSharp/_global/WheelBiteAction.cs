// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WheelBiteAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 2741
{
	// Fields
	public const int TakeId = 202008000;
	private const float avoidMoveTime = 1;
	private const float attackMoveTime = 0.1;
	private int skillRate; // 0x120
	private int constantDamage; // 0x124
	private bool isAvoidSuccess; // 0x128
	private bool checkAvoid; // 0x129
	private MobActionManagerBase targetAction; // 0x130
	private SkillCalcTemplate damageTemplate; // 0x138

	// Properties
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x22508E8 Offset: 0x224C8E8 VA: 0x22508E8 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x22508F0 Offset: 0x224C8F0 VA: 0x22508F0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22508F8 Offset: 0x224C8F8 VA: 0x22508F8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2250900 Offset: 0x224C900 VA: 0x2250900 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2250908 Offset: 0x224C908 VA: 0x2250908 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2250910 Offset: 0x224C910 VA: 0x2250910 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2250918 Offset: 0x224C918 VA: 0x2250918 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2250920 Offset: 0x224C920 VA: 0x2250920 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2250928 Offset: 0x224C928 VA: 0x2250928 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2250930 Offset: 0x224C930 VA: 0x2250930 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x2250938 Offset: 0x224C938 VA: 0x2250938 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2250A30 Offset: 0x224CA30 VA: 0x2250A30 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2250ED4 Offset: 0x224CED4 VA: 0x2250ED4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2250EE8 Offset: 0x224CEE8 VA: 0x2250EE8 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2250FD4 Offset: 0x224CFD4 VA: 0x2250FD4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x225125C Offset: 0x224D25C VA: 0x225125C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2251438 Offset: 0x224D438 VA: 0x2251438 Slot: 52
	public override void ActionSkillUpdateAppendParam(CharacterActionManagerBase actarAction, Func<TakeParameterType, int, bool> updateAppendParam, int param) { }

	// RVA: 0x22516DC Offset: 0x224D6DC VA: 0x22516DC Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22518C8 Offset: 0x224D8C8 VA: 0x22518C8
	public static void Damaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2251990 Offset: 0x224D990 VA: 0x2251990
	private void DamageAvoid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2251B24 Offset: 0x224DB24 VA: 0x2251B24
	private void RecalcAvoidDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2251DC4 Offset: 0x224DDC4 VA: 0x2251DC4
	public void .ctor() { }
}
