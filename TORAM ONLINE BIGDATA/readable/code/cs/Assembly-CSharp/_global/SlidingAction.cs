// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SlidingAction : PlayerAttackBase // TypeDefIndex: 2813
{
	// Fields
	private const float MaxMoveTime = 3;
	private Vector3 otherActorPos; // 0x120
	private Vector3 otherTargetPos; // 0x12C
	private float startTime; // 0x138
	private float targetSize; // 0x13C
	private bool immovable; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x2285BFC Offset: 0x2281BFC VA: 0x2285BFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2285C04 Offset: 0x2281C04 VA: 0x2285C04 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2285C0C Offset: 0x2281C0C VA: 0x2285C0C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2285C14 Offset: 0x2281C14 VA: 0x2285C14 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2285C1C Offset: 0x2281C1C VA: 0x2285C1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2285C24 Offset: 0x2281C24 VA: 0x2285C24 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2285C2C Offset: 0x2281C2C VA: 0x2285C2C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2285C34 Offset: 0x2281C34 VA: 0x2285C34 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2285C3C Offset: 0x2281C3C VA: 0x2285C3C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2285C44 Offset: 0x2281C44 VA: 0x2285C44 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2285CE4 Offset: 0x2281CE4 VA: 0x2285CE4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2286498 Offset: 0x2282498 VA: 0x2286498 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2286708 Offset: 0x2282708 VA: 0x2286708 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2286D5C Offset: 0x2282D5C VA: 0x2286D5C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2286E14 Offset: 0x2282E14 VA: 0x2286E14 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x2286E88 Offset: 0x2282E88 VA: 0x2286E88 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2287038 Offset: 0x2283038 VA: 0x2287038 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2287098 Offset: 0x2283098 VA: 0x2287098 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2287174 Offset: 0x2283174 VA: 0x2287174
	public void .ctor() { }
}
