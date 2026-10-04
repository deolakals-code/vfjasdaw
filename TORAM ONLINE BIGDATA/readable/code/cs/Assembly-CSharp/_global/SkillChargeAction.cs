// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillChargeAction : PlayerAttackBase // TypeDefIndex: 3748
{
	// Fields
	private int mp; // 0x120
	private SkillId baseSkillId; // 0x124
	private byte baseSkillLv; // 0x128
	private SkillComboType comboType; // 0x12C
	private int comboRate; // 0x130

	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override bool IsMoveAssistContinue { get; }

	// Methods

	// RVA: 0x23DBD4C Offset: 0x23D7D4C VA: 0x23DBD4C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23DBD54 Offset: 0x23D7D54 VA: 0x23DBD54 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DBD5C Offset: 0x23D7D5C VA: 0x23DBD5C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DBD64 Offset: 0x23D7D64 VA: 0x23DBD64 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DBD6C Offset: 0x23D7D6C VA: 0x23DBD6C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DBD74 Offset: 0x23D7D74 VA: 0x23DBD74 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DBD7C Offset: 0x23D7D7C VA: 0x23DBD7C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DBD84 Offset: 0x23D7D84 VA: 0x23DBD84 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DBD8C Offset: 0x23D7D8C VA: 0x23DBD8C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DBD94 Offset: 0x23D7D94 VA: 0x23DBD94 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DBD9C Offset: 0x23D7D9C VA: 0x23DBD9C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23DBDA4 Offset: 0x23D7DA4 VA: 0x23DBDA4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DBF70 Offset: 0x23D7F70 VA: 0x23DBF70 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DC078 Offset: 0x23D8078 VA: 0x23DC078 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DC4E0 Offset: 0x23D84E0 VA: 0x23DC4E0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DC680 Offset: 0x23D8680 VA: 0x23DC680
	public bool ReserveSkillCharge(PlayerActionManagerBase playerAction, SkillActionBase skillAction, SkillId skillId) { }

	// RVA: 0x23DC834 Offset: 0x23D8834 VA: 0x23DC834
	public void SetBaseSkill(SkillId id, byte lv) { }

	// RVA: 0x23DC840 Offset: 0x23D8840 VA: 0x23DC840 Slot: 76
	public override void SetComboType(SkillComboType comboType) { }

	// RVA: 0x23DC868 Offset: 0x23D8868 VA: 0x23DC868 Slot: 75
	public override void SetComboRate(int rate) { }

	// RVA: 0x23DC874 Offset: 0x23D8874 VA: 0x23DC874
	public SkillId GetBaseSkillId() { }

	// RVA: 0x23DC87C Offset: 0x23D887C VA: 0x23DC87C
	public static void Decode(int skillIndividualFlag, out short skillId, out byte skillLv) { }

	// RVA: 0x23DC88C Offset: 0x23D888C VA: 0x23DC88C
	public static void ReceiveSupport(GameReturnCode returnCode, PlayerActionManagerBase playerAction, SupportResultData response) { }

	// RVA: 0x23DCA44 Offset: 0x23D8A44 VA: 0x23DCA44
	public void .ctor() { }
}
