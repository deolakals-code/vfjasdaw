// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmokeDustAction : PlayerAttackBase, IAbnormalStateSkill, IDualElementSkill // TypeDefIndex: 3010
{
	// Fields
	[CompilerGenerated]
	private bool <IsValidDualElement>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private float bonusSkillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int blindnessPercent; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsValidDualElement { get; set; }

	// Methods

	// RVA: 0x22FFE04 Offset: 0x22FBE04 VA: 0x22FFE04 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22FFE0C Offset: 0x22FBE0C VA: 0x22FFE0C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22FFE14 Offset: 0x22FBE14 VA: 0x22FFE14 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22FFE1C Offset: 0x22FBE1C VA: 0x22FFE1C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22FFE24 Offset: 0x22FBE24 VA: 0x22FFE24 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22FFE2C Offset: 0x22FBE2C VA: 0x22FFE2C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22FFE34 Offset: 0x22FBE34 VA: 0x22FFE34 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22FFE3C Offset: 0x22FBE3C VA: 0x22FFE3C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22FFE44 Offset: 0x22FBE44 VA: 0x22FFE44 Slot: 92
	public bool get_IsValidDualElement() { }

	[CompilerGenerated]
	// RVA: 0x22FFE4C Offset: 0x22FBE4C VA: 0x22FFE4C
	private void set_IsValidDualElement(bool value) { }

	// RVA: 0x22FFE58 Offset: 0x22FBE58 VA: 0x22FFE58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23000DC Offset: 0x22FC0DC VA: 0x23000DC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2300190 Offset: 0x22FC190 VA: 0x2300190 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23005A4 Offset: 0x22FC5A4 VA: 0x23005A4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x230076C Offset: 0x22FC76C VA: 0x230076C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2300714 Offset: 0x22FC714 VA: 0x2300714
	public static float CalcBufferTime(PlayerStatusBase status) { }

	// RVA: 0x23007D0 Offset: 0x22FC7D0 VA: 0x23007D0
	public void .ctor() { }
}
