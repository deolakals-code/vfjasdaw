// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AshuraAuraAttackAction : PlayerAttackBase // TypeDefIndex: 2794
{
	// Fields
	private const int MaxAttackCount = 1;
	private float skillRate; // 0x120
	private bool isSecureHit; // 0x124

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool NoCost { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsNotPlayToOtherPlayer { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x2278574 Offset: 0x2274574 VA: 0x2278574 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x227857C Offset: 0x227457C VA: 0x227857C Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2278584 Offset: 0x2274584 VA: 0x2278584 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x227858C Offset: 0x227458C VA: 0x227858C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2278594 Offset: 0x2274594 VA: 0x2278594 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x227859C Offset: 0x227459C VA: 0x227859C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22785A4 Offset: 0x22745A4 VA: 0x22785A4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22785AC Offset: 0x22745AC VA: 0x22785AC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22785B4 Offset: 0x22745B4 VA: 0x22785B4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22785BC Offset: 0x22745BC VA: 0x22785BC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22785C4 Offset: 0x22745C4 VA: 0x22785C4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22785CC Offset: 0x22745CC VA: 0x22785CC Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22785D4 Offset: 0x22745D4 VA: 0x22785D4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22785DC Offset: 0x22745DC VA: 0x22785DC Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x22785E4 Offset: 0x22745E4 VA: 0x22785E4 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x22785EC Offset: 0x22745EC VA: 0x22785EC Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x22785F4 Offset: 0x22745F4 VA: 0x22785F4 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x22785FC Offset: 0x22745FC VA: 0x22785FC Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2278604 Offset: 0x2274604 VA: 0x2278604 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x227860C Offset: 0x227460C VA: 0x227860C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22788AC Offset: 0x22748AC VA: 0x22788AC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22788D0 Offset: 0x22748D0 VA: 0x22788D0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2278A58 Offset: 0x2274A58 VA: 0x2278A58 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2278D08 Offset: 0x2274D08 VA: 0x2278D08 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2278D14 Offset: 0x2274D14 VA: 0x2278D14
	public void .ctor() { }
}
