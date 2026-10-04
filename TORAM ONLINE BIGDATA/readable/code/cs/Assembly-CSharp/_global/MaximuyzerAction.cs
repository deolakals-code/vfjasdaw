// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MaximuyzerAction : PlayerAttackBase, IEnchantSkill, IChronosShift // TypeDefIndex: 3711
{
	// Fields
	private bool isEnchantStartMotion; // 0x120
	private int mp; // 0x124

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
	public override SkillChargingType ChargingType { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23CE8EC Offset: 0x23CA8EC VA: 0x23CE8EC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CE8F4 Offset: 0x23CA8F4 VA: 0x23CE8F4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CE8FC Offset: 0x23CA8FC VA: 0x23CE8FC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CE904 Offset: 0x23CA904 VA: 0x23CE904 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CE90C Offset: 0x23CA90C VA: 0x23CE90C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CE914 Offset: 0x23CA914 VA: 0x23CE914 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CE91C Offset: 0x23CA91C VA: 0x23CE91C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CE924 Offset: 0x23CA924 VA: 0x23CE924 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CE92C Offset: 0x23CA92C VA: 0x23CE92C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CE934 Offset: 0x23CA934 VA: 0x23CE934 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23CE93C Offset: 0x23CA93C VA: 0x23CE93C Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23CE944 Offset: 0x23CA944 VA: 0x23CE944 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23CE94C Offset: 0x23CA94C VA: 0x23CE94C Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23CE954 Offset: 0x23CA954 VA: 0x23CE954 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CEA08 Offset: 0x23CAA08 VA: 0x23CEA08 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CEAE8 Offset: 0x23CAAE8 VA: 0x23CEAE8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x23CEBC0 Offset: 0x23CABC0 VA: 0x23CEBC0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CEF10 Offset: 0x23CAF10 VA: 0x23CEF10 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x23CEE9C Offset: 0x23CAE9C VA: 0x23CEE9C Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x23CEF20 Offset: 0x23CAF20 VA: 0x23CEF20 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23CEFF4 Offset: 0x23CAFF4 VA: 0x23CEFF4 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23CF0C8 Offset: 0x23CB0C8 VA: 0x23CF0C8
	public void .ctor() { }
}
