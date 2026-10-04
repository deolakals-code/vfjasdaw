// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EarthShatteringAction : PlayerAttackBase // TypeDefIndex: 3641
{
	// Fields
	private int bufCondition; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override int BaseMp { get; }

	// Methods

	// RVA: 0x23B65BC Offset: 0x23B25BC VA: 0x23B65BC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B65C4 Offset: 0x23B25C4 VA: 0x23B65C4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B65CC Offset: 0x23B25CC VA: 0x23B65CC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B65D4 Offset: 0x23B25D4 VA: 0x23B65D4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B65DC Offset: 0x23B25DC VA: 0x23B65DC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B65E4 Offset: 0x23B25E4 VA: 0x23B65E4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B65EC Offset: 0x23B25EC VA: 0x23B65EC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B65F4 Offset: 0x23B25F4 VA: 0x23B65F4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B65FC Offset: 0x23B25FC VA: 0x23B65FC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B6604 Offset: 0x23B2604 VA: 0x23B6604 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B672C Offset: 0x23B272C VA: 0x23B672C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B67EC Offset: 0x23B27EC VA: 0x23B67EC Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B690C Offset: 0x23B290C VA: 0x23B690C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B6AF8 Offset: 0x23B2AF8 VA: 0x23B6AF8 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23B74E8 Offset: 0x23B34E8 VA: 0x23B74E8
	public void .ctor() { }
}
