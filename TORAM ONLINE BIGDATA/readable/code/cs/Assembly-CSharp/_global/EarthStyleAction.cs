// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EarthStyleAction : NinjaSkillBase // TypeDefIndex: 2907
{
	// Fields
	private int baseMp; // 0x124
	private SkillLinkedTake nextEffect; // 0x128
	private PlayerActionManagerBase playerAction; // 0x130
	private bool otherSkillEnd; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }
	public override SkillChargingType ChargingType { get; }
	public override bool NoCost { get; }

	// Methods

	// RVA: 0x22CB56C Offset: 0x22C756C VA: 0x22CB56C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22CB574 Offset: 0x22C7574 VA: 0x22CB574 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22CB57C Offset: 0x22C757C VA: 0x22CB57C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22CB584 Offset: 0x22C7584 VA: 0x22CB584 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22CB58C Offset: 0x22C758C VA: 0x22CB58C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22CB594 Offset: 0x22C7594 VA: 0x22CB594 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22CB59C Offset: 0x22C759C VA: 0x22CB59C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22CB5A4 Offset: 0x22C75A4 VA: 0x22CB5A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22CB5AC Offset: 0x22C75AC VA: 0x22CB5AC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22CB5B4 Offset: 0x22C75B4 VA: 0x22CB5B4 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x22CB5BC Offset: 0x22C75BC VA: 0x22CB5BC Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x22CB5C4 Offset: 0x22C75C4 VA: 0x22CB5C4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22CB5CC Offset: 0x22C75CC VA: 0x22CB5CC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CB750 Offset: 0x22C7750 VA: 0x22CB750 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CB968 Offset: 0x22C7968 VA: 0x22CB968 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22CB980 Offset: 0x22C7980 VA: 0x22CB980 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22CB994 Offset: 0x22C7994 VA: 0x22CB994 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22CBAD8 Offset: 0x22C7AD8 VA: 0x22CBAD8 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22CBC04 Offset: 0x22C7C04 VA: 0x22CBC04 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22CBF10 Offset: 0x22C7F10 VA: 0x22CBF10
	public void StopEffectTake() { }

	// RVA: 0x22CB76C Offset: 0x22C776C VA: 0x22CB76C
	private void CreateTake() { }

	// RVA: 0x22CBF4C Offset: 0x22C7F4C VA: 0x22CBF4C
	public static void Damaged(PlayerActionManagerBase playerAction, SkillDamageData damageData) { }

	// RVA: 0x22CC02C Offset: 0x22C802C VA: 0x22CC02C
	public void .ctor() { }
}
