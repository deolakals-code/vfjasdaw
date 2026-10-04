// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoDeviceAction : PlayerAttackBase // TypeDefIndex: 3023
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x230779C Offset: 0x230379C VA: 0x230779C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23077A4 Offset: 0x23037A4 VA: 0x23077A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23077AC Offset: 0x23037AC VA: 0x23077AC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23077B4 Offset: 0x23037B4 VA: 0x23077B4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23077BC Offset: 0x23037BC VA: 0x23077BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23077C4 Offset: 0x23037C4 VA: 0x23077C4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23077CC Offset: 0x23037CC VA: 0x23077CC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23077D4 Offset: 0x23037D4 VA: 0x23077D4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23077DC Offset: 0x23037DC VA: 0x23077DC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23077E4 Offset: 0x23037E4 VA: 0x23077E4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23078FC Offset: 0x23038FC VA: 0x23078FC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23079B4 Offset: 0x23039B4 VA: 0x23079B4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2307B84 Offset: 0x2303B84 VA: 0x2307B84
	public void .ctor() { }
}
