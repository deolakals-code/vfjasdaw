// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RepelBladeAction : PlayerAttackBase, ISwordMove // TypeDefIndex: 2855
{
	// Fields
	[CompilerGenerated]
	private bool <IsSwordMoveStart>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int hpHealRate; // 0x12C
	private SheatheMove sheatheMove; // 0x130
	private bool isDamage; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public bool IsSwordMoveStart { get; set; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x229C014 Offset: 0x2298014 VA: 0x229C014 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x229C01C Offset: 0x229801C VA: 0x229C01C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x229C024 Offset: 0x2298024 VA: 0x229C024 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x229C02C Offset: 0x229802C VA: 0x229C02C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x229C034 Offset: 0x2298034 VA: 0x229C034 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x229C03C Offset: 0x229803C VA: 0x229C03C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x229C044 Offset: 0x2298044 VA: 0x229C044 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x229C04C Offset: 0x229804C VA: 0x229C04C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	[CompilerGenerated]
	// RVA: 0x229C054 Offset: 0x2298054 VA: 0x229C054 Slot: 91
	public bool get_IsSwordMoveStart() { }

	[CompilerGenerated]
	// RVA: 0x229C05C Offset: 0x229805C VA: 0x229C05C
	private void set_IsSwordMoveStart(bool value) { }

	// RVA: 0x229C068 Offset: 0x2298068 VA: 0x229C068 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x229C080 Offset: 0x2298080 VA: 0x229C080 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x229C1D8 Offset: 0x22981D8 VA: 0x229C1D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x229C260 Offset: 0x2298260 VA: 0x229C260 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229C5B4 Offset: 0x22985B4 VA: 0x229C5B4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x229C8A4 Offset: 0x22988A4 VA: 0x229C8A4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x229CFB0 Offset: 0x2298FB0 VA: 0x229CFB0
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x229D3CC Offset: 0x22993CC VA: 0x229D3CC
	public static void ReceiveMobaDamaged(PlayerActionManagerBase playerAction, MobaMobResponseData responseData) { }

	// RVA: 0x229D7A4 Offset: 0x22997A4 VA: 0x229D7A4
	public void .ctor() { }
}
