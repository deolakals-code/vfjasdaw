// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CrossFireAction : PlayerAttackBase // TypeDefIndex: 2975
{
	// Fields
	private float mainSkillRate; // 0x120
	private int mainFixAddDamage; // 0x124
	private float subSkillRate; // 0x128
	private int subFixAddDamage; // 0x12C
	private int subResist; // 0x130
	private float decoySkillRate; // 0x134
	private int decoyFixAddDamage; // 0x138
	private float width; // 0x13C
	private float length; // 0x140
	private int chargeLevel; // 0x144
	private int maxChargeLevel; // 0x148
	private int mp; // 0x14C
	private int maxAttackCout; // 0x150
	private Vector3 decoyPos; // 0x154
	private Transform mainTarget; // 0x160
	private CrossFireAction.ShootAttackType type; // 0x168
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x170
	private SkillComboType chargeComboType; // 0x178
	private int chargeComboRate; // 0x17C
	private Vector3 mainForward; // 0x180
	private Vector3 mainAttackPos; // 0x18C
	private bool isRangeBonus; // 0x198
	private Vector3 otherTargetPos; // 0x19C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x22EE6A4 Offset: 0x22EA6A4 VA: 0x22EE6A4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22EE6AC Offset: 0x22EA6AC VA: 0x22EE6AC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22EE6B4 Offset: 0x22EA6B4 VA: 0x22EE6B4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22EE6BC Offset: 0x22EA6BC VA: 0x22EE6BC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22EE6C4 Offset: 0x22EA6C4 VA: 0x22EE6C4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22EE6CC Offset: 0x22EA6CC VA: 0x22EE6CC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22EE6D4 Offset: 0x22EA6D4 VA: 0x22EE6D4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22EE6DC Offset: 0x22EA6DC VA: 0x22EE6DC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22EE6E4 Offset: 0x22EA6E4 VA: 0x22EE6E4 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x22EE6EC Offset: 0x22EA6EC VA: 0x22EE6EC Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22EE6F4 Offset: 0x22EA6F4 VA: 0x22EE6F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22EEBA8 Offset: 0x22EABA8 VA: 0x22EEBA8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22EECA0 Offset: 0x22EACA0 VA: 0x22EECA0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22EEDA8 Offset: 0x22EADA8 VA: 0x22EEDA8 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22EEE94 Offset: 0x22EAE94 VA: 0x22EEE94 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22EF24C Offset: 0x22EB24C VA: 0x22EF24C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22EF7A8 Offset: 0x22EB7A8 VA: 0x22EF7A8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x22EF818 Offset: 0x22EB818 VA: 0x22EF818 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22EFB4C Offset: 0x22EBB4C VA: 0x22EFB4C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22F0158 Offset: 0x22EC158 VA: 0x22F0158 Slot: 78
	public override int CorrectComboRate() { }

	// RVA: 0x22F0164 Offset: 0x22EC164 VA: 0x22F0164 Slot: 79
	public override bool CheckComboAccept(SkillComboType comboType) { }

	// RVA: 0x22EEAD0 Offset: 0x22EAAD0 VA: 0x22EEAD0
	private static SkillLinkedTake CreateTake(ItemDBData.ItemType weapon, ElementType element, int chargeLevel) { }

	// RVA: 0x22F0180 Offset: 0x22EC180 VA: 0x22F0180
	public void .ctor() { }
}
