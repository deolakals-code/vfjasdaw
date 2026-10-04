// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicWallAction : PlayerAttackBase, IEnchantedSpellInvokeSkill, IEnchantSkill, IChronosShift, IAbnormalStateSkill // TypeDefIndex: 2793
{
	// Fields
	private int damageCount; // 0x120
	private Vector3 placePosition; // 0x124
	private float rad; // 0x130
	private float skillRate; // 0x134
	private int fixAddDamage; // 0x138
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x140
	private MagicWallAction lastUsedSkill; // 0x148
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> spellTuningWall; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsNoMotionTake { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x2276484 Offset: 0x2272484 VA: 0x2276484 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x227648C Offset: 0x227248C VA: 0x227648C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2276494 Offset: 0x2272494 VA: 0x2276494 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x227649C Offset: 0x227249C VA: 0x227649C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22764A4 Offset: 0x22724A4 VA: 0x22764A4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22764AC Offset: 0x22724AC VA: 0x22764AC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22764B4 Offset: 0x22724B4 VA: 0x22764B4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22764BC Offset: 0x22724BC VA: 0x22764BC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22764C4 Offset: 0x22724C4 VA: 0x22764C4 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x22764CC Offset: 0x22724CC VA: 0x22764CC Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22764D4 Offset: 0x22724D4 VA: 0x22764D4 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2276508 Offset: 0x2272508 VA: 0x2276508 Slot: 92
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2276510 Offset: 0x2272510 VA: 0x2276510 Slot: 93
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2276518 Offset: 0x2272518 VA: 0x2276518 Slot: 94
	public bool get_IsStackChainCast() { }

	// RVA: 0x2276520 Offset: 0x2272520 VA: 0x2276520 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2276B34 Offset: 0x2272B34 VA: 0x2276B34
	private void WriteSkillIndividualFlag() { }

	// RVA: 0x2276BE8 Offset: 0x2272BE8 VA: 0x2276BE8
	private void ReadSkillIndividualFlag() { }

	// RVA: 0x2276C8C Offset: 0x2272C8C VA: 0x2276C8C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2276E34 Offset: 0x2272E34 VA: 0x2276E34 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2276F40 Offset: 0x2272F40 VA: 0x2276F40 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2277530 Offset: 0x2273530 VA: 0x2277530 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2277638 Offset: 0x2273638 VA: 0x2277638 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2277BEC Offset: 0x2273BEC VA: 0x2277BEC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2277D0C Offset: 0x2273D0C VA: 0x2277D0C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2277D7C Offset: 0x2273D7C VA: 0x2277D7C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2277DE0 Offset: 0x2273DE0 VA: 0x2277DE0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2278058 Offset: 0x2274058 VA: 0x2278058 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22769B0 Offset: 0x22729B0 VA: 0x22769B0
	private SkillLinkedTake CreateEventTake() { }

	// RVA: 0x2277254 Offset: 0x2273254 VA: 0x2277254 Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x2278234 Offset: 0x2274234 VA: 0x2278234 Slot: 97
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x2276EA8 Offset: 0x2272EA8 VA: 0x2276EA8 Slot: 98
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x22782F4 Offset: 0x22742F4 VA: 0x22782F4 Slot: 95
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x22783C8 Offset: 0x22743C8 VA: 0x22783C8 Slot: 96
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x227849C Offset: 0x227449C VA: 0x227849C
	public void .ctor() { }
}
