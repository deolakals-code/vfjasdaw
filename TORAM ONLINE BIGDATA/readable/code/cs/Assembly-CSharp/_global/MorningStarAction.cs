// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MorningStarAction : PlayerAttackBase // TypeDefIndex: 2549
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private MorningStarAction.AttackDirection attackDirection; // 0x128
	private Vector3 moveDir; // 0x12C
	private bool isEvent; // 0x138
	private float otherAngle; // 0x13C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x21ECCF0 Offset: 0x21E8CF0 VA: 0x21ECCF0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x21ECCF8 Offset: 0x21E8CF8 VA: 0x21ECCF8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x21ECD00 Offset: 0x21E8D00 VA: 0x21ECD00 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x21ECD08 Offset: 0x21E8D08 VA: 0x21ECD08 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x21ECD10 Offset: 0x21E8D10 VA: 0x21ECD10 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x21ECD18 Offset: 0x21E8D18 VA: 0x21ECD18 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x21ECD20 Offset: 0x21E8D20 VA: 0x21ECD20 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x21ECD28 Offset: 0x21E8D28 VA: 0x21ECD28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x21ECD30 Offset: 0x21E8D30 VA: 0x21ECD30 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x21ECD38 Offset: 0x21E8D38 VA: 0x21ECD38 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x21ECF1C Offset: 0x21E8F1C VA: 0x21ECF1C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21ED6C8 Offset: 0x21E96C8 VA: 0x21ED6C8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21ED92C Offset: 0x21E992C VA: 0x21ED92C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x21ED94C Offset: 0x21E994C VA: 0x21ED94C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x21EDBC4 Offset: 0x21E9BC4 VA: 0x21EDBC4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x21EDF28 Offset: 0x21E9F28 VA: 0x21EDF28 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x21ED41C Offset: 0x21E941C VA: 0x21ED41C
	private void CreateTake() { }

	// RVA: 0x21EE2A4 Offset: 0x21EA2A4 VA: 0x21EE2A4
	public void .ctor() { }
}
