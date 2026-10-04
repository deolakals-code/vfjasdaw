// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BusterBladeAction : PlayerAttackBase // TypeDefIndex: 2555
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int healHp; // 0x128
	private int shildRefine; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }

	// Methods

	// RVA: 0x21F1568 Offset: 0x21ED568 VA: 0x21F1568 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21F1570 Offset: 0x21ED570 VA: 0x21F1570 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21F1578 Offset: 0x21ED578 VA: 0x21F1578 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21F1580 Offset: 0x21ED580 VA: 0x21F1580 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21F1588 Offset: 0x21ED588 VA: 0x21F1588 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21F1590 Offset: 0x21ED590 VA: 0x21F1590 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21F1598 Offset: 0x21ED598 VA: 0x21F1598 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21F15A0 Offset: 0x21ED5A0 VA: 0x21F15A0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21F15A8 Offset: 0x21ED5A8 VA: 0x21F15A8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21F18D4 Offset: 0x21ED8D4 VA: 0x21F18D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21F19A8 Offset: 0x21ED9A8 VA: 0x21F19A8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21F1C60 Offset: 0x21EDC60 VA: 0x21F1C60 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21F1E9C Offset: 0x21EDE9C VA: 0x21F1E9C
	public void .ctor() { }
}
