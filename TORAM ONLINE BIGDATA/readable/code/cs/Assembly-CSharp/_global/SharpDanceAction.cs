// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SharpDanceAction : PlayerAttackBase // TypeDefIndex: 3743
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23DA984 Offset: 0x23D6984 VA: 0x23DA984 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DA98C Offset: 0x23D698C VA: 0x23DA98C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DA994 Offset: 0x23D6994 VA: 0x23DA994 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DA99C Offset: 0x23D699C VA: 0x23DA99C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DA9A4 Offset: 0x23D69A4 VA: 0x23DA9A4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DA9AC Offset: 0x23D69AC VA: 0x23DA9AC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DA9B4 Offset: 0x23D69B4 VA: 0x23DA9B4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DA9BC Offset: 0x23D69BC VA: 0x23DA9BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DA9C4 Offset: 0x23D69C4 VA: 0x23DA9C4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DA9CC Offset: 0x23D69CC VA: 0x23DA9CC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DAB8C Offset: 0x23D6B8C VA: 0x23DAB8C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DACA4 Offset: 0x23D6CA4 VA: 0x23DACA4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DADB8 Offset: 0x23D6DB8 VA: 0x23DADB8
	public void .ctor() { }
}
