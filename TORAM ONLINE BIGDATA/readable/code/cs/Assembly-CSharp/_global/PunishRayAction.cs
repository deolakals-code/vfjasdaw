// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PunishRayAction : PlayerAttackBase, IEnchantSkill, IEnchantedSpellInvokeSkill // TypeDefIndex: 2687
{
	// Fields
	private float skillRate; // 0x120
	private float bonusSkillRate; // 0x124
	private int fixAddDamage; // 0x128
	private readonly int damageCount; // 0x12C
	private bool isHit; // 0x130

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
	public override bool IsNoMotionTake { get; }

	// Methods

	// RVA: 0x2234860 Offset: 0x2230860 VA: 0x2234860 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2234868 Offset: 0x2230868 VA: 0x2234868 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2234870 Offset: 0x2230870 VA: 0x2234870 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2234878 Offset: 0x2230878 VA: 0x2234878 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2234880 Offset: 0x2230880 VA: 0x2234880 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2234888 Offset: 0x2230888 VA: 0x2234888 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2234890 Offset: 0x2230890 VA: 0x2234890 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2234898 Offset: 0x2230898 VA: 0x2234898 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22348A0 Offset: 0x22308A0 VA: 0x22348A0 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x22348A8 Offset: 0x22308A8 VA: 0x22348A8 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x22348B0 Offset: 0x22308B0 VA: 0x22348B0 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x22348B8 Offset: 0x22308B8 VA: 0x22348B8 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x22348EC Offset: 0x22308EC VA: 0x22348EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2234BC0 Offset: 0x2230BC0 VA: 0x2234BC0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2234E48 Offset: 0x2230E48 VA: 0x2234E48 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x223514C Offset: 0x223114C VA: 0x223514C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x223539C Offset: 0x223139C VA: 0x223539C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2235654 Offset: 0x2231654 VA: 0x2235654 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2235728 Offset: 0x2231728 VA: 0x2235728 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2234D84 Offset: 0x2230D84 VA: 0x2234D84 Slot: 96
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x22357FC Offset: 0x22317FC VA: 0x22357FC
	public void .ctor() { }
}
