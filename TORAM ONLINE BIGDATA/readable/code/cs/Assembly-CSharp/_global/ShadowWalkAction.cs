// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShadowWalkAction : PlayerAttackBase // TypeDefIndex: 3742
{
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
	public override bool IsOverlay { get; }

	// Methods

	// RVA: 0x23DA608 Offset: 0x23D6608 VA: 0x23DA608 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DA610 Offset: 0x23D6610 VA: 0x23DA610 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DA618 Offset: 0x23D6618 VA: 0x23DA618 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DA620 Offset: 0x23D6620 VA: 0x23DA620 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DA628 Offset: 0x23D6628 VA: 0x23DA628 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DA630 Offset: 0x23D6630 VA: 0x23DA630 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DA638 Offset: 0x23D6638 VA: 0x23DA638 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DA640 Offset: 0x23D6640 VA: 0x23DA640 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DA648 Offset: 0x23D6648 VA: 0x23DA648 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DA650 Offset: 0x23D6650 VA: 0x23DA650 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x23DA658 Offset: 0x23D6658 VA: 0x23DA658 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DA7B8 Offset: 0x23D67B8 VA: 0x23DA7B8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DA888 Offset: 0x23D6888 VA: 0x23DA888 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DA97C Offset: 0x23D697C VA: 0x23DA97C
	public void .ctor() { }
}
