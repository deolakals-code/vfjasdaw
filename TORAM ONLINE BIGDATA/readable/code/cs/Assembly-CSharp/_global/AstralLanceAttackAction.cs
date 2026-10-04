// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AstralLanceAttackAction : PlayerAttackBase // TypeDefIndex: 3022
{
	// Fields
	private PlayerActionManager playerAction; // 0x120
	private Vector3 attackPos; // 0x128
	private float rad; // 0x134
	private float skillRate; // 0x138
	private int fixAddDamage; // 0x13C
	private int magicResist; // 0x140

	// Properties
	public override int ActionID { get; }
	public override bool IsSupport { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsNotPlayToOtherPlayer { get; }
	public override bool IsHideAttackApplied { get; }

	// Methods

	// RVA: 0x2306ECC Offset: 0x2302ECC VA: 0x2306ECC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2306ED4 Offset: 0x2302ED4 VA: 0x2306ED4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2306EDC Offset: 0x2302EDC VA: 0x2306EDC Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2306EE4 Offset: 0x2302EE4 VA: 0x2306EE4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2306EEC Offset: 0x2302EEC VA: 0x2306EEC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2306EF4 Offset: 0x2302EF4 VA: 0x2306EF4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2306EFC Offset: 0x2302EFC VA: 0x2306EFC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2306F04 Offset: 0x2302F04 VA: 0x2306F04 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2306F0C Offset: 0x2302F0C VA: 0x2306F0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2306F14 Offset: 0x2302F14 VA: 0x2306F14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2306F1C Offset: 0x2302F1C VA: 0x2306F1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2306F24 Offset: 0x2302F24 VA: 0x2306F24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2306F2C Offset: 0x2302F2C VA: 0x2306F2C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2306F34 Offset: 0x2302F34 VA: 0x2306F34 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2306F3C Offset: 0x2302F3C VA: 0x2306F3C Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2306F44 Offset: 0x2302F44 VA: 0x2306F44 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x2306F4C Offset: 0x2302F4C VA: 0x2306F4C Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x2306F54 Offset: 0x2302F54 VA: 0x2306F54 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2307168 Offset: 0x2303168 VA: 0x2307168 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2307254 Offset: 0x2303254 VA: 0x2307254 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2307368 Offset: 0x2303368 VA: 0x2307368 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x23075B4 Offset: 0x23035B4 VA: 0x23075B4 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23076B0 Offset: 0x23036B0 VA: 0x23076B0 Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x2307794 Offset: 0x2303794 VA: 0x2307794
	public void .ctor() { }
}
