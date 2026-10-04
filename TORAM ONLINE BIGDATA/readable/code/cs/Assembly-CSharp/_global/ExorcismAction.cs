// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExorcismAction : PlayerAttackBase, IInheritMindimageSenju, IAbnormalStateSkill, IEnchantedSpellInvokeSkill // TypeDefIndex: 2953
{
	// Fields
	[CompilerGenerated]
	private bool <IsInheritance>k__BackingField; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int percent; // 0x12C
	private AbnormalType abnormalType; // 0x130
	private Dictionary<int, AbnormalType> selectAbnormal; // 0x138
	private float attackRange; // 0x140
	private bool isNemesisBuf; // 0x144

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public bool IsInheritance { get; set; }
	public override bool IsNoMotionTake { get; }

	// Methods

	// RVA: 0x22E1964 Offset: 0x22DD964 VA: 0x22E1964 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22E196C Offset: 0x22DD96C VA: 0x22E196C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22E1974 Offset: 0x22DD974 VA: 0x22E1974 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22E197C Offset: 0x22DD97C VA: 0x22E197C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22E1984 Offset: 0x22DD984 VA: 0x22E1984 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22E198C Offset: 0x22DD98C VA: 0x22E198C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22E1994 Offset: 0x22DD994 VA: 0x22E1994 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22E199C Offset: 0x22DD99C VA: 0x22E199C Slot: 14
	public override bool get_IsRange() { }

	[CompilerGenerated]
	// RVA: 0x22E19A4 Offset: 0x22DD9A4 VA: 0x22E19A4 Slot: 91
	public bool get_IsInheritance() { }

	[CompilerGenerated]
	// RVA: 0x22E19AC Offset: 0x22DD9AC VA: 0x22E19AC
	private void set_IsInheritance(bool value) { }

	// RVA: 0x22E19B8 Offset: 0x22DD9B8 VA: 0x22E19B8 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22E19EC Offset: 0x22DD9EC VA: 0x22E19EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22E1CC4 Offset: 0x22DDCC4 VA: 0x22E1CC4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22E200C Offset: 0x22DE00C VA: 0x22E200C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E20D8 Offset: 0x22DE0D8 VA: 0x22E20D8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22E223C Offset: 0x22DE23C VA: 0x22E223C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22E22FC Offset: 0x22DE2FC VA: 0x22E22FC Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22E27F8 Offset: 0x22DE7F8 VA: 0x22E27F8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22E283C Offset: 0x22DE83C VA: 0x22E283C Slot: 92
	public void OnInheritance() { }

	// RVA: 0x22E1F04 Offset: 0x22DDF04 VA: 0x22E1F04 Slot: 94
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x22E2848 Offset: 0x22DE848 VA: 0x22E2848
	public void .ctor() { }
}
