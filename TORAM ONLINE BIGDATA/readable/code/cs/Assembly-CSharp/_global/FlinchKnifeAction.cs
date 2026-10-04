// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FlinchKnifeAction : PlayerAttackBase, IAbnormalStateSkill, IMotionSwitchSkill // TypeDefIndex: 2726
{
	// Fields
	private int skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int flinchPercent; // 0x128
	private int physicsResist; // 0x12C
	private bool isFightingKnife; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override string LocalizeKey { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x224C1A0 Offset: 0x22481A0 VA: 0x224C1A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x224C1A8 Offset: 0x22481A8 VA: 0x224C1A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x224C1B0 Offset: 0x22481B0 VA: 0x224C1B0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x224C1B8 Offset: 0x22481B8 VA: 0x224C1B8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x224C1C0 Offset: 0x22481C0 VA: 0x224C1C0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x224C1C8 Offset: 0x22481C8 VA: 0x224C1C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x224C1D0 Offset: 0x22481D0 VA: 0x224C1D0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x224C1D8 Offset: 0x22481D8 VA: 0x224C1D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x224C1E0 Offset: 0x22481E0 VA: 0x224C1E0 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x224C24C Offset: 0x224824C VA: 0x224C24C Slot: 92
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x224C254 Offset: 0x2248254 VA: 0x224C254 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224C420 Offset: 0x2248420 VA: 0x224C420 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224C4E4 Offset: 0x22484E4 VA: 0x224C4E4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x224C674 Offset: 0x2248674 VA: 0x224C674 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x224C9C0 Offset: 0x22489C0 VA: 0x224C9C0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224CC44 Offset: 0x2248C44 VA: 0x224CC44 Slot: 90
	public override string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x224CC7C Offset: 0x2248C7C VA: 0x224CC7C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x224CCE0 Offset: 0x2248CE0 VA: 0x224CCE0
	public void .ctor() { }
}
