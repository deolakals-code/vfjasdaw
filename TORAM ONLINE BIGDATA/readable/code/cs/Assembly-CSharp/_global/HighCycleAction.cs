// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighCycleAction : PlayerAttackBase // TypeDefIndex: 3676
{
	// Fields
	private int range; // 0x120
	private Vector3 checkPos; // 0x124

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

	// RVA: 0x23C1FFC Offset: 0x23BDFFC VA: 0x23C1FFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C2004 Offset: 0x23BE004 VA: 0x23C2004 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C200C Offset: 0x23BE00C VA: 0x23C200C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C2014 Offset: 0x23BE014 VA: 0x23C2014 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C201C Offset: 0x23BE01C VA: 0x23C201C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C2024 Offset: 0x23BE024 VA: 0x23C2024 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C202C Offset: 0x23BE02C VA: 0x23C202C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C2034 Offset: 0x23BE034 VA: 0x23C2034 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C203C Offset: 0x23BE03C VA: 0x23C203C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C2044 Offset: 0x23BE044 VA: 0x23C2044 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C2210 Offset: 0x23BE210 VA: 0x23C2210 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C22E0 Offset: 0x23BE2E0 VA: 0x23C22E0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C23B4 Offset: 0x23BE3B4 VA: 0x23C23B4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23C2430 Offset: 0x23BE430 VA: 0x23C2430
	public void .ctor() { }
}
