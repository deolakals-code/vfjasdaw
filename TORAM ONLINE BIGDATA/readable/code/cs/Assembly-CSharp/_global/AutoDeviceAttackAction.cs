// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoDeviceAttackAction : PlayerAttackBase // TypeDefIndex: 3026
{
	// Fields
	private readonly SkillId[] TemporarySkillIds; // 0x120
	private bool validPowerWave; // 0x128
	private float powerWaveSkillRate; // 0x12C

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsNotPlayToOtherPlayer { get; }

	// Methods

	// RVA: 0x2307B8C Offset: 0x2303B8C VA: 0x2307B8C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2307B94 Offset: 0x2303B94 VA: 0x2307B94 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2307B9C Offset: 0x2303B9C VA: 0x2307B9C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2307BA4 Offset: 0x2303BA4 VA: 0x2307BA4 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x2307BAC Offset: 0x2303BAC VA: 0x2307BAC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2307BB4 Offset: 0x2303BB4 VA: 0x2307BB4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2307BBC Offset: 0x2303BBC VA: 0x2307BBC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2307BC4 Offset: 0x2303BC4 VA: 0x2307BC4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2307BCC Offset: 0x2303BCC VA: 0x2307BCC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2307BD4 Offset: 0x2303BD4 VA: 0x2307BD4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2307BDC Offset: 0x2303BDC VA: 0x2307BDC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2307BE4 Offset: 0x2303BE4 VA: 0x2307BE4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2307BEC Offset: 0x2303BEC VA: 0x2307BEC Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2307BF4 Offset: 0x2303BF4 VA: 0x2307BF4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2307BFC Offset: 0x2303BFC VA: 0x2307BFC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2307C04 Offset: 0x2303C04 VA: 0x2307C04 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x2307C0C Offset: 0x2303C0C VA: 0x2307C0C Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x2307C14 Offset: 0x2303C14 VA: 0x2307C14 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2307D64 Offset: 0x2303D64 VA: 0x2307D64 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2307D70 Offset: 0x2303D70 VA: 0x2307D70 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23082A8 Offset: 0x23042A8 VA: 0x23082A8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23083C0 Offset: 0x23043C0 VA: 0x23083C0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230947C Offset: 0x230547C VA: 0x230947C
	public void ValidLongRangeAttack(Action delayFunc) { }

	// RVA: 0x2309544 Offset: 0x2305544 VA: 0x2309544
	public void SetDelayFunc(Action delayFunc) { }

	// RVA: 0x2309614 Offset: 0x2305614 VA: 0x2309614
	public void .ctor() { }
}
