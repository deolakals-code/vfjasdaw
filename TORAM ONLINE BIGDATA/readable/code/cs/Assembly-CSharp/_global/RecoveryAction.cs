// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecoveryAction : PlayerAttackBase, IEnchantedSpellInvokeSkill // TypeDefIndex: 3736
{
	// Fields
	private int hpHeal; // 0x120

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

	// Methods

	// RVA: 0x23D80FC Offset: 0x23D40FC VA: 0x23D80FC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D8104 Offset: 0x23D4104 VA: 0x23D8104 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D810C Offset: 0x23D410C VA: 0x23D810C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D8114 Offset: 0x23D4114 VA: 0x23D8114 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D811C Offset: 0x23D411C VA: 0x23D811C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D8124 Offset: 0x23D4124 VA: 0x23D8124 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D812C Offset: 0x23D412C VA: 0x23D812C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D8134 Offset: 0x23D4134 VA: 0x23D8134 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D813C Offset: 0x23D413C VA: 0x23D813C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D8144 Offset: 0x23D4144 VA: 0x23D8144 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x23D8178 Offset: 0x23D4178 VA: 0x23D8178 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D8410 Offset: 0x23D4410 VA: 0x23D8410 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D85FC Offset: 0x23D45FC VA: 0x23D85FC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D8650 Offset: 0x23D4650 VA: 0x23D8650 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D8A14 Offset: 0x23D4A14 VA: 0x23D8A14
	private void AddRecovery(PlayerActionManagerBase actionManager) { }

	// RVA: 0x23D8574 Offset: 0x23D4574 VA: 0x23D8574 Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x23D8AB0 Offset: 0x23D4AB0 VA: 0x23D8AB0
	public void .ctor() { }
}
