// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WrapAroundAction : PlayerAttackBase // TypeDefIndex: 3059
{
	// Fields
	private int mp; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMove { get; }

	// Methods

	// RVA: 0x231C288 Offset: 0x2318288 VA: 0x231C288 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x231C290 Offset: 0x2318290 VA: 0x231C290 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x231C298 Offset: 0x2318298 VA: 0x231C298 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x231C2A0 Offset: 0x23182A0 VA: 0x231C2A0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x231C2A8 Offset: 0x23182A8 VA: 0x231C2A8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x231C2B0 Offset: 0x23182B0 VA: 0x231C2B0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x231C2B8 Offset: 0x23182B8 VA: 0x231C2B8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x231C2C0 Offset: 0x23182C0 VA: 0x231C2C0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x231C2C8 Offset: 0x23182C8 VA: 0x231C2C8 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x231C2D0 Offset: 0x23182D0 VA: 0x231C2D0 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x231C2D8 Offset: 0x23182D8 VA: 0x231C2D8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x231C4C4 Offset: 0x23184C4 VA: 0x231C4C4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231C69C Offset: 0x231869C VA: 0x231C69C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x231C8BC Offset: 0x23188BC VA: 0x231C8BC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x231C8C0 Offset: 0x23188C0 VA: 0x231C8C0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x231CA3C Offset: 0x2318A3C VA: 0x231CA3C
	public void .ctor() { }
}
