// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicGrenadeAction : GolemGrenadeSkillBase // TypeDefIndex: 3365
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override int GrenadeEffectColor { get; }

	// Methods

	// RVA: 0x2351870 Offset: 0x234D870 VA: 0x2351870 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2351878 Offset: 0x234D878 VA: 0x2351878 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2351880 Offset: 0x234D880 VA: 0x2351880 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2351888 Offset: 0x234D888 VA: 0x2351888 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2351890 Offset: 0x234D890 VA: 0x2351890 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2351898 Offset: 0x234D898 VA: 0x2351898 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23518A0 Offset: 0x234D8A0 VA: 0x23518A0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23518A8 Offset: 0x234D8A8 VA: 0x23518A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23518B0 Offset: 0x234D8B0 VA: 0x23518B0 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x23518B8 Offset: 0x234D8B8 VA: 0x23518B8 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x23518C0 Offset: 0x234D8C0 VA: 0x23518C0 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x23518C8 Offset: 0x234D8C8 VA: 0x23518C8 Slot: 91
	protected override int get_GrenadeEffectColor() { }

	// RVA: 0x23518D8 Offset: 0x234D8D8 VA: 0x23518D8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2351A0C Offset: 0x234DA0C VA: 0x2351A0C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2351E18 Offset: 0x234DE18 VA: 0x2351E18 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2351F48 Offset: 0x234DF48 VA: 0x2351F48 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2352144 Offset: 0x234E144 VA: 0x2352144 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2352194 Offset: 0x234E194 VA: 0x2352194 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2352468 Offset: 0x234E468 VA: 0x2352468
	public void .ctor() { }
}
