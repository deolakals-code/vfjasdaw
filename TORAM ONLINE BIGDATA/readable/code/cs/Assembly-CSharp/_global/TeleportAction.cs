// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TeleportAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3760
{
	// Fields
	private int mp; // 0x120
	private Vector3 moveDir; // 0x124
	private bool inputMove; // 0x130
	private float castStartTime; // 0x134
	private float castStartRealTime; // 0x138

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillChargingType ChargingType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsSupportChangeEndTiming { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }
	public override bool IsFallFailure { get; }

	// Methods

	// RVA: 0x23E0704 Offset: 0x23DC704 VA: 0x23E0704 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23E070C Offset: 0x23DC70C VA: 0x23E070C Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23E0714 Offset: 0x23DC714 VA: 0x23E0714 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23E071C Offset: 0x23DC71C VA: 0x23E071C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23E0724 Offset: 0x23DC724 VA: 0x23E0724 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23E072C Offset: 0x23DC72C VA: 0x23E072C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23E0734 Offset: 0x23DC734 VA: 0x23E0734 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23E073C Offset: 0x23DC73C VA: 0x23E073C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23E0744 Offset: 0x23DC744 VA: 0x23E0744 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23E074C Offset: 0x23DC74C VA: 0x23E074C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23E0754 Offset: 0x23DC754 VA: 0x23E0754 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x23E075C Offset: 0x23DC75C VA: 0x23E075C Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23E0764 Offset: 0x23DC764 VA: 0x23E0764 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x23E076C Offset: 0x23DC76C VA: 0x23E076C Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x23E0774 Offset: 0x23DC774 VA: 0x23E0774 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x23E077C Offset: 0x23DC77C VA: 0x23E077C Slot: 20
	public override bool get_IsFallFailure() { }

	// RVA: 0x23E0784 Offset: 0x23DC784 VA: 0x23E0784 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E08B0 Offset: 0x23DC8B0 VA: 0x23E08B0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23E08EC Offset: 0x23DC8EC VA: 0x23E08EC Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E0C40 Offset: 0x23DCC40 VA: 0x23E0C40 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E0FF0 Offset: 0x23DCFF0 VA: 0x23E0FF0 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23E10D8 Offset: 0x23DD0D8 VA: 0x23E10D8 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x23E1298 Offset: 0x23DD298 VA: 0x23E1298 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23E1328 Offset: 0x23DD328 VA: 0x23E1328 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x23E146C Offset: 0x23DD46C VA: 0x23E146C
	public void .ctor() { }
}
