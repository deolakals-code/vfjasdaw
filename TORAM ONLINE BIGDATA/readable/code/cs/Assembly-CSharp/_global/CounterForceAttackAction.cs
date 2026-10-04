// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CounterForceAttackAction : PlayerAttackBase // TypeDefIndex: 3030
{
	// Fields
	private PlayerActionManagerBase playerAction; // 0x120
	private float skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private const int damageCount = 4;

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsNotPlayToOtherPlayer { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsHideAttackApplied { get; }

	// Methods

	// RVA: 0x230AFDC Offset: 0x2306FDC VA: 0x230AFDC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x230AFE4 Offset: 0x2306FE4 VA: 0x230AFE4 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x230AFEC Offset: 0x2306FEC VA: 0x230AFEC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x230AFF4 Offset: 0x2306FF4 VA: 0x230AFF4 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x230AFFC Offset: 0x2306FFC VA: 0x230AFFC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230B004 Offset: 0x2307004 VA: 0x230B004 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230B00C Offset: 0x230700C VA: 0x230B00C Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x230B014 Offset: 0x2307014 VA: 0x230B014 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230B01C Offset: 0x230701C VA: 0x230B01C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230B024 Offset: 0x2307024 VA: 0x230B024 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230B02C Offset: 0x230702C VA: 0x230B02C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230B034 Offset: 0x2307034 VA: 0x230B034 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230B03C Offset: 0x230703C VA: 0x230B03C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230B044 Offset: 0x2307044 VA: 0x230B044 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x230B04C Offset: 0x230704C VA: 0x230B04C Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x230B054 Offset: 0x2307054 VA: 0x230B054 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x230B05C Offset: 0x230705C VA: 0x230B05C Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x230B064 Offset: 0x2307064 VA: 0x230B064 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230B358 Offset: 0x2307358 VA: 0x230B358 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230B368 Offset: 0x2307368 VA: 0x230B368 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x230B64C Offset: 0x230764C VA: 0x230B64C Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x230B734 Offset: 0x2307734 VA: 0x230B734
	public void .ctor() { }
}
