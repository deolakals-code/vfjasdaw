// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuickLoaderAction : PlayerAttackBase // TypeDefIndex: 3731
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23D6EC0 Offset: 0x23D2EC0 VA: 0x23D6EC0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D6EC8 Offset: 0x23D2EC8 VA: 0x23D6EC8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D6ED0 Offset: 0x23D2ED0 VA: 0x23D6ED0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D6ED8 Offset: 0x23D2ED8 VA: 0x23D6ED8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D6EE0 Offset: 0x23D2EE0 VA: 0x23D6EE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D6EE8 Offset: 0x23D2EE8 VA: 0x23D6EE8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D6EF0 Offset: 0x23D2EF0 VA: 0x23D6EF0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D6EF8 Offset: 0x23D2EF8 VA: 0x23D6EF8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D6F00 Offset: 0x23D2F00 VA: 0x23D6F00 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D6F08 Offset: 0x23D2F08 VA: 0x23D6F08 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D7028 Offset: 0x23D3028 VA: 0x23D7028 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D7048 Offset: 0x23D3048 VA: 0x23D7048 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D7398 Offset: 0x23D3398 VA: 0x23D7398 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D7450 Offset: 0x23D3450 VA: 0x23D7450
	public void .ctor() { }
}
