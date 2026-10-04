// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicEgelAttackAction : PlayerAttackBase // TypeDefIndex: 2775
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int knockBack; // 0x128
	private bool isPlace; // 0x12C

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x22669F8 Offset: 0x22629F8 VA: 0x22669F8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2266A00 Offset: 0x2262A00 VA: 0x2266A00 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x2266A08 Offset: 0x2262A08 VA: 0x2266A08 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2266A10 Offset: 0x2262A10 VA: 0x2266A10 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2266A18 Offset: 0x2262A18 VA: 0x2266A18 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2266A20 Offset: 0x2262A20 VA: 0x2266A20 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2266A28 Offset: 0x2262A28 VA: 0x2266A28 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2266A30 Offset: 0x2262A30 VA: 0x2266A30 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2266A38 Offset: 0x2262A38 VA: 0x2266A38 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2266A40 Offset: 0x2262A40 VA: 0x2266A40 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2266A48 Offset: 0x2262A48 VA: 0x2266A48 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2266A50 Offset: 0x2262A50 VA: 0x2266A50 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x2266A58 Offset: 0x2262A58 VA: 0x2266A58 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2266A60 Offset: 0x2262A60 VA: 0x2266A60 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2266A68 Offset: 0x2262A68 VA: 0x2266A68 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2266CF8 Offset: 0x2262CF8 VA: 0x2266CF8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2266CFC Offset: 0x2262CFC VA: 0x2266CFC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2266E14 Offset: 0x2262E14 VA: 0x2266E14 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2266E20 Offset: 0x2262E20 VA: 0x2266E20 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2267160 Offset: 0x2263160 VA: 0x2267160
	public void .ctor() { }
}
