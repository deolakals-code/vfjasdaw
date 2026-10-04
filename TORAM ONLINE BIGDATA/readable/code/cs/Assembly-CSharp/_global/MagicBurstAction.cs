// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicBurstAction : PlayerAttackBase, IEnchantSkill, IChronosShift, IAbnormalStateSkill // TypeDefIndex: 2772
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private readonly int damageCount; // 0x128
	private int abnormalPercent; // 0x12C
	private float knockback; // 0x130
	private float attackRange; // 0x134
	private float attackAngle; // 0x138
	private Vector3 forward; // 0x13C
	private Action invincibilityBufFunc; // 0x148
	private bool addInvincibility; // 0x150
	private MagicBurstAction lastUsedSkill; // 0x158
	private bool enchantedBurstStack; // 0x160
	private short invincibilityId; // 0x162

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x2262F58 Offset: 0x225EF58 VA: 0x2262F58 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2262F60 Offset: 0x225EF60 VA: 0x2262F60 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2262F68 Offset: 0x225EF68 VA: 0x2262F68 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2262F70 Offset: 0x225EF70 VA: 0x2262F70 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2262F78 Offset: 0x225EF78 VA: 0x2262F78 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2262F80 Offset: 0x225EF80 VA: 0x2262F80 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2262F88 Offset: 0x225EF88 VA: 0x2262F88 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2262F90 Offset: 0x225EF90 VA: 0x2262F90 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2262F98 Offset: 0x225EF98 VA: 0x2262F98 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2262FA0 Offset: 0x225EFA0 VA: 0x2262FA0 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2262FA8 Offset: 0x225EFA8 VA: 0x2262FA8 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2262FB0 Offset: 0x225EFB0 VA: 0x2262FB0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2263494 Offset: 0x225F494 VA: 0x2263494 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2263720 Offset: 0x225F720 VA: 0x2263720 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2263900 Offset: 0x225F900 VA: 0x2263900 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2263F54 Offset: 0x225FF54 VA: 0x2263F54 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2264120 Offset: 0x2260120 VA: 0x2264120 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22642A8 Offset: 0x22602A8 VA: 0x22642A8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2264450 Offset: 0x2260450 VA: 0x2264450 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22647BC Offset: 0x22607BC VA: 0x22647BC Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2264820 Offset: 0x2260820 VA: 0x2264820 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x2263DEC Offset: 0x225FDEC VA: 0x2263DEC Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x22648E0 Offset: 0x22608E0 VA: 0x22648E0
	public static void AddStack(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2264ADC Offset: 0x2260ADC VA: 0x2264ADC Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2264BB0 Offset: 0x2260BB0 VA: 0x2264BB0 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2264C84 Offset: 0x2260C84 VA: 0x2264C84
	public void .ctor() { }
}
