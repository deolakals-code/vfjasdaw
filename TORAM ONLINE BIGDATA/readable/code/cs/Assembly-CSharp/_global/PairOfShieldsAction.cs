// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PairOfShieldsAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 3718
{
	// Fields
	public const int TakeId = 202091000;
	private PlayerActionManagerBase playerAction; // 0x120

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
	public override bool IsOverlay { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23D2970 Offset: 0x23CE970 VA: 0x23D2970 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D2978 Offset: 0x23CE978 VA: 0x23D2978 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D2980 Offset: 0x23CE980 VA: 0x23D2980 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D2988 Offset: 0x23CE988 VA: 0x23D2988 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D2990 Offset: 0x23CE990 VA: 0x23D2990 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D2998 Offset: 0x23CE998 VA: 0x23D2998 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D29A0 Offset: 0x23CE9A0 VA: 0x23D29A0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D29A8 Offset: 0x23CE9A8 VA: 0x23D29A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D29B0 Offset: 0x23CE9B0 VA: 0x23D29B0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D29B8 Offset: 0x23CE9B8 VA: 0x23D29B8 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x23D29C0 Offset: 0x23CE9C0 VA: 0x23D29C0 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23D29C8 Offset: 0x23CE9C8 VA: 0x23D29C8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D2B08 Offset: 0x23CEB08 VA: 0x23D2B08 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D2B88 Offset: 0x23CEB88 VA: 0x23D2B88 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D2C94 Offset: 0x23CEC94 VA: 0x23D2C94 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D2E44 Offset: 0x23CEE44 VA: 0x23D2E44 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23D312C Offset: 0x23CF12C VA: 0x23D312C
	public void .ctor() { }
}
