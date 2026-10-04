// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicBarrierAction : PlayerAttackBase // TypeDefIndex: 3704
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

	// RVA: 0x23CBF38 Offset: 0x23C7F38 VA: 0x23CBF38 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CBF40 Offset: 0x23C7F40 VA: 0x23CBF40 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CBF48 Offset: 0x23C7F48 VA: 0x23CBF48 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CBF50 Offset: 0x23C7F50 VA: 0x23CBF50 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CBF58 Offset: 0x23C7F58 VA: 0x23CBF58 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CBF60 Offset: 0x23C7F60 VA: 0x23CBF60 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CBF68 Offset: 0x23C7F68 VA: 0x23CBF68 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CBF70 Offset: 0x23C7F70 VA: 0x23CBF70 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CBF78 Offset: 0x23C7F78 VA: 0x23CBF78 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CBF80 Offset: 0x23C7F80 VA: 0x23CBF80 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CC14C Offset: 0x23C814C VA: 0x23CC14C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CC21C Offset: 0x23C821C VA: 0x23CC21C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CC2F0 Offset: 0x23C82F0 VA: 0x23CC2F0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23CC36C Offset: 0x23C836C VA: 0x23CC36C
	public void .ctor() { }
}
