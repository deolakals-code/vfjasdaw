// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CounterForceAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3029
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x230AACC Offset: 0x2306ACC VA: 0x230AACC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x230AAD4 Offset: 0x2306AD4 VA: 0x230AAD4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x230AADC Offset: 0x2306ADC VA: 0x230AADC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x230AAE4 Offset: 0x2306AE4 VA: 0x230AAE4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x230AAEC Offset: 0x2306AEC VA: 0x230AAEC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x230AAF4 Offset: 0x2306AF4 VA: 0x230AAF4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x230AAFC Offset: 0x2306AFC VA: 0x230AAFC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x230AB04 Offset: 0x2306B04 VA: 0x230AB04 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x230AB0C Offset: 0x2306B0C VA: 0x230AB0C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x230AB14 Offset: 0x2306B14 VA: 0x230AB14 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x230AB1C Offset: 0x2306B1C VA: 0x230AB1C Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x230AB24 Offset: 0x2306B24 VA: 0x230AB24 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x230AB2C Offset: 0x2306B2C VA: 0x230AB2C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x230AC70 Offset: 0x2306C70 VA: 0x230AC70 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x230AD38 Offset: 0x2306D38 VA: 0x230AD38 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x230AE2C Offset: 0x2306E2C VA: 0x230AE2C Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x230AF00 Offset: 0x2306F00 VA: 0x230AF00 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x230AFD4 Offset: 0x2306FD4 VA: 0x230AFD4
	public void .ctor() { }
}
