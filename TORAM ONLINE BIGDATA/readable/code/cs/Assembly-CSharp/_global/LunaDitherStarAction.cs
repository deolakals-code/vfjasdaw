// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LunaDitherStarAction : PlayerAttackBase, IDualElementSkill // TypeDefIndex: 2633
{
	// Fields
	public const int MaxCrossAttackCount = 2;
	public const int MaxBladeRainAttackCount = 5;
	private int baseMp; // 0x120
	private float crossSkillRate; // 0x124
	private int crossFixAddDamage; // 0x128
	private bool bladeRain; // 0x12C
	private Transform mainTarget; // 0x130
	private Vector3 attackPos; // 0x138
	private Dictionary<MobActionManagerBase, int> targetExpList; // 0x148
	private bool isSecureHit; // 0x150
	private bool isIgnoreAvoid; // 0x151
	private int registSkillId; // 0x154
	private bool interruptable; // 0x158
	private bool otherInterruptable; // 0x159
	private SkillActionBase nextAction; // 0x160
	private float attackStartTargetDist; // 0x168
	private bool isAssault; // 0x16C

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
	public override bool IsMoveAssistContinue { get; }
	public bool IsValidDualElement { get; }

	// Methods

	// RVA: 0x2219570 Offset: 0x2215570 VA: 0x2219570 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2219578 Offset: 0x2215578 VA: 0x2219578 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2219580 Offset: 0x2215580 VA: 0x2219580 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2219588 Offset: 0x2215588 VA: 0x2219588 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2219590 Offset: 0x2215590 VA: 0x2219590 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2219598 Offset: 0x2215598 VA: 0x2219598 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22195A0 Offset: 0x22155A0 VA: 0x22195A0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22195A8 Offset: 0x22155A8 VA: 0x22195A8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22195B0 Offset: 0x22155B0 VA: 0x22195B0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22195B8 Offset: 0x22155B8 VA: 0x22195B8 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x22195C0 Offset: 0x22155C0 VA: 0x22195C0 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22195D8 Offset: 0x22155D8 VA: 0x22195D8 Slot: 91
	public bool get_IsValidDualElement() { }

	// RVA: 0x22195E0 Offset: 0x22155E0 VA: 0x22195E0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22198A4 Offset: 0x22158A4 VA: 0x22198A4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2219968 Offset: 0x2215968 VA: 0x2219968 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2219D60 Offset: 0x2215D60 VA: 0x2219D60 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2219DAC Offset: 0x2215DAC VA: 0x2219DAC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x221A468 Offset: 0x2216468 VA: 0x221A468 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x221A708 Offset: 0x2216708 VA: 0x221A708 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221A9F0 Offset: 0x22169F0 VA: 0x221A9F0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x221AA98 Offset: 0x2216A98 VA: 0x221AA98 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221AEE8 Offset: 0x2216EE8 VA: 0x221AEE8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x221AF6C Offset: 0x2216F6C VA: 0x221AF6C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x221B45C Offset: 0x221745C VA: 0x221B45C
	public static bool CheckInterruptable(int skillId) { }

	// RVA: 0x221A9D0 Offset: 0x22169D0 VA: 0x221A9D0
	public bool CheckInterruptableEnd() { }

	// RVA: 0x221B480 Offset: 0x2217480 VA: 0x221B480
	public void RegistInterruptableSkill(int skillId) { }

	// RVA: 0x221B488 Offset: 0x2217488 VA: 0x221B488
	public void SetNextAction(CharacterActionManagerBase actorAction, SkillActionBase nextAction) { }

	// RVA: 0x221B5F4 Offset: 0x22175F4 VA: 0x221B5F4
	public static void ReceivedAbnormal(PlayerActionManagerBase playerAction, AbnormalType type) { }

	// RVA: 0x221B684 Offset: 0x2217684 VA: 0x221B684
	public void .ctor() { }
}
