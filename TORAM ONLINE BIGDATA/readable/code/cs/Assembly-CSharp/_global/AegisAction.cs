// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AegisAction : PlayerAttackBase // TypeDefIndex: 3607
{
	// Fields
	private int mp; // 0x120

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23AB37C Offset: 0x23A737C VA: 0x23AB37C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23AB384 Offset: 0x23A7384 VA: 0x23AB384 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23AB38C Offset: 0x23A738C VA: 0x23AB38C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23AB394 Offset: 0x23A7394 VA: 0x23AB394 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23AB39C Offset: 0x23A739C VA: 0x23AB39C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23AB3A4 Offset: 0x23A73A4 VA: 0x23AB3A4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23AB3AC Offset: 0x23A73AC VA: 0x23AB3AC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23AB3B4 Offset: 0x23A73B4 VA: 0x23AB3B4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23AB3BC Offset: 0x23A73BC VA: 0x23AB3BC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23AB3C4 Offset: 0x23A73C4 VA: 0x23AB3C4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23AB5F0 Offset: 0x23A75F0 VA: 0x23AB5F0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23AB6C0 Offset: 0x23A76C0 VA: 0x23AB6C0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23AB8B0 Offset: 0x23A78B0 VA: 0x23AB8B0
	public void .ctor() { }
}
