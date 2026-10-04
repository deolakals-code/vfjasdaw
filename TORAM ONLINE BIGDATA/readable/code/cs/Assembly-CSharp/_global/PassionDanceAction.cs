// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PassionDanceAction : PlayerAttackBase // TypeDefIndex: 3719
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

	// RVA: 0x23D31D0 Offset: 0x23CF1D0 VA: 0x23D31D0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D31D8 Offset: 0x23CF1D8 VA: 0x23D31D8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D31E0 Offset: 0x23CF1E0 VA: 0x23D31E0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D31E8 Offset: 0x23CF1E8 VA: 0x23D31E8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D31F0 Offset: 0x23CF1F0 VA: 0x23D31F0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D31F8 Offset: 0x23CF1F8 VA: 0x23D31F8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D3200 Offset: 0x23CF200 VA: 0x23D3200 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D3208 Offset: 0x23CF208 VA: 0x23D3208 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D3210 Offset: 0x23CF210 VA: 0x23D3210 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D3218 Offset: 0x23CF218 VA: 0x23D3218 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D33D8 Offset: 0x23CF3D8 VA: 0x23D33D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D34F0 Offset: 0x23CF4F0 VA: 0x23D34F0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D3604 Offset: 0x23CF604 VA: 0x23D3604
	public void .ctor() { }
}
