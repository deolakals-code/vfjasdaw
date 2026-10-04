// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FearlessAction : PlayerAttackBase // TypeDefIndex: 3654
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23BAE94 Offset: 0x23B6E94 VA: 0x23BAE94 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BAE9C Offset: 0x23B6E9C VA: 0x23BAE9C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BAEA4 Offset: 0x23B6EA4 VA: 0x23BAEA4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BAEAC Offset: 0x23B6EAC VA: 0x23BAEAC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BAEB4 Offset: 0x23B6EB4 VA: 0x23BAEB4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BAEBC Offset: 0x23B6EBC VA: 0x23BAEBC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BAEC4 Offset: 0x23B6EC4 VA: 0x23BAEC4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BAECC Offset: 0x23B6ECC VA: 0x23BAECC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BAED4 Offset: 0x23B6ED4 VA: 0x23BAED4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BAEDC Offset: 0x23B6EDC VA: 0x23BAEDC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BAFDC Offset: 0x23B6FDC VA: 0x23BAFDC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BB060 Offset: 0x23B7060 VA: 0x23BB060 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BB220 Offset: 0x23B7220 VA: 0x23BB220
	public void .ctor() { }
}
