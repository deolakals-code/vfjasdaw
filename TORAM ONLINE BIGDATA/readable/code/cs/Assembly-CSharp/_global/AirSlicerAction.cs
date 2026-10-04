// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AirSlicerAction : PlayerAttackBase, IDualElementSkill // TypeDefIndex: 2617
{
	// Fields
	private readonly int MaxFirstAttackCount; // 0x120
	private readonly int MaxSecondAttackCount; // 0x124
	private float firstSkillRate; // 0x128
	private int firstFixAddDamage; // 0x12C
	private int percent; // 0x130
	private float secondSkillRate; // 0x134
	private float secondSkillRateBonus; // 0x138
	private int secondFixAddDamage; // 0x13C
	private int criticalDamageUp; // 0x140
	private bool exp; // 0x144
	private GameObject target; // 0x148
	private SkillAttackType expType; // 0x150
	private bool otherChange; // 0x154

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsExpDefFluctuate { get; }
	public bool IsValidDualElement { get; }

	// Methods

	// RVA: 0x2211DEC Offset: 0x220DDEC VA: 0x2211DEC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2211DF4 Offset: 0x220DDF4 VA: 0x2211DF4 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2211DFC Offset: 0x220DDFC VA: 0x2211DFC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2211E04 Offset: 0x220DE04 VA: 0x2211E04 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2211E0C Offset: 0x220DE0C VA: 0x2211E0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2211E14 Offset: 0x220DE14 VA: 0x2211E14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2211E1C Offset: 0x220DE1C VA: 0x2211E1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2211E24 Offset: 0x220DE24 VA: 0x2211E24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2211E2C Offset: 0x220DE2C VA: 0x2211E2C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2211E34 Offset: 0x220DE34 VA: 0x2211E34 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2211E3C Offset: 0x220DE3C VA: 0x2211E3C Slot: 91
	public bool get_IsValidDualElement() { }

	// RVA: 0x2211E44 Offset: 0x220DE44 VA: 0x2211E44 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2212208 Offset: 0x220E208 VA: 0x2212208 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2212238 Offset: 0x220E238 VA: 0x2212238 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2212638 Offset: 0x220E638 VA: 0x2212638
	private SkillCalcTemplate CalcFirstDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22127FC Offset: 0x220E7FC VA: 0x22127FC
	private SkillCalcTemplate CalcSecondDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2212B44 Offset: 0x220EB44 VA: 0x2212B44 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221311C Offset: 0x220F11C VA: 0x221311C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22131F0 Offset: 0x220F1F0 VA: 0x22131F0
	public void ExpDefFluctuated() { }

	// RVA: 0x22131F8 Offset: 0x220F1F8 VA: 0x22131F8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x221325C Offset: 0x220F25C VA: 0x221325C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x221337C Offset: 0x220F37C VA: 0x221337C Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2213450 Offset: 0x220F450 VA: 0x2213450
	public void .ctor() { }
}
