// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParalysisShotAction : PlayerAttackBase, IAbnormalStateSkill, IDualElementSkill // TypeDefIndex: 3000
{
	// Fields
	[CompilerGenerated]
	private bool <IsValidDualElement>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private float bonusSkillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int paralysisPercent; // 0x130

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

	// RVA: 0x22FB1BC Offset: 0x22F71BC VA: 0x22FB1BC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22FB1C4 Offset: 0x22F71C4 VA: 0x22FB1C4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22FB1CC Offset: 0x22F71CC VA: 0x22FB1CC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22FB1D4 Offset: 0x22F71D4 VA: 0x22FB1D4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22FB1DC Offset: 0x22F71DC VA: 0x22FB1DC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22FB1E4 Offset: 0x22F71E4 VA: 0x22FB1E4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22FB1EC Offset: 0x22F71EC VA: 0x22FB1EC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22FB1F4 Offset: 0x22F71F4 VA: 0x22FB1F4 Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22FB1FC Offset: 0x22F71FC VA: 0x22FB1FC Slot: 92
	public bool get_IsValidDualElement() { }

	[CompilerGenerated]
	// RVA: 0x22FB204 Offset: 0x22F7204 VA: 0x22FB204
	private void set_IsValidDualElement(bool value) { }

	// RVA: 0x22FB210 Offset: 0x22F7210 VA: 0x22FB210 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22FB4A8 Offset: 0x22F74A8 VA: 0x22FB4A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22FB64C Offset: 0x22F764C VA: 0x22FB64C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22FBA60 Offset: 0x22F7A60 VA: 0x22FBA60 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22FBC28 Offset: 0x22F7C28 VA: 0x22FBC28 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22FBBD4 Offset: 0x22F7BD4 VA: 0x22FBBD4
	public static float CalcBufferTime(PlayerStatusBase status) { }

	// RVA: 0x22FBC8C Offset: 0x22F7C8C VA: 0x22FBC8C
	public void .ctor() { }
}
