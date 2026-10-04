// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TwinBusterBladeAction : PlayerAttackBase // TypeDefIndex: 2653
{
	// Fields
	private const int MaxRengekiAttackCount = 4;
	private float firstSkillRate; // 0x120
	private int firstFixAddDamage; // 0x124
	private float secondSkillRate; // 0x128
	private int secondFixAddDamage; // 0x12C
	private Vector3 attackStartPos; // 0x130
	private Vector3 attackStartDir; // 0x13C
	private Dictionary<CharacterActionManagerBase, int> targetExpList; // 0x148
	private bool lineAttack; // 0x150
	private float lineAttackRange; // 0x154
	private float lineAttackWidth; // 0x158
	private Transform targetTransform; // 0x160
	private bool isExorcism; // 0x168
	private int maxDebufCount; // 0x16C
	private int debufCount; // 0x170

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

	// Methods

	// RVA: 0x2221B44 Offset: 0x221DB44 VA: 0x2221B44 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2221B4C Offset: 0x221DB4C VA: 0x2221B4C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2221B54 Offset: 0x221DB54 VA: 0x2221B54 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2221B5C Offset: 0x221DB5C VA: 0x2221B5C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2221B64 Offset: 0x221DB64 VA: 0x2221B64 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2221B6C Offset: 0x221DB6C VA: 0x2221B6C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2221B74 Offset: 0x221DB74 VA: 0x2221B74 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2221B7C Offset: 0x221DB7C VA: 0x2221B7C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2221B84 Offset: 0x221DB84 VA: 0x2221B84 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2221B8C Offset: 0x221DB8C VA: 0x2221B8C Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2221B94 Offset: 0x221DB94 VA: 0x2221B94 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2221D30 Offset: 0x221DD30 VA: 0x2221D30 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2221F08 Offset: 0x221DF08 VA: 0x2221F08 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2222058 Offset: 0x221E058 VA: 0x2222058 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x222273C Offset: 0x221E73C VA: 0x222273C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2222874 Offset: 0x221E874 VA: 0x2222874 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22229E0 Offset: 0x221E9E0 VA: 0x22229E0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2222FD8 Offset: 0x221EFD8 VA: 0x2222FD8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22236A8 Offset: 0x221F6A8 VA: 0x22236A8
	public void .ctor() { }
}
