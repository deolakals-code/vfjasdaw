// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ResonanceAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3738
{
	// Fields
	private int refine; // 0x120
	private Dictionary<int, short> bufFlagList; // 0x128

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
	public override bool IsOverlay { get; }
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23D9094 Offset: 0x23D5094 VA: 0x23D9094 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D909C Offset: 0x23D509C VA: 0x23D909C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D90A4 Offset: 0x23D50A4 VA: 0x23D90A4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D90AC Offset: 0x23D50AC VA: 0x23D90AC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D90B4 Offset: 0x23D50B4 VA: 0x23D90B4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D90BC Offset: 0x23D50BC VA: 0x23D90BC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D90C4 Offset: 0x23D50C4 VA: 0x23D90C4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D90CC Offset: 0x23D50CC VA: 0x23D90CC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D90D4 Offset: 0x23D50D4 VA: 0x23D90D4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D90DC Offset: 0x23D50DC VA: 0x23D90DC Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x23D90E4 Offset: 0x23D50E4 VA: 0x23D90E4 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23D90EC Offset: 0x23D50EC VA: 0x23D90EC Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23D90F4 Offset: 0x23D50F4 VA: 0x23D90F4 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23D90FC Offset: 0x23D50FC VA: 0x23D90FC Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23D9104 Offset: 0x23D5104 VA: 0x23D9104 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D9294 Offset: 0x23D5294 VA: 0x23D9294 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D934C Offset: 0x23D534C VA: 0x23D934C Slot: 81
	public override void SupportStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x23D9354 Offset: 0x23D5354 VA: 0x23D9354 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D954C Offset: 0x23D554C VA: 0x23D954C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23D96D0 Offset: 0x23D56D0 VA: 0x23D96D0 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23D97A4 Offset: 0x23D57A4 VA: 0x23D97A4 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23D9878 Offset: 0x23D5878 VA: 0x23D9878
	public void .ctor() { }
}
