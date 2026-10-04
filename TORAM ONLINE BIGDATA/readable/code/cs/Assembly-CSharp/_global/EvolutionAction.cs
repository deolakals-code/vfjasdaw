// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EvolutionAction : PlayerAttackBase // TypeDefIndex: 3649
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23B962C Offset: 0x23B562C VA: 0x23B962C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B9634 Offset: 0x23B5634 VA: 0x23B9634 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B963C Offset: 0x23B563C VA: 0x23B963C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B9644 Offset: 0x23B5644 VA: 0x23B9644 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B964C Offset: 0x23B564C VA: 0x23B964C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B9654 Offset: 0x23B5654 VA: 0x23B9654 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B965C Offset: 0x23B565C VA: 0x23B965C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B9664 Offset: 0x23B5664 VA: 0x23B9664 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B966C Offset: 0x23B566C VA: 0x23B966C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B9674 Offset: 0x23B5674 VA: 0x23B9674 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B97C8 Offset: 0x23B57C8 VA: 0x23B97C8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B9890 Offset: 0x23B5890 VA: 0x23B9890 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B9A04 Offset: 0x23B5A04 VA: 0x23B9A04
	public void .ctor() { }
}
