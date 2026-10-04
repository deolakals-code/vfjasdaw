// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BonusNaturalDamageAction : PlayerAttackBase // TypeDefIndex: 1485
{
	// Fields
	private int skillRate; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsChatLog { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override bool CheckBlank { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x205C008 Offset: 0x2058008 VA: 0x205C008 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x205C010 Offset: 0x2058010 VA: 0x205C010 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x205C018 Offset: 0x2058018 VA: 0x205C018 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x205C020 Offset: 0x2058020 VA: 0x205C020 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x205C028 Offset: 0x2058028 VA: 0x205C028 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x205C030 Offset: 0x2058030 VA: 0x205C030 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x205C038 Offset: 0x2058038 VA: 0x205C038 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x205C040 Offset: 0x2058040 VA: 0x205C040 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x205C048 Offset: 0x2058048 VA: 0x205C048 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x205C050 Offset: 0x2058050 VA: 0x205C050 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x205C058 Offset: 0x2058058 VA: 0x205C058 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x205C060 Offset: 0x2058060 VA: 0x205C060 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x205C068 Offset: 0x2058068 VA: 0x205C068 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x205C070 Offset: 0x2058070 VA: 0x205C070 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x205C078 Offset: 0x2058078 VA: 0x205C078 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x205C080 Offset: 0x2058080 VA: 0x205C080 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x205C088 Offset: 0x2058088 VA: 0x205C088 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x205C090 Offset: 0x2058090 VA: 0x205C090 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x205C098 Offset: 0x2058098 VA: 0x205C098 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205C0A4 Offset: 0x20580A4 VA: 0x205C0A4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x205C0B0 Offset: 0x20580B0 VA: 0x205C0B0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x205C0B8 Offset: 0x20580B8 VA: 0x205C0B8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x205C530 Offset: 0x2058530 VA: 0x205C530
	public void .ctor() { }
}
