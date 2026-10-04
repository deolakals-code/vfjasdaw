// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class MagicLazerAction : PlayerAttackBase, IEnchantSkill, IChronosShift, IAbnormalStateSkill // TypeDefIndex: 2789
{
	// Fields
	private float skillRate; // 0x120
	private int abnormalRate; // 0x124
	private PlayerActionManagerBase playerAction; // 0x128
	private bool isPaidMp; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x2272BF4 Offset: 0x226EBF4 VA: 0x2272BF4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2272BFC Offset: 0x226EBFC VA: 0x2272BFC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2272C04 Offset: 0x226EC04 VA: 0x2272C04 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2272C0C Offset: 0x226EC0C VA: 0x2272C0C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2272C14 Offset: 0x226EC14 VA: 0x2272C14 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2272C1C Offset: 0x226EC1C VA: 0x2272C1C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2272C24 Offset: 0x226EC24 VA: 0x2272C24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2272C2C Offset: 0x226EC2C VA: 0x2272C2C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2272C34 Offset: 0x226EC34 VA: 0x2272C34 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2272C3C Offset: 0x226EC3C VA: 0x2272C3C Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2272C44 Offset: 0x226EC44 VA: 0x2272C44 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2272C4C Offset: 0x226EC4C VA: 0x2272C4C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22730A8 Offset: 0x226F0A8 VA: 0x22730A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2273214 Offset: 0x226F214 VA: 0x2273214 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2273370 Offset: 0x226F370 VA: 0x2273370 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22735CC Offset: 0x226F5CC VA: 0x22735CC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x227369C Offset: 0x226F69C VA: 0x227369C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2272FD4 Offset: 0x226EFD4 VA: 0x2272FD4
	private int GetAddSkillRate() { }

	// RVA: 0x22739E4 Offset: 0x226F9E4 VA: 0x22739E4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22739EC Offset: 0x226F9EC VA: 0x22739EC Slot: 54
	protected override void OnMotionEnd() { }

	// RVA: 0x2273A54 Offset: 0x226FA54 VA: 0x2273A54 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22739C0 Offset: 0x226F9C0 VA: 0x22739C0
	public static AbnormalType GetAbnormalType(ElementType type) { }

	// RVA: 0x2273B18 Offset: 0x226FB18 VA: 0x2273B18 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x2273604 Offset: 0x226F604 VA: 0x2273604 Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2273B28 Offset: 0x226FB28 VA: 0x2273B28 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2273BFC Offset: 0x226FBFC VA: 0x2273BFC Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2273CD0 Offset: 0x226FCD0 VA: 0x2273CD0
	public void .ctor() { }
}
