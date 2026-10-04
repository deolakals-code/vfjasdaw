// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DecoyShooterAction : PlayerAttackBase // TypeDefIndex: 2982
{
	// Fields
	[CompilerGenerated]
	private Vector3 <PlacePos>k__BackingField; // 0x120
	private int skillRate; // 0x12C
	private float range; // 0x130
	private Func<GameObject, bool> checkFunc; // 0x138
	private bool isFirst; // 0x140
	private int takeEventId; // 0x144
	private float delayTime; // 0x148
	private int stopTime; // 0x14C
	private const int MaxStopTime = 3;

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsNoMotionTake { get; }
	public Vector3 PlacePos { get; set; }

	// Methods

	// RVA: 0x22F0AEC Offset: 0x22ECAEC VA: 0x22F0AEC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22F0AF4 Offset: 0x22ECAF4 VA: 0x22F0AF4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22F0AFC Offset: 0x22ECAFC VA: 0x22F0AFC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22F0B04 Offset: 0x22ECB04 VA: 0x22F0B04 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22F0B0C Offset: 0x22ECB0C VA: 0x22F0B0C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22F0B14 Offset: 0x22ECB14 VA: 0x22F0B14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22F0B1C Offset: 0x22ECB1C VA: 0x22F0B1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22F0B24 Offset: 0x22ECB24 VA: 0x22F0B24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22F0B2C Offset: 0x22ECB2C VA: 0x22F0B2C Slot: 31
	public override bool get_IsNoMotionTake() { }

	[CompilerGenerated]
	// RVA: 0x22F0B38 Offset: 0x22ECB38 VA: 0x22F0B38
	public Vector3 get_PlacePos() { }

	[CompilerGenerated]
	// RVA: 0x22F0B48 Offset: 0x22ECB48 VA: 0x22F0B48
	private void set_PlacePos(Vector3 value) { }

	// RVA: 0x22F0B58 Offset: 0x22ECB58 VA: 0x22F0B58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22F1230 Offset: 0x22ED230 VA: 0x22F1230 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22F1618 Offset: 0x22ED618 VA: 0x22F1618 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22F1664 Offset: 0x22ED664 VA: 0x22F1664 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F17DC Offset: 0x22ED7DC VA: 0x22F17DC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22F2128 Offset: 0x22EE128 VA: 0x22F2128 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22F219C Offset: 0x22EE19C VA: 0x22F219C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22F2328 Offset: 0x22EE328 VA: 0x22F2328 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22F3110 Offset: 0x22EF110 VA: 0x22F3110 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F1180 Offset: 0x22ED180 VA: 0x22F1180
	private int GetTakeEventID(ItemDBData.ItemType main, ItemDBData.ItemType sub) { }

	// RVA: 0x22F10C8 Offset: 0x22ED0C8 VA: 0x22F10C8
	private int CalcDuration(int level) { }

	// RVA: 0x22F3450 Offset: 0x22EF450 VA: 0x22F3450
	public void .ctor() { }
}
