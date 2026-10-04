// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShieldBashAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2964
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int stunPercent; // 0x128

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

	// RVA: 0x22E9B7C Offset: 0x22E5B7C VA: 0x22E9B7C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E9B84 Offset: 0x22E5B84 VA: 0x22E9B84 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E9B8C Offset: 0x22E5B8C VA: 0x22E9B8C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E9B94 Offset: 0x22E5B94 VA: 0x22E9B94 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E9B9C Offset: 0x22E5B9C VA: 0x22E9B9C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E9BA4 Offset: 0x22E5BA4 VA: 0x22E9BA4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E9BAC Offset: 0x22E5BAC VA: 0x22E9BAC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E9BB4 Offset: 0x22E5BB4 VA: 0x22E9BB4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22E9BBC Offset: 0x22E5BBC VA: 0x22E9BBC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E9DC8 Offset: 0x22E5DC8 VA: 0x22E9DC8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E9E90 Offset: 0x22E5E90 VA: 0x22E9E90 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E9F14 Offset: 0x22E5F14 VA: 0x22E9F14 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22EA1E0 Offset: 0x22E61E0 VA: 0x22EA1E0 Slot: 89
	public override void CheckAbnormalSubEffect(AbnormalType abnormalType, GameObject actor) { }

	// RVA: 0x22EA324 Offset: 0x22E6324 VA: 0x22EA324 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22EA388 Offset: 0x22E6388 VA: 0x22EA388
	public void .ctor() { }
}
