// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BattleNotesAttackAction : PlayerAttackBase // TypeDefIndex: 2818
{
	// Fields
	private static readonly SkillId[] InvalidSkillBufferIds; // 0x0
	private SkillMasterData baseSkillMaster; // 0x120

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
	public override bool NoCost { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsNoMotionTake { get; }
	public override bool IsHideAttackApplied { get; }
	public override bool IsNotPlayToOtherPlayer { get; }
	public override bool IsSkillStartTargetLook { get; }

	// Methods

	// RVA: 0x2289550 Offset: 0x2285550 VA: 0x2289550 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2289558 Offset: 0x2285558 VA: 0x2289558 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2289560 Offset: 0x2285560 VA: 0x2289560 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2289568 Offset: 0x2285568 VA: 0x2289568 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2289570 Offset: 0x2285570 VA: 0x2289570 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2289578 Offset: 0x2285578 VA: 0x2289578 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2289580 Offset: 0x2285580 VA: 0x2289580 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2289588 Offset: 0x2285588 VA: 0x2289588 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2289590 Offset: 0x2285590 VA: 0x2289590 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2289598 Offset: 0x2285598 VA: 0x2289598 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22895A0 Offset: 0x22855A0 VA: 0x22895A0 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x22895A8 Offset: 0x22855A8 VA: 0x22895A8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x22895B0 Offset: 0x22855B0 VA: 0x22895B0 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x22895B8 Offset: 0x22855B8 VA: 0x22895B8 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22895C0 Offset: 0x22855C0 VA: 0x22895C0 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x22895C8 Offset: 0x22855C8 VA: 0x22895C8 Slot: 33
	public override bool get_IsNotPlayToOtherPlayer() { }

	// RVA: 0x22895D0 Offset: 0x22855D0 VA: 0x22895D0 Slot: 32
	public override bool get_IsSkillStartTargetLook() { }

	// RVA: 0x22895D8 Offset: 0x22855D8 VA: 0x22895D8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22896F0 Offset: 0x22856F0 VA: 0x22896F0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2289EB8 Offset: 0x2285EB8 VA: 0x2289EB8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2289FD0 Offset: 0x2285FD0 VA: 0x2289FD0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x228AD08 Offset: 0x2286D08 VA: 0x228AD08
	private bool CalcHit(PlayerStatusBase status, MobActionManagerBase mobAction, out SkillHitType hitType, out bool correctHit) { }

	// RVA: 0x228B244 Offset: 0x2287244 VA: 0x228B244 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228B250 Offset: 0x2287250 VA: 0x228B250
	public void .ctor() { }

	// RVA: 0x228B258 Offset: 0x2287258 VA: 0x228B258
	private static void .cctor() { }
}
