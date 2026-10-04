// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AstralLanceAction : PlayerAttackBase, IEnchantSkill // TypeDefIndex: 3021
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x23069C4 Offset: 0x23029C4 VA: 0x23069C4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23069CC Offset: 0x23029CC VA: 0x23069CC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23069D4 Offset: 0x23029D4 VA: 0x23069D4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23069DC Offset: 0x23029DC VA: 0x23069DC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23069E4 Offset: 0x23029E4 VA: 0x23069E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23069EC Offset: 0x23029EC VA: 0x23069EC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23069F4 Offset: 0x23029F4 VA: 0x23069F4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23069FC Offset: 0x23029FC VA: 0x23069FC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2306A04 Offset: 0x2302A04 VA: 0x2306A04 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2306A0C Offset: 0x2302A0C VA: 0x2306A0C Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2306A14 Offset: 0x2302A14 VA: 0x2306A14 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2306A1C Offset: 0x2302A1C VA: 0x2306A1C Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2306A24 Offset: 0x2302A24 VA: 0x2306A24 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2306B68 Offset: 0x2302B68 VA: 0x2306B68 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2306C30 Offset: 0x2302C30 VA: 0x2306C30 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2306D1C Offset: 0x2302D1C VA: 0x2306D1C Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2306DF0 Offset: 0x2302DF0 VA: 0x2306DF0 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2306EC4 Offset: 0x2302EC4 VA: 0x2306EC4
	public void .ctor() { }
}
