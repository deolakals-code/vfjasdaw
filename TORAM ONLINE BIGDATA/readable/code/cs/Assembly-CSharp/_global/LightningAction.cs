// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LightningAction : PlayerAttackBase, IHighFamiliaAttackSkill, IAbnormalStateSkill // TypeDefIndex: 3056
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
	public override bool IsExpDefFluctuate { get; }
	public override bool IsHideAttackApplied { get; }
	public bool IsFailureSkill { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }

	// Methods

	// RVA: 0x2319AB8 Offset: 0x2315AB8 VA: 0x2319AB8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2319AC0 Offset: 0x2315AC0 VA: 0x2319AC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2319AC8 Offset: 0x2315AC8 VA: 0x2319AC8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2319AD0 Offset: 0x2315AD0 VA: 0x2319AD0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2319AD8 Offset: 0x2315AD8 VA: 0x2319AD8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2319AE0 Offset: 0x2315AE0 VA: 0x2319AE0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2319AE8 Offset: 0x2315AE8 VA: 0x2319AE8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2319AF0 Offset: 0x2315AF0 VA: 0x2319AF0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2319AF8 Offset: 0x2315AF8 VA: 0x2319AF8 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2319B18 Offset: 0x2315B18 VA: 0x2319B18 Slot: 70
	public override bool get_IsHideAttackApplied() { }

	// RVA: 0x2319B38 Offset: 0x2315B38 VA: 0x2319B38 Slot: 92
	public bool get_IsFailureSkill() { }

	// RVA: 0x2319B68 Offset: 0x2315B68 VA: 0x2319B68 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2319B70 Offset: 0x2315B70 VA: 0x2319B70 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2319B78 Offset: 0x2315B78 VA: 0x2319B78 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2319D14 Offset: 0x2315D14 VA: 0x2319D14 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2319DAC Offset: 0x2315DAC VA: 0x2319DAC Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2319DB0 Offset: 0x2315DB0 VA: 0x2319DB0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2319F0C Offset: 0x2315F0C VA: 0x2319F0C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2319FF4 Offset: 0x2315FF4 VA: 0x2319FF4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x231A0CC Offset: 0x23160CC VA: 0x231A0CC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x231A5D8 Offset: 0x23165D8 VA: 0x231A5D8 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x231A670 Offset: 0x2316670 VA: 0x231A670 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x231A6D4 Offset: 0x23166D4 VA: 0x231A6D4 Slot: 91
	public void InitializeHighFamilia(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x231A4E0 Offset: 0x23164E0 VA: 0x231A4E0
	private void SkillBufValid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x231A3E8 Offset: 0x23163E8 VA: 0x231A3E8
	private void SkillBufInvalid(PlayerActionManagerBase playerAction) { }

	// RVA: 0x231A7A8 Offset: 0x23167A8 VA: 0x231A7A8
	public void .ctor() { }
}
