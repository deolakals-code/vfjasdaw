// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BonusMagicDamageAction : PlayerAttackBase // TypeDefIndex: 1484
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

	// RVA: 0x205BAEC Offset: 0x2057AEC VA: 0x205BAEC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x205BAF4 Offset: 0x2057AF4 VA: 0x205BAF4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x205BAFC Offset: 0x2057AFC VA: 0x205BAFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x205BB04 Offset: 0x2057B04 VA: 0x205BB04 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x205BB0C Offset: 0x2057B0C VA: 0x205BB0C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x205BB14 Offset: 0x2057B14 VA: 0x205BB14 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x205BB1C Offset: 0x2057B1C VA: 0x205BB1C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x205BB24 Offset: 0x2057B24 VA: 0x205BB24 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x205BB2C Offset: 0x2057B2C VA: 0x205BB2C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x205BB34 Offset: 0x2057B34 VA: 0x205BB34 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x205BB3C Offset: 0x2057B3C VA: 0x205BB3C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x205BB44 Offset: 0x2057B44 VA: 0x205BB44 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x205BB4C Offset: 0x2057B4C VA: 0x205BB4C Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x205BB54 Offset: 0x2057B54 VA: 0x205BB54 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x205BB5C Offset: 0x2057B5C VA: 0x205BB5C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x205BB64 Offset: 0x2057B64 VA: 0x205BB64 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x205BB6C Offset: 0x2057B6C VA: 0x205BB6C Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x205BB74 Offset: 0x2057B74 VA: 0x205BB74 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x205BB7C Offset: 0x2057B7C VA: 0x205BB7C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205BB88 Offset: 0x2057B88 VA: 0x205BB88 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x205BB94 Offset: 0x2057B94 VA: 0x205BB94 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x205BB9C Offset: 0x2057B9C VA: 0x205BB9C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x205C000 Offset: 0x2058000 VA: 0x205C000
	public void .ctor() { }
}
