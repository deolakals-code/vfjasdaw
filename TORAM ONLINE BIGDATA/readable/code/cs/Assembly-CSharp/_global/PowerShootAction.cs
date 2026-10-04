// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PowerShootAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 3009
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int tumblePercent; // 0x128
	private int crtUpRate; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsMotionSpeedVariable { get; }

	// Methods

	// RVA: 0x22FF480 Offset: 0x22FB480 VA: 0x22FF480 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22FF488 Offset: 0x22FB488 VA: 0x22FF488 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22FF490 Offset: 0x22FB490 VA: 0x22FF490 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22FF498 Offset: 0x22FB498 VA: 0x22FF498 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22FF4A0 Offset: 0x22FB4A0 VA: 0x22FF4A0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22FF4A8 Offset: 0x22FB4A8 VA: 0x22FF4A8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22FF4B0 Offset: 0x22FB4B0 VA: 0x22FF4B0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22FF4B8 Offset: 0x22FB4B8 VA: 0x22FF4B8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22FF4C0 Offset: 0x22FB4C0 VA: 0x22FF4C0 Slot: 74
	protected override bool get_IsMotionSpeedVariable() { }

	// RVA: 0x22FF4C8 Offset: 0x22FB4C8 VA: 0x22FF4C8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22FF720 Offset: 0x22FB720 VA: 0x22FF720 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22FF8DC Offset: 0x22FB8DC VA: 0x22FF8DC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22FF960 Offset: 0x22FB960 VA: 0x22FF960 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22FFD88 Offset: 0x22FBD88 VA: 0x22FFD88 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22FFDEC Offset: 0x22FBDEC VA: 0x22FFDEC
	public void .ctor() { }
}
