// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ImperialRayAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3054
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private AutoMember familia; // 0x128
	private PlayerDataManager player; // 0x130
	private bool familiaCast; // 0x138
	private GameObject mainTarget; // 0x140

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
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x2318CF8 Offset: 0x2314CF8 VA: 0x2318CF8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2318D00 Offset: 0x2314D00 VA: 0x2318D00 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2318D08 Offset: 0x2314D08 VA: 0x2318D08 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2318D10 Offset: 0x2314D10 VA: 0x2318D10 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2318D18 Offset: 0x2314D18 VA: 0x2318D18 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2318D20 Offset: 0x2314D20 VA: 0x2318D20 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2318D28 Offset: 0x2314D28 VA: 0x2318D28 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2318D30 Offset: 0x2314D30 VA: 0x2318D30 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2318D38 Offset: 0x2314D38 VA: 0x2318D38 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2318D40 Offset: 0x2314D40 VA: 0x2318D40 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2318D48 Offset: 0x2314D48 VA: 0x2318D48 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2318D50 Offset: 0x2314D50 VA: 0x2318D50 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2318D58 Offset: 0x2314D58 VA: 0x2318D58 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2318F80 Offset: 0x2314F80 VA: 0x2318F80 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2319018 Offset: 0x2315018 VA: 0x2319018 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2319100 Offset: 0x2315100 VA: 0x2319100 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23193F4 Offset: 0x23153F4 VA: 0x23193F4 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x231970C Offset: 0x231570C VA: 0x231970C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2319908 Offset: 0x2315908 VA: 0x2319908 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x23199DC Offset: 0x23159DC VA: 0x23199DC Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2319AB0 Offset: 0x2315AB0 VA: 0x2319AB0
	public void .ctor() { }
}
