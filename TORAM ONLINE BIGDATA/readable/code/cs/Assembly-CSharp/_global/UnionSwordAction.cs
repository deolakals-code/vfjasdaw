// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UnionSwordAction : PlayerAttackBase // TypeDefIndex: 2762
{
	// Fields
	private bool conversion; // 0x120
	private float firstSkillRate; // 0x124
	private int firstConstantDamage; // 0x128
	private float firstAttackRange; // 0x12C
	private float secondSkillRate; // 0x130
	private float secondConstantDamage; // 0x134
	private float secondAttackRange; // 0x138
	private bool derivation; // 0x13C
	private bool isReUnionSword; // 0x13D
	private GameObject mainTarget; // 0x140
	private Vector3 effectEndPos; // 0x148
	private bool isCasting; // 0x154

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override string LocalizeKey { get; }

	// Methods

	// RVA: 0x225C7EC Offset: 0x22587EC VA: 0x225C7EC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225C800 Offset: 0x2258800 VA: 0x225C800 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x225C808 Offset: 0x2258808 VA: 0x225C808 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225C810 Offset: 0x2258810 VA: 0x225C810 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x225C818 Offset: 0x2258818 VA: 0x225C818 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x225C820 Offset: 0x2258820 VA: 0x225C820 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x225C828 Offset: 0x2258828 VA: 0x225C828 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x225C830 Offset: 0x2258830 VA: 0x225C830 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x225C838 Offset: 0x2258838 VA: 0x225C838 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x225C8A4 Offset: 0x22588A4 VA: 0x225C8A4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x225CA3C Offset: 0x2258A3C VA: 0x225CA3C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225D050 Offset: 0x2259050 VA: 0x225D050 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x225DBB8 Offset: 0x2259BB8 VA: 0x225DBB8 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x225DBD8 Offset: 0x2259BD8 VA: 0x225DBD8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x225DC54 Offset: 0x2259C54 VA: 0x225DC54 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x225DD80 Offset: 0x2259D80 VA: 0x225DD80 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x225E398 Offset: 0x225A398 VA: 0x225E398 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x225E7CC Offset: 0x225A7CC VA: 0x225E7CC
	public bool CheckCasting() { }

	// RVA: 0x225E7D4 Offset: 0x225A7D4 VA: 0x225E7D4
	public static void Damaged(PlayerStatusBase status, SkillDamageData damageData) { }

	// RVA: 0x225E8A0 Offset: 0x225A8A0 VA: 0x225E8A0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x225E8B4 Offset: 0x225A8B4 VA: 0x225E8B4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225EC08 Offset: 0x225AC08 VA: 0x225EC08 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x225ED48 Offset: 0x225AD48 VA: 0x225ED48 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x225EF20 Offset: 0x225AF20 VA: 0x225EF20
	public void .ctor() { }
}
