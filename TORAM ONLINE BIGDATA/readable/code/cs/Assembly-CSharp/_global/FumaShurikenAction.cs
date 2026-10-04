// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FumaShurikenAction : NinjaSkillBase // TypeDefIndex: 2912
{
	// Fields
	private int baseMp; // 0x124
	private float skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private float range; // 0x130
	private int attackUpCount; // 0x134
	private bool hit; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override SkillChargingType ChargingType { get; }
	protected override bool IsRangeSkillBonus { get; }
	protected override bool IsRangeEquipBonus { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22CDAF0 Offset: 0x22C9AF0 VA: 0x22CDAF0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22CDAF8 Offset: 0x22C9AF8 VA: 0x22CDAF8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22CDB00 Offset: 0x22C9B00 VA: 0x22CDB00 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22CDB08 Offset: 0x22C9B08 VA: 0x22CDB08 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22CDB10 Offset: 0x22C9B10 VA: 0x22CDB10 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22CDB18 Offset: 0x22C9B18 VA: 0x22CDB18 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22CDB20 Offset: 0x22C9B20 VA: 0x22CDB20 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22CDB28 Offset: 0x22C9B28 VA: 0x22CDB28 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22CDB30 Offset: 0x22C9B30 VA: 0x22CDB30 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x22CDB38 Offset: 0x22C9B38 VA: 0x22CDB38 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22CDB40 Offset: 0x22C9B40 VA: 0x22CDB40 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x22CDB48 Offset: 0x22C9B48 VA: 0x22CDB48 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22CDB50 Offset: 0x22C9B50 VA: 0x22CDB50 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CDDAC Offset: 0x22C9DAC VA: 0x22CDDAC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CDF10 Offset: 0x22C9F10 VA: 0x22CDF10 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22CDF28 Offset: 0x22C9F28 VA: 0x22CDF28 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22CDF2C Offset: 0x22C9F2C VA: 0x22CDF2C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22CE02C Offset: 0x22CA02C VA: 0x22CE02C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22CE314 Offset: 0x22CA314 VA: 0x22CE314 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x22CE344 Offset: 0x22CA344 VA: 0x22CE344 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22CE3C0 Offset: 0x22CA3C0 VA: 0x22CE3C0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22CDDC8 Offset: 0x22C9DC8 VA: 0x22CDDC8
	private void CreateTake() { }

	// RVA: 0x22CE65C Offset: 0x22CA65C VA: 0x22CE65C
	public void .ctor() { }
}
