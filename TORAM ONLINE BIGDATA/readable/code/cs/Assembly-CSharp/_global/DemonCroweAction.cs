// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DemonCroweAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2605
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int percent; // 0x128
	private Vector3 attackPos; // 0x12C
	private bool isGemCartBuf; // 0x138
	private Transform target; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x220BED4 Offset: 0x2207ED4 VA: 0x220BED4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x220BEDC Offset: 0x2207EDC VA: 0x220BEDC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x220BEE4 Offset: 0x2207EE4 VA: 0x220BEE4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x220BEEC Offset: 0x2207EEC VA: 0x220BEEC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x220BEF4 Offset: 0x2207EF4 VA: 0x220BEF4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x220BEFC Offset: 0x2207EFC VA: 0x220BEFC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x220BF04 Offset: 0x2207F04 VA: 0x220BF04 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x220BF0C Offset: 0x2207F0C VA: 0x220BF0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x220BF14 Offset: 0x2207F14 VA: 0x220BF14 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x220C0DC Offset: 0x22080DC VA: 0x220C0DC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x220C4D8 Offset: 0x22084D8 VA: 0x220C4D8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x220C5F8 Offset: 0x22085F8 VA: 0x220C5F8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x220C868 Offset: 0x2208868 VA: 0x220C868 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x220CB18 Offset: 0x2208B18 VA: 0x220CB18 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x220CB1C Offset: 0x2208B1C VA: 0x220CB1C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x220CE04 Offset: 0x2208E04 VA: 0x220CE04 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x220CE68 Offset: 0x2208E68 VA: 0x220CE68
	public void .ctor() { }
}
