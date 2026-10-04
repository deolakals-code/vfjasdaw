// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ClineHealAction : PlayerAttackBase // TypeDefIndex: 3028
{
	// Fields
	private int hpHeal; // 0x120
	private GameObject target; // 0x128

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

	// Methods

	// RVA: 0x230A0E0 Offset: 0x23060E0 VA: 0x230A0E0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x230A0E8 Offset: 0x23060E8 VA: 0x230A0E8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230A0F0 Offset: 0x23060F0 VA: 0x230A0F0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230A0F8 Offset: 0x23060F8 VA: 0x230A0F8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230A100 Offset: 0x2306100 VA: 0x230A100 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230A108 Offset: 0x2306108 VA: 0x230A108 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230A110 Offset: 0x2306110 VA: 0x230A110 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230A118 Offset: 0x2306118 VA: 0x230A118 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230A120 Offset: 0x2306120 VA: 0x230A120 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230A128 Offset: 0x2306128 VA: 0x230A128 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230A2D8 Offset: 0x23062D8 VA: 0x230A2D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230A3A8 Offset: 0x23063A8 VA: 0x230A3A8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x230A53C Offset: 0x230653C VA: 0x230A53C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x230A624 Offset: 0x2306624 VA: 0x230A624
	public static GameObject CheckHealTarget(GameObject playerObject) { }

	// RVA: 0x230AAC4 Offset: 0x2306AC4 VA: 0x230AAC4
	public void .ctor() { }
}
