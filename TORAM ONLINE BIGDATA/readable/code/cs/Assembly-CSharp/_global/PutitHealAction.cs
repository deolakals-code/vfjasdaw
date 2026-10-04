// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PutitHealAction : PlayerAttackBase, IEnchantedSpellInvokeSkill // TypeDefIndex: 3727
{
	// Fields
	private int hpHeal; // 0x120
	private int baseMp; // 0x124

	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsNoMotionTake { get; }
	public int HpHeal { get; }

	// Methods

	// RVA: 0x23D5868 Offset: 0x23D1868 VA: 0x23D5868 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D5870 Offset: 0x23D1870 VA: 0x23D5870 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D5878 Offset: 0x23D1878 VA: 0x23D5878 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D5880 Offset: 0x23D1880 VA: 0x23D5880 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D5888 Offset: 0x23D1888 VA: 0x23D5888 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D5890 Offset: 0x23D1890 VA: 0x23D5890 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D5898 Offset: 0x23D1898 VA: 0x23D5898 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D58A0 Offset: 0x23D18A0 VA: 0x23D58A0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D58A8 Offset: 0x23D18A8 VA: 0x23D58A8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D58B0 Offset: 0x23D18B0 VA: 0x23D58B0 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x23D58E4 Offset: 0x23D18E4 VA: 0x23D58E4
	public int get_HpHeal() { }

	// RVA: 0x23D58EC Offset: 0x23D18EC VA: 0x23D58EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D5DF0 Offset: 0x23D1DF0 VA: 0x23D5DF0 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D601C Offset: 0x23D201C VA: 0x23D601C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D611C Offset: 0x23D211C VA: 0x23D611C
	public void CheckHealStock() { }

	// RVA: 0x23D6130 Offset: 0x23D2130 VA: 0x23D6130 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D6294 Offset: 0x23D2294 VA: 0x23D6294 Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x23D631C Offset: 0x23D231C VA: 0x23D631C
	public void .ctor() { }
}
