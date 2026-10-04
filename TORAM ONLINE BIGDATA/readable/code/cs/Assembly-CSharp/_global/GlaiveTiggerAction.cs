// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GlaiveTiggerAction : PlayerAttackBase, IInstallationAreaSupportSkill // TypeDefIndex: 2884
{
	// Fields
	private Vector3 placePos; // 0x120
	private bool isNewPlace; // 0x12C

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public Vector3 PlacePos { get; }

	// Methods

	// RVA: 0x22BAD88 Offset: 0x22B6D88 VA: 0x22BAD88 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22BAD90 Offset: 0x22B6D90 VA: 0x22BAD90 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22BAD98 Offset: 0x22B6D98 VA: 0x22BAD98 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22BADA0 Offset: 0x22B6DA0 VA: 0x22BADA0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22BADA8 Offset: 0x22B6DA8 VA: 0x22BADA8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22BADB0 Offset: 0x22B6DB0 VA: 0x22BADB0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22BADB8 Offset: 0x22B6DB8 VA: 0x22BADB8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22BADC0 Offset: 0x22B6DC0 VA: 0x22BADC0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22BADC8 Offset: 0x22B6DC8 VA: 0x22BADC8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22BADD0 Offset: 0x22B6DD0 VA: 0x22BADD0
	public Vector3 get_PlacePos() { }

	// RVA: 0x22BADE0 Offset: 0x22B6DE0 VA: 0x22BADE0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22BB0A8 Offset: 0x22B70A8 VA: 0x22BB0A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22BB29C Offset: 0x22B729C VA: 0x22BB29C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22BB550 Offset: 0x22B7550 VA: 0x22BB550 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22BB5F4 Offset: 0x22B75F4 VA: 0x22BB5F4 Slot: 91
	public void SustainedSupport(CharacterActionManagerBase actarActionManager) { }

	// RVA: 0x22BBC04 Offset: 0x22B7C04 VA: 0x22BBC04
	public void .ctor() { }
}
