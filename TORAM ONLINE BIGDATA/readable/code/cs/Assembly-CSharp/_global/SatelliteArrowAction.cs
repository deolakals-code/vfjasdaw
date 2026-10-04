// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SatelliteArrowAction : PlayerAttackBase // TypeDefIndex: 2708
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int resist; // 0x128
	private float rad; // 0x12C
	private int damageCount; // 0x130
	private const int attackWaitTime = 3;
	private GameObject targetObj; // 0x138
	private Vector3 targetPos; // 0x140
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x150

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

	// RVA: 0x22415B4 Offset: 0x223D5B4 VA: 0x22415B4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22415BC Offset: 0x223D5BC VA: 0x22415BC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22415C4 Offset: 0x223D5C4 VA: 0x22415C4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22415CC Offset: 0x223D5CC VA: 0x22415CC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22415D4 Offset: 0x223D5D4 VA: 0x22415D4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22415DC Offset: 0x223D5DC VA: 0x22415DC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22415E4 Offset: 0x223D5E4 VA: 0x22415E4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22415EC Offset: 0x223D5EC VA: 0x22415EC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22415F4 Offset: 0x223D5F4 VA: 0x22415F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22419EC Offset: 0x223D9EC VA: 0x22419EC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2241C7C Offset: 0x223DC7C VA: 0x2241C7C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22421B0 Offset: 0x223E1B0 VA: 0x22421B0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22424EC Offset: 0x223E4EC VA: 0x22424EC Slot: 42
	public override void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x22424FC Offset: 0x223E4FC VA: 0x22424FC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2242C80 Offset: 0x223EC80 VA: 0x2242C80 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2242C84 Offset: 0x223EC84 VA: 0x2242C84 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2243120 Offset: 0x223F120 VA: 0x2243120 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2243254 Offset: 0x223F254 VA: 0x2243254 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22432C4 Offset: 0x223F2C4 VA: 0x22432C4 Slot: 52
	public override void ActionSkillUpdateAppendParam(CharacterActionManagerBase actarAction, Func<TakeParameterType, int, bool> updateAppendParam, int param) { }

	// RVA: 0x22433E0 Offset: 0x223F3E0 VA: 0x22433E0
	public void .ctor() { }
}
