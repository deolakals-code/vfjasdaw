// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuickMotionAction : PlayerAttackBase // TypeDefIndex: 3732
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

	// RVA: 0x23D7578 Offset: 0x23D3578 VA: 0x23D7578 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D7580 Offset: 0x23D3580 VA: 0x23D7580 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D7588 Offset: 0x23D3588 VA: 0x23D7588 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D7590 Offset: 0x23D3590 VA: 0x23D7590 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D7598 Offset: 0x23D3598 VA: 0x23D7598 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D75A0 Offset: 0x23D35A0 VA: 0x23D75A0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D75A8 Offset: 0x23D35A8 VA: 0x23D75A8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D75B0 Offset: 0x23D35B0 VA: 0x23D75B0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D75B8 Offset: 0x23D35B8 VA: 0x23D75B8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D75C0 Offset: 0x23D35C0 VA: 0x23D75C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D7788 Offset: 0x23D3788 VA: 0x23D7788 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D7858 Offset: 0x23D3858 VA: 0x23D7858 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D792C Offset: 0x23D392C VA: 0x23D792C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23D79A8 Offset: 0x23D39A8 VA: 0x23D79A8
	public void .ctor() { }
}
