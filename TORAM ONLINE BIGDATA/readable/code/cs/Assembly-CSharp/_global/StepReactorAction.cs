// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StepReactorAction : PlayerAttackBase, IInheritMindimageSenju // TypeDefIndex: 3754
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private bool equipDualSword; // 0x121

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
	public bool IsInheritance { get; set; }

	// Methods

	// RVA: 0x23DD9DC Offset: 0x23D99DC VA: 0x23DD9DC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DD9E4 Offset: 0x23D99E4 VA: 0x23DD9E4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DD9EC Offset: 0x23D99EC VA: 0x23DD9EC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DD9F4 Offset: 0x23D99F4 VA: 0x23DD9F4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DD9FC Offset: 0x23D99FC VA: 0x23DD9FC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DDA04 Offset: 0x23D9A04 VA: 0x23DDA04 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DDA0C Offset: 0x23D9A0C VA: 0x23DDA0C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DDA14 Offset: 0x23D9A14 VA: 0x23DDA14 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DDA1C Offset: 0x23D9A1C VA: 0x23DDA1C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x23DDA24 Offset: 0x23D9A24 VA: 0x23DDA24 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x23DDA2C Offset: 0x23D9A2C VA: 0x23DDA2C
	private void set_IsInheritance(bool value) { }

	// RVA: 0x23DDA38 Offset: 0x23D9A38 VA: 0x23DDA38 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DDBD0 Offset: 0x23D9BD0 VA: 0x23DDBD0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DDCA0 Offset: 0x23D9CA0 VA: 0x23DDCA0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DDD6C Offset: 0x23D9D6C VA: 0x23DDD6C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x23DDD78 Offset: 0x23D9D78 VA: 0x23DDD78
	public void .ctor() { }
}
