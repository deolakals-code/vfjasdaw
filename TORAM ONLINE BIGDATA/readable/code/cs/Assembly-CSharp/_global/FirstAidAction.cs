// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FirstAidAction : PlayerAttackBase // TypeDefIndex: 3655
{
	// Fields
	private int cost; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23BB228 Offset: 0x23B7228 VA: 0x23BB228 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23BB230 Offset: 0x23B7230 VA: 0x23BB230 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23BB238 Offset: 0x23B7238 VA: 0x23BB238 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BB240 Offset: 0x23B7240 VA: 0x23BB240 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BB248 Offset: 0x23B7248 VA: 0x23BB248 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BB250 Offset: 0x23B7250 VA: 0x23BB250 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BB258 Offset: 0x23B7258 VA: 0x23BB258 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BB260 Offset: 0x23B7260 VA: 0x23BB260 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BB268 Offset: 0x23B7268 VA: 0x23BB268 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BB270 Offset: 0x23B7270 VA: 0x23BB270 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BB278 Offset: 0x23B7278 VA: 0x23BB278 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BB280 Offset: 0x23B7280 VA: 0x23BB280 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BB440 Offset: 0x23B7440 VA: 0x23BB440 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BB510 Offset: 0x23B7510 VA: 0x23BB510 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BB518 Offset: 0x23B7518 VA: 0x23BB518
	public void .ctor() { }
}
