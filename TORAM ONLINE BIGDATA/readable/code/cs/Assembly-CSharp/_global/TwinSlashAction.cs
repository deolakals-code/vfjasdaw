// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TwinSlashAction : PlayerAttackBase // TypeDefIndex: 2654
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private float crtDamageRate; // 0x128

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

	// RVA: 0x22239A4 Offset: 0x221F9A4 VA: 0x22239A4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22239AC Offset: 0x221F9AC VA: 0x22239AC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22239B4 Offset: 0x221F9B4 VA: 0x22239B4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22239BC Offset: 0x221F9BC VA: 0x22239BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22239C4 Offset: 0x221F9C4 VA: 0x22239C4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22239CC Offset: 0x221F9CC VA: 0x22239CC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22239D4 Offset: 0x221F9D4 VA: 0x22239D4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22239DC Offset: 0x221F9DC VA: 0x22239DC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22239E4 Offset: 0x221F9E4 VA: 0x22239E4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2223B78 Offset: 0x221FB78 VA: 0x2223B78 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2223C40 Offset: 0x221FC40 VA: 0x2223C40 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2223D08 Offset: 0x221FD08 VA: 0x2223D08 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2223F90 Offset: 0x221FF90 VA: 0x2223F90
	public void .ctor() { }
}
