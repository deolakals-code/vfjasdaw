// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GoliathTakeShotAction : PlayerAttackBase // TypeDefIndex: 2594
{
	// Fields
	private int mp; // 0x120
	private float baseSkillRate; // 0x124
	private float chargeSkillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int chargeLevel; // 0x130
	private int maxChargeLevel; // 0x134
	private float range; // 0x138
	private SkillComboType chargeComboType; // 0x13C
	private int chargeComboRate; // 0x140
	private Transform target; // 0x148

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

	// RVA: 0x2205FF4 Offset: 0x2201FF4 VA: 0x2205FF4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2205FFC Offset: 0x2201FFC VA: 0x2205FFC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2206004 Offset: 0x2202004 VA: 0x2206004 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220600C Offset: 0x220200C VA: 0x220600C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2206014 Offset: 0x2202014 VA: 0x2206014 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220601C Offset: 0x220201C VA: 0x220601C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2206024 Offset: 0x2202024 VA: 0x2206024 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220602C Offset: 0x220202C VA: 0x220602C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2206034 Offset: 0x2202034 VA: 0x2206034 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2206260 Offset: 0x2202260 VA: 0x2206260 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220632C Offset: 0x220232C VA: 0x220632C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2206718 Offset: 0x2202718 VA: 0x2206718 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2206788 Offset: 0x2202788 VA: 0x2206788 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22068B8 Offset: 0x22028B8 VA: 0x22068B8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2206B40 Offset: 0x2202B40 VA: 0x2206B40 Slot: 78
	public override int CorrectComboRate() { }

	// RVA: 0x2206B4C Offset: 0x2202B4C VA: 0x2206B4C Slot: 79
	public override bool CheckComboAccept(SkillComboType comboType) { }

	// RVA: 0x2206B68 Offset: 0x2202B68 VA: 0x2206B68
	public static void ReceivedAbnormal(PlayerActionManagerBase playerAction, AbnormalType abnormalType, float effectTime) { }

	// RVA: 0x2206CA8 Offset: 0x2202CA8 VA: 0x2206CA8
	public static void EnemyDamage(PlayerActionManagerBase playerAction, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x2206E80 Offset: 0x2202E80 VA: 0x2206E80
	public void .ctor() { }
}
