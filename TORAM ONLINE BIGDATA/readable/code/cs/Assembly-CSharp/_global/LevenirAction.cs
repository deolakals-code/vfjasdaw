// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LevenirAction : PlayerAttackBase // TypeDefIndex: 2749
{
	// Fields
	private const int MaxAddAttackCount = 2;
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int maxAttackCount; // 0x128
	private ItemDBData.ItemType subWeaponType; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x2254EF0 Offset: 0x2250EF0 VA: 0x2254EF0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2254EF8 Offset: 0x2250EF8 VA: 0x2254EF8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2254F00 Offset: 0x2250F00 VA: 0x2254F00 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2254F08 Offset: 0x2250F08 VA: 0x2254F08 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2254F10 Offset: 0x2250F10 VA: 0x2254F10 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2254F18 Offset: 0x2250F18 VA: 0x2254F18 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2254F20 Offset: 0x2250F20 VA: 0x2254F20 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2254F28 Offset: 0x2250F28 VA: 0x2254F28 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2254F30 Offset: 0x2250F30 VA: 0x2254F30 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2254F38 Offset: 0x2250F38 VA: 0x2254F38 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x225516C Offset: 0x225116C VA: 0x225516C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2255230 Offset: 0x2251230 VA: 0x2255230 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x225556C Offset: 0x225156C VA: 0x225556C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22558A8 Offset: 0x22518A8 VA: 0x22558A8
	public static void AbnormalStack(AbnormalType type, GameObject actor) { }

	// RVA: 0x2255BD0 Offset: 0x2251BD0 VA: 0x2255BD0
	public static void Damaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2255DC4 Offset: 0x2251DC4 VA: 0x2255DC4
	public void .ctor() { }
}
