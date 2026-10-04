// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkullShakerAction : PlayerAttackBase // TypeDefIndex: 2894
{
	// Fields
	[CompilerGenerated]
	private bool <IsAvoidCancel>k__BackingField; // 0x120
	private int skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int dizzyPercent; // 0x12C
	private int stunPercent; // 0x130
	private MobActionManagerBase mobAction; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsAvoidCancel { get; set; }

	// Methods

	// RVA: 0x22BFE70 Offset: 0x22BBE70 VA: 0x22BFE70 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22BFE78 Offset: 0x22BBE78 VA: 0x22BFE78 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22BFE80 Offset: 0x22BBE80 VA: 0x22BFE80 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22BFE88 Offset: 0x22BBE88 VA: 0x22BFE88 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22BFE90 Offset: 0x22BBE90 VA: 0x22BFE90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22BFE98 Offset: 0x22BBE98 VA: 0x22BFE98 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22BFEA0 Offset: 0x22BBEA0 VA: 0x22BFEA0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22BFEA8 Offset: 0x22BBEA8 VA: 0x22BFEA8 Slot: 23
	public override int get_BaseMp() { }

	[CompilerGenerated]
	// RVA: 0x22BFEB0 Offset: 0x22BBEB0 VA: 0x22BFEB0
	public bool get_IsAvoidCancel() { }

	[CompilerGenerated]
	// RVA: 0x22BFEB8 Offset: 0x22BBEB8 VA: 0x22BFEB8
	private void set_IsAvoidCancel(bool value) { }

	// RVA: 0x22BFEC4 Offset: 0x22BBEC4 VA: 0x22BFEC4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C00FC Offset: 0x22BC0FC VA: 0x22C00FC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C027C Offset: 0x22BC27C VA: 0x22C027C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22C0340 Offset: 0x22BC340 VA: 0x22C0340 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22C092C Offset: 0x22BC92C VA: 0x22C092C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22C09A0 Offset: 0x22BC9A0 VA: 0x22C09A0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C0AE0 Offset: 0x22BCAE0 VA: 0x22C0AE0
	public static void ReceiveAttackResult(MobResponseData responseData) { }

	// RVA: 0x22C0C58 Offset: 0x22BCC58 VA: 0x22C0C58
	public void .ctor() { }
}
