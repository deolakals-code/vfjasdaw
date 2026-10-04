// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DiseasetSealAction : PlayerAttackBase // TypeDefIndex: 3634
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

	// RVA: 0x23B4AF4 Offset: 0x23B0AF4 VA: 0x23B4AF4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B4AFC Offset: 0x23B0AFC VA: 0x23B4AFC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B4B04 Offset: 0x23B0B04 VA: 0x23B4B04 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B4B0C Offset: 0x23B0B0C VA: 0x23B4B0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B4B14 Offset: 0x23B0B14 VA: 0x23B4B14 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B4B1C Offset: 0x23B0B1C VA: 0x23B4B1C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B4B24 Offset: 0x23B0B24 VA: 0x23B4B24 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B4B2C Offset: 0x23B0B2C VA: 0x23B4B2C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B4B34 Offset: 0x23B0B34 VA: 0x23B4B34 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B4B3C Offset: 0x23B0B3C VA: 0x23B4B3C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B4D04 Offset: 0x23B0D04 VA: 0x23B4D04 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B4DD4 Offset: 0x23B0DD4 VA: 0x23B4DD4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B4EA8 Offset: 0x23B0EA8 VA: 0x23B4EA8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23B4F24 Offset: 0x23B0F24 VA: 0x23B4F24
	public void .ctor() { }
}
