// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChargingAction : PlayerAttackBase, IChronosShift, IInheritMindimageSenju // TypeDefIndex: 3628
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private ChargingAction lastUsedSkill; // 0x128

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
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23B2DFC Offset: 0x23AEDFC VA: 0x23B2DFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B2E04 Offset: 0x23AEE04 VA: 0x23B2E04 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B2E0C Offset: 0x23AEE0C VA: 0x23B2E0C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B2E14 Offset: 0x23AEE14 VA: 0x23B2E14 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B2E1C Offset: 0x23AEE1C VA: 0x23B2E1C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B2E24 Offset: 0x23AEE24 VA: 0x23B2E24 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B2E2C Offset: 0x23AEE2C VA: 0x23B2E2C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B2E34 Offset: 0x23AEE34 VA: 0x23B2E34 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B2E3C Offset: 0x23AEE3C VA: 0x23B2E3C Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x23B2E44 Offset: 0x23AEE44 VA: 0x23B2E44 Slot: 93
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23B2E4C Offset: 0x23AEE4C VA: 0x23B2E4C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23B2E58 Offset: 0x23AEE58 VA: 0x23B2E58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B3210 Offset: 0x23AF210 VA: 0x23B3210 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B32E0 Offset: 0x23AF2E0 VA: 0x23B32E0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x23B33B8 Offset: 0x23AF3B8 VA: 0x23B33B8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B3488 Offset: 0x23AF488 VA: 0x23B3488 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23B366C Offset: 0x23AF66C VA: 0x23B366C Slot: 91
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x23B33F0 Offset: 0x23AF3F0 VA: 0x23B33F0 Slot: 92
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x23B372C Offset: 0x23AF72C VA: 0x23B372C Slot: 94
	public void OnInheritance() { }

	// RVA: 0x23B2FD4 Offset: 0x23AEFD4 VA: 0x23B2FD4
	public static float CalcChargingCastTime(PlayerActionManagerBase playerAction, byte level) { }

	// RVA: 0x23B3738 Offset: 0x23AF738 VA: 0x23B3738
	public void .ctor() { }
}
