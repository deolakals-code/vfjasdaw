// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KakeiAction : PlayerAttackBase // TypeDefIndex: 3691
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }

	// Methods

	// RVA: 0x23C7258 Offset: 0x23C3258 VA: 0x23C7258 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C7260 Offset: 0x23C3260 VA: 0x23C7260 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C7268 Offset: 0x23C3268 VA: 0x23C7268 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C7270 Offset: 0x23C3270 VA: 0x23C7270 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C7278 Offset: 0x23C3278 VA: 0x23C7278 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C7280 Offset: 0x23C3280 VA: 0x23C7280 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C7288 Offset: 0x23C3288 VA: 0x23C7288 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C7290 Offset: 0x23C3290 VA: 0x23C7290 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C7298 Offset: 0x23C3298 VA: 0x23C7298 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C72A0 Offset: 0x23C32A0 VA: 0x23C72A0 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23C72A8 Offset: 0x23C32A8 VA: 0x23C72A8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C7390 Offset: 0x23C3390 VA: 0x23C7390 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C7624 Offset: 0x23C3624 VA: 0x23C7624 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C76A4 Offset: 0x23C36A4 VA: 0x23C76A4
	public static void Damaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23C7B34 Offset: 0x23C3B34 VA: 0x23C7B34
	public void .ctor() { }
}
