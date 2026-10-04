// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SoulStreamAction : PlayerAttackBase, IEnchantSkill, IAbnormalStateSkill // TypeDefIndex: 2895
{
	// Fields
	private int skillRate; // 0x120
	private int constantDamage; // 0x124
	private int abnormalPer; // 0x128

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
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x22C0C60 Offset: 0x22BCC60 VA: 0x22C0C60 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22C0C68 Offset: 0x22BCC68 VA: 0x22C0C68 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22C0C70 Offset: 0x22BCC70 VA: 0x22C0C70 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22C0C78 Offset: 0x22BCC78 VA: 0x22C0C78 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22C0C80 Offset: 0x22BCC80 VA: 0x22C0C80 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22C0C88 Offset: 0x22BCC88 VA: 0x22C0C88 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22C0C90 Offset: 0x22BCC90 VA: 0x22C0C90 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22C0C98 Offset: 0x22BCC98 VA: 0x22C0C98 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22C0CA0 Offset: 0x22BCCA0 VA: 0x22C0CA0 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x22C0CA8 Offset: 0x22BCCA8 VA: 0x22C0CA8 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x22C0CB0 Offset: 0x22BCCB0 VA: 0x22C0CB0 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x22C0CB8 Offset: 0x22BCCB8 VA: 0x22C0CB8 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x22C0CC0 Offset: 0x22BCCC0 VA: 0x22C0CC0 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x22C0CC8 Offset: 0x22BCCC8 VA: 0x22C0CC8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22C0EF8 Offset: 0x22BCEF8 VA: 0x22C0EF8 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22C11A8 Offset: 0x22BD1A8 VA: 0x22C11A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22C12D8 Offset: 0x22BD2D8 VA: 0x22C12D8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22C152C Offset: 0x22BD52C VA: 0x22C152C Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22C1590 Offset: 0x22BD590 VA: 0x22C1590 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x22C1664 Offset: 0x22BD664 VA: 0x22C1664 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x22C1738 Offset: 0x22BD738 VA: 0x22C1738
	public void .ctor() { }
}
