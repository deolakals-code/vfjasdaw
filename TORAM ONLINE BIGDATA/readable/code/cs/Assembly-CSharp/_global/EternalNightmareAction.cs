// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EternalNightmareAction : PlayerAttackBase, IPlaceSkill // TypeDefIndex: 3647
{
	// Fields
	[CompilerGenerated]
	private bool <UpperLimit>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <Duplicate>k__BackingField; // 0x121
	private float range; // 0x124

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
	public override bool IsSupportChangeEndTiming { get; }
	public bool UpperLimit { get; set; }
	public bool Duplicate { get; set; }

	// Methods

	// RVA: 0x23B8DA0 Offset: 0x23B4DA0 VA: 0x23B8DA0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B8DA8 Offset: 0x23B4DA8 VA: 0x23B8DA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B8DB0 Offset: 0x23B4DB0 VA: 0x23B8DB0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B8DB8 Offset: 0x23B4DB8 VA: 0x23B8DB8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B8DC0 Offset: 0x23B4DC0 VA: 0x23B8DC0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B8DC8 Offset: 0x23B4DC8 VA: 0x23B8DC8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B8DD0 Offset: 0x23B4DD0 VA: 0x23B8DD0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B8DD8 Offset: 0x23B4DD8 VA: 0x23B8DD8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B8DE0 Offset: 0x23B4DE0 VA: 0x23B8DE0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B8DE8 Offset: 0x23B4DE8 VA: 0x23B8DE8 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	[CompilerGenerated]
	// RVA: 0x23B8DF0 Offset: 0x23B4DF0 VA: 0x23B8DF0 Slot: 91
	public bool get_UpperLimit() { }

	[CompilerGenerated]
	// RVA: 0x23B8DF8 Offset: 0x23B4DF8 VA: 0x23B8DF8 Slot: 92
	public void set_UpperLimit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x23B8E04 Offset: 0x23B4E04 VA: 0x23B8E04 Slot: 93
	public bool get_Duplicate() { }

	[CompilerGenerated]
	// RVA: 0x23B8E0C Offset: 0x23B4E0C VA: 0x23B8E0C Slot: 94
	public void set_Duplicate(bool value) { }

	// RVA: 0x23B8E18 Offset: 0x23B4E18 VA: 0x23B8E18 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B8FA4 Offset: 0x23B4FA4 VA: 0x23B8FA4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B90C8 Offset: 0x23B50C8 VA: 0x23B90C8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B91C8 Offset: 0x23B51C8 VA: 0x23B91C8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23B92C0 Offset: 0x23B52C0 VA: 0x23B92C0
	public void .ctor() { }
}
