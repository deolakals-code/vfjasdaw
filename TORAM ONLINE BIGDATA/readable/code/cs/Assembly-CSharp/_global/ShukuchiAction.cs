// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShukuchiAction : PlayerAttackBase // TypeDefIndex: 2863
{
	// Fields
	[CompilerGenerated]
	private float <NextActionRrange>k__BackingField; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool NoCost { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMoveAssistContinue { get; }
	private float NextActionRrange { get; set; }
	public override bool IsHideAttackApplied { get; }

	// Methods

	// RVA: 0x229F2BC Offset: 0x229B2BC VA: 0x229F2BC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x229F2C4 Offset: 0x229B2C4 VA: 0x229F2C4 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x229F2CC Offset: 0x229B2CC VA: 0x229F2CC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x229F2D4 Offset: 0x229B2D4 VA: 0x229F2D4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x229F2DC Offset: 0x229B2DC VA: 0x229F2DC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x229F2E4 Offset: 0x229B2E4 VA: 0x229F2E4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x229F2EC Offset: 0x229B2EC VA: 0x229F2EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x229F2F4 Offset: 0x229B2F4 VA: 0x229F2F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x229F2FC Offset: 0x229B2FC VA: 0x229F2FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x229F304 Offset: 0x229B304 VA: 0x229F304 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x229F30C Offset: 0x229B30C VA: 0x229F30C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	[CompilerGenerated]
	// RVA: 0x229F314 Offset: 0x229B314 VA: 0x229F314
	private float get_NextActionRrange() { }

	[CompilerGenerated]
	// RVA: 0x229F31C Offset: 0x229B31C VA: 0x229F31C
	public void set_NextActionRrange(float value) { }

	// RVA: 0x229F324 Offset: 0x229B324 VA: 0x229F324 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x229F32C Offset: 0x229B32C VA: 0x229F32C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x229F53C Offset: 0x229B53C VA: 0x229F53C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x229F6EC Offset: 0x229B6EC VA: 0x229F6EC Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x229F834 Offset: 0x229B834 VA: 0x229F834 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x229FDC8 Offset: 0x229BDC8 VA: 0x229FDC8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x229FF44 Offset: 0x229BF44 VA: 0x229FF44
	public static bool CanActivated(BattleManagerBase battle, PlayerStatusBase status, SkillActionBase action) { }

	// RVA: 0x22A0158 Offset: 0x229C158 VA: 0x22A0158
	private static bool CheckInBlackHole(Transform transform) { }

	// RVA: 0x22A06B0 Offset: 0x229C6B0 VA: 0x22A06B0
	public void .ctor() { }
}
