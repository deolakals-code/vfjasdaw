// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DragSlaveAction : PlayerAttackBase // TypeDefIndex: 2542
{
	// Fields
	private int mp; // 0x120
	private float skillRate; // 0x124
	private int constantDamage; // 0x128
	private int normalElementBonusRate; // 0x12C
	private bool first; // 0x130
	private ArchetypeUid archetypeUid; // 0x138
	private Transform attackTargetTransform; // 0x140
	private Vector3 attackPos; // 0x148
	private float attackRange; // 0x154
	private Dictionary<GameObject, int> targetMagicExpList; // 0x158
	private bool rotation; // 0x160
	private float defaultRotateSpeed; // 0x164
	private float rotateDelta; // 0x168
	private Quaternion targetRotate; // 0x16C
	private int breakPercent; // 0x17C

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsOverMp { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x21E9FA4 Offset: 0x21E5FA4 VA: 0x21E9FA4 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x21E9FAC Offset: 0x21E5FAC VA: 0x21E9FAC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E9FB4 Offset: 0x21E5FB4 VA: 0x21E9FB4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E9FBC Offset: 0x21E5FBC VA: 0x21E9FBC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E9FC4 Offset: 0x21E5FC4 VA: 0x21E9FC4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E9FCC Offset: 0x21E5FCC VA: 0x21E9FCC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E9FD4 Offset: 0x21E5FD4 VA: 0x21E9FD4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E9FDC Offset: 0x21E5FDC VA: 0x21E9FDC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E9FE4 Offset: 0x21E5FE4 VA: 0x21E9FE4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E9FEC Offset: 0x21E5FEC VA: 0x21E9FEC Slot: 24
	public override bool get_IsOverMp() { }

	// RVA: 0x21E9FF4 Offset: 0x21E5FF4 VA: 0x21E9FF4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x21E9FFC Offset: 0x21E5FFC VA: 0x21E9FFC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21EA55C Offset: 0x21E655C VA: 0x21EA55C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EA874 Offset: 0x21E6874 VA: 0x21EA874 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21EA994 Offset: 0x21E6994 VA: 0x21EA994 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EAB88 Offset: 0x21E6B88 VA: 0x21EAB88 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21EADFC Offset: 0x21E6DFC VA: 0x21EADFC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21EB1F4 Offset: 0x21E71F4 VA: 0x21EB1F4 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x21EB274 Offset: 0x21E7274 VA: 0x21EB274 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21EB850 Offset: 0x21E7850 VA: 0x21EB850
	public void .ctor() { }
}
