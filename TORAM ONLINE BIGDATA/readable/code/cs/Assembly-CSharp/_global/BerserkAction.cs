// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BerserkAction : PlayerAttackBase // TypeDefIndex: 3621
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

	// RVA: 0x23B0844 Offset: 0x23AC844 VA: 0x23B0844 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B084C Offset: 0x23AC84C VA: 0x23B084C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B0854 Offset: 0x23AC854 VA: 0x23B0854 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B085C Offset: 0x23AC85C VA: 0x23B085C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B0864 Offset: 0x23AC864 VA: 0x23B0864 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B086C Offset: 0x23AC86C VA: 0x23B086C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B0874 Offset: 0x23AC874 VA: 0x23B0874 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B087C Offset: 0x23AC87C VA: 0x23B087C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B0884 Offset: 0x23AC884 VA: 0x23B0884 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B088C Offset: 0x23AC88C VA: 0x23B088C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B09B4 Offset: 0x23AC9B4 VA: 0x23B09B4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B0B24 Offset: 0x23ACB24 VA: 0x23B0B24 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B0BEC Offset: 0x23ACBEC VA: 0x23B0BEC
	public void .ctor() { }
}
