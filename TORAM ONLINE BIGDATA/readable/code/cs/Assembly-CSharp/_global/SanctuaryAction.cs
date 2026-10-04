// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SanctuaryAction : PlayerAttackBase // TypeDefIndex: 3741
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

	// RVA: 0x23DA018 Offset: 0x23D6018 VA: 0x23DA018 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DA020 Offset: 0x23D6020 VA: 0x23DA020 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DA028 Offset: 0x23D6028 VA: 0x23DA028 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DA030 Offset: 0x23D6030 VA: 0x23DA030 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DA038 Offset: 0x23D6038 VA: 0x23DA038 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DA040 Offset: 0x23D6040 VA: 0x23DA040 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DA048 Offset: 0x23D6048 VA: 0x23DA048 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DA050 Offset: 0x23D6050 VA: 0x23DA050 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DA058 Offset: 0x23D6058 VA: 0x23DA058 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DA060 Offset: 0x23D6060 VA: 0x23DA060 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DA2E4 Offset: 0x23D62E4 VA: 0x23DA2E4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DA4EC Offset: 0x23D64EC VA: 0x23DA4EC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DA528 Offset: 0x23D6528 VA: 0x23DA528 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23DA5A4 Offset: 0x23D65A4 VA: 0x23DA5A4
	public void .ctor() { }
}
