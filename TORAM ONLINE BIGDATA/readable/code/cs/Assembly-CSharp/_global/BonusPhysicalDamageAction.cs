// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BonusPhysicalDamageAction : PlayerAttackBase // TypeDefIndex: 1487
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

	// RVA: 0x205CA54 Offset: 0x2058A54 VA: 0x205CA54 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x205CA5C Offset: 0x2058A5C VA: 0x205CA5C Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x205CA64 Offset: 0x2058A64 VA: 0x205CA64 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x205CA6C Offset: 0x2058A6C VA: 0x205CA6C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x205CA74 Offset: 0x2058A74 VA: 0x205CA74 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x205CA7C Offset: 0x2058A7C VA: 0x205CA7C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x205CA84 Offset: 0x2058A84 VA: 0x205CA84 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x205CA8C Offset: 0x2058A8C VA: 0x205CA8C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x205CA94 Offset: 0x2058A94 VA: 0x205CA94 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x205CA9C Offset: 0x2058A9C VA: 0x205CA9C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x205CAA4 Offset: 0x2058AA4 VA: 0x205CAA4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x205CAAC Offset: 0x2058AAC VA: 0x205CAAC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x205CAB4 Offset: 0x2058AB4 VA: 0x205CAB4 Slot: 25
	public override bool get_IsChatLog() { }

	// RVA: 0x205CABC Offset: 0x2058ABC VA: 0x205CABC Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x205CAC4 Offset: 0x2058AC4 VA: 0x205CAC4 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x205CACC Offset: 0x2058ACC VA: 0x205CACC Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x205CAD4 Offset: 0x2058AD4 VA: 0x205CAD4 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x205CADC Offset: 0x2058ADC VA: 0x205CADC Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x205CAE4 Offset: 0x2058AE4 VA: 0x205CAE4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205CAF0 Offset: 0x2058AF0 VA: 0x205CAF0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x205CAFC Offset: 0x2058AFC VA: 0x205CAFC Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x205CB04 Offset: 0x2058B04 VA: 0x205CB04 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x205CF68 Offset: 0x2058F68 VA: 0x205CF68
	public void .ctor() { }
}
