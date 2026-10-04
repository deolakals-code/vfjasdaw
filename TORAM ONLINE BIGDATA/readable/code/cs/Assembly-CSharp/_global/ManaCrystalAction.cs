// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ManaCrystalAction : PlayerAttackBase // TypeDefIndex: 3708
{
	// Fields
	private float range; // 0x120
	private Vector3 crystalPos; // 0x124
	private AutoMember familia; // 0x130
	private bool failure; // 0x138
	private PlayerDataManager player; // 0x140
	private bool castingExtension; // 0x148
	private bool familiaCast; // 0x149

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
	public override SkillChargingType ChargingType { get; }

	// Methods

	// RVA: 0x23CD834 Offset: 0x23C9834 VA: 0x23CD834 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CD83C Offset: 0x23C983C VA: 0x23CD83C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CD844 Offset: 0x23C9844 VA: 0x23CD844 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CD84C Offset: 0x23C984C VA: 0x23CD84C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CD854 Offset: 0x23C9854 VA: 0x23CD854 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CD85C Offset: 0x23C985C VA: 0x23CD85C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CD864 Offset: 0x23C9864 VA: 0x23CD864 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CD86C Offset: 0x23C986C VA: 0x23CD86C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CD874 Offset: 0x23C9874 VA: 0x23CD874 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CD87C Offset: 0x23C987C VA: 0x23CD87C Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23CD884 Offset: 0x23C9884 VA: 0x23CD884 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CDA58 Offset: 0x23C9A58 VA: 0x23CDA58 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CDAF8 Offset: 0x23C9AF8 VA: 0x23CDAF8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CE078 Offset: 0x23CA078 VA: 0x23CE078 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23CE088 Offset: 0x23CA088 VA: 0x23CE088 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23CE2D8 Offset: 0x23CA2D8 VA: 0x23CE2D8 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23CDE4C Offset: 0x23C9E4C VA: 0x23CDE4C
	public static bool CalcMasterToFamiliaCenter(Vector3 masterPos, Vector3 familiaPos, out Vector3 center) { }

	// RVA: 0x23CE370 Offset: 0x23CA370 VA: 0x23CE370
	public void .ctor() { }
}
