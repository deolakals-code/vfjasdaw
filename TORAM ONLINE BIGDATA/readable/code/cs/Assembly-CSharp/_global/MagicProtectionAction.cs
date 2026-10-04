// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicProtectionAction : PlayerAttackBase // TypeDefIndex: 3706
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
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23CCBDC Offset: 0x23C8BDC VA: 0x23CCBDC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CCBE4 Offset: 0x23C8BE4 VA: 0x23CCBE4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CCBEC Offset: 0x23C8BEC VA: 0x23CCBEC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CCBF4 Offset: 0x23C8BF4 VA: 0x23CCBF4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CCBFC Offset: 0x23C8BFC VA: 0x23CCBFC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CCC04 Offset: 0x23C8C04 VA: 0x23CCC04 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CCC0C Offset: 0x23C8C0C VA: 0x23CCC0C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CCC14 Offset: 0x23C8C14 VA: 0x23CCC14 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CCC1C Offset: 0x23C8C1C VA: 0x23CCC1C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CCC24 Offset: 0x23C8C24 VA: 0x23CCC24 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CCD88 Offset: 0x23C8D88 VA: 0x23CCD88 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CCEDC Offset: 0x23C8EDC VA: 0x23CCEDC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CD114 Offset: 0x23C9114 VA: 0x23CD114
	public static void Damaged(GameObject actor, PlayerActionManagerBase playerAction, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x23CD428 Offset: 0x23C9428 VA: 0x23CD428 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CD69C Offset: 0x23C969C VA: 0x23CD69C Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CD82C Offset: 0x23C982C VA: 0x23CD82C
	public void .ctor() { }
}
