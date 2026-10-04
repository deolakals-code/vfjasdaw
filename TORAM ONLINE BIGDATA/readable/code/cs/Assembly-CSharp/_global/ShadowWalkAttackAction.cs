// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShadowWalkAttackAction : PlayerAttackBase // TypeDefIndex: 2538
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int exSkillRate; // 0x128
	private int attackCount; // 0x12C
	private bool isCounter; // 0x130
	private ItemData weaponItem; // 0x138
	private float range; // 0x140
	private bool isExpDefFluctuate; // 0x144

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x21E7D54 Offset: 0x21E3D54 VA: 0x21E7D54 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x21E7D5C Offset: 0x21E3D5C VA: 0x21E7D5C Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x21E7D64 Offset: 0x21E3D64 VA: 0x21E7D64 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21E7D6C Offset: 0x21E3D6C VA: 0x21E7D6C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21E7D74 Offset: 0x21E3D74 VA: 0x21E7D74 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21E7D7C Offset: 0x21E3D7C VA: 0x21E7D7C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21E7D84 Offset: 0x21E3D84 VA: 0x21E7D84 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21E7D8C Offset: 0x21E3D8C VA: 0x21E7D8C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21E7D94 Offset: 0x21E3D94 VA: 0x21E7D94 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21E7D9C Offset: 0x21E3D9C VA: 0x21E7D9C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21E7DA4 Offset: 0x21E3DA4 VA: 0x21E7DA4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x21E7DAC Offset: 0x21E3DAC VA: 0x21E7DAC Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x21E7DB4 Offset: 0x21E3DB4 VA: 0x21E7DB4 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x21E7DBC Offset: 0x21E3DBC VA: 0x21E7DBC Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x21E7DC4 Offset: 0x21E3DC4 VA: 0x21E7DC4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21E7EF8 Offset: 0x21E3EF8 VA: 0x21E7EF8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21E7F04 Offset: 0x21E3F04 VA: 0x21E7F04 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E82B4 Offset: 0x21E42B4 VA: 0x21E82B4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21E8450 Offset: 0x21E4450 VA: 0x21E8450 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21E85B0 Offset: 0x21E45B0 VA: 0x21E85B0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21E8CA0 Offset: 0x21E4CA0 VA: 0x21E8CA0
	public void SetIsCounter(bool isCounter) { }

	// RVA: 0x21E8CAC Offset: 0x21E4CAC VA: 0x21E8CAC
	public void .ctor() { }
}
