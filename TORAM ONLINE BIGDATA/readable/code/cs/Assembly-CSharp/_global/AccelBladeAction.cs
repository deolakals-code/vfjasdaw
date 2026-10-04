// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AccelBladeAction : PlayerAttackBase // TypeDefIndex: 2550
{
	// Fields
	private float skillRate; // 0x120
	private float rangeRad; // 0x124
	private int fixAddDamage; // 0x128
	private int critical; // 0x12C
	private Vector3 startPos; // 0x130
	private List<Vector3> pointList; // 0x140
	private byte rank; // 0x148
	private float rankUpReceptionTime; // 0x14C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsEventIgnoreOther { get; }
	public override string LocalizeKey { get; }
	public override bool IsMove { get; }

	// Methods

	// RVA: 0x21EE354 Offset: 0x21EA354 VA: 0x21EE354 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21EE35C Offset: 0x21EA35C VA: 0x21EE35C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21EE364 Offset: 0x21EA364 VA: 0x21EE364 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21EE36C Offset: 0x21EA36C VA: 0x21EE36C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21EE374 Offset: 0x21EA374 VA: 0x21EE374 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21EE37C Offset: 0x21EA37C VA: 0x21EE37C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21EE384 Offset: 0x21EA384 VA: 0x21EE384 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21EE38C Offset: 0x21EA38C VA: 0x21EE38C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21EE394 Offset: 0x21EA394 VA: 0x21EE394 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x21EE39C Offset: 0x21EA39C VA: 0x21EE39C Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x21EE408 Offset: 0x21EA408 VA: 0x21EE408 Slot: 28
	public override bool get_IsMove() { }

	// RVA: 0x21EE410 Offset: 0x21EA410 VA: 0x21EE410 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21EE71C Offset: 0x21EA71C VA: 0x21EE71C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21EE86C Offset: 0x21EA86C VA: 0x21EE86C Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x21EE968 Offset: 0x21EA968 VA: 0x21EE968 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EF074 Offset: 0x21EB074 VA: 0x21EF074 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x21EF1A4 Offset: 0x21EB1A4 VA: 0x21EF1A4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21EF454 Offset: 0x21EB454 VA: 0x21EF454 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x21EF480 Offset: 0x21EB480 VA: 0x21EF480
	public void .ctor() { }
}
