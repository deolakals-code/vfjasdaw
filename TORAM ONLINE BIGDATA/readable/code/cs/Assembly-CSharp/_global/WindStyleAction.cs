// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WindStyleAction : NinjaSkillBase // TypeDefIndex: 2931
{
	// Fields
	private const int AttackTakeId = 202082000;
	private int baseMp; // 0x124
	private float skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private bool change; // 0x130
	private bool moveJump; // 0x131
	private float attackRange; // 0x134
	private Transform otherTransform; // 0x138
	private byte invincibilityLocalId; // 0x140
	private bool isGemCart; // 0x141
	private int magicResist; // 0x144

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
	public override SkillChargingType ChargingType { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool NoCost { get; }
	public bool IsChangeSkill { get; }

	// Methods

	// RVA: 0x22D5C64 Offset: 0x22D1C64 VA: 0x22D5C64 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22D5C6C Offset: 0x22D1C6C VA: 0x22D5C6C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22D5C74 Offset: 0x22D1C74 VA: 0x22D5C74 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22D5C7C Offset: 0x22D1C7C VA: 0x22D5C7C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22D5C84 Offset: 0x22D1C84 VA: 0x22D5C84 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22D5C8C Offset: 0x22D1C8C VA: 0x22D5C8C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22D5C94 Offset: 0x22D1C94 VA: 0x22D5C94 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22D5C9C Offset: 0x22D1C9C VA: 0x22D5C9C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22D5CA4 Offset: 0x22D1CA4 VA: 0x22D5CA4 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x22D5D10 Offset: 0x22D1D10 VA: 0x22D5D10 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x22D5D18 Offset: 0x22D1D18 VA: 0x22D5D18 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22D5D20 Offset: 0x22D1D20 VA: 0x22D5D20 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22D5D28 Offset: 0x22D1D28 VA: 0x22D5D28
	public bool get_IsChangeSkill() { }

	// RVA: 0x22D5D30 Offset: 0x22D1D30 VA: 0x22D5D30 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22D5F64 Offset: 0x22D1F64 VA: 0x22D5F64 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22D6168 Offset: 0x22D2168 VA: 0x22D6168 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22D6504 Offset: 0x22D2504 VA: 0x22D6504 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22D672C Offset: 0x22D272C VA: 0x22D672C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22D6B30 Offset: 0x22D2B30 VA: 0x22D6B30 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22D6FCC Offset: 0x22D2FCC VA: 0x22D6FCC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22D722C Offset: 0x22D322C VA: 0x22D722C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22D74F4 Offset: 0x22D34F4 VA: 0x22D74F4 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x22D625C Offset: 0x22D225C VA: 0x22D625C
	private void CreateTake(bool neutral, Vector3 dir) { }

	// RVA: 0x22D7BA0 Offset: 0x22D3BA0 VA: 0x22D7BA0
	public void .ctor() { }
}
