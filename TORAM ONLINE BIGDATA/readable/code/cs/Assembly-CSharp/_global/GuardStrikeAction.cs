// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuardStrikeAction : PlayerAttackBase // TypeDefIndex: 1492
{
	// Fields
	private float skillRate; // 0x120
	private float fixAddDamage; // 0x124

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsChatLog { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x2062024 Offset: 0x205E024 VA: 0x2062024 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x206202C Offset: 0x205E02C VA: 0x206202C Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2062034 Offset: 0x205E034 VA: 0x2062034 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x206203C Offset: 0x205E03C VA: 0x206203C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2062044 Offset: 0x205E044 VA: 0x2062044 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x206204C Offset: 0x205E04C VA: 0x206204C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2062054 Offset: 0x205E054 VA: 0x2062054 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x206205C Offset: 0x205E05C VA: 0x206205C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2062064 Offset: 0x205E064 VA: 0x2062064 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x206206C Offset: 0x205E06C VA: 0x206206C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2062074 Offset: 0x205E074 VA: 0x2062074 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x206207C Offset: 0x205E07C VA: 0x206207C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2062084 Offset: 0x205E084 VA: 0x2062084 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x206208C Offset: 0x205E08C VA: 0x206208C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2062094 Offset: 0x205E094 VA: 0x2062094 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x206209C Offset: 0x205E09C VA: 0x206209C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x20621F8 Offset: 0x205E1F8 VA: 0x20621F8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2062220 Offset: 0x205E220 VA: 0x2062220 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x206222C Offset: 0x205E22C VA: 0x206222C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20624FC Offset: 0x205E4FC VA: 0x20624FC
	public void .ctor() { }
}
