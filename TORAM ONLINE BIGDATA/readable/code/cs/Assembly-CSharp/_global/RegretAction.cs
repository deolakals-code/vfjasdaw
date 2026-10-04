// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegretAction : PlayerAttackBase // TypeDefIndex: 3737
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23D8BA0 Offset: 0x23D4BA0 VA: 0x23D8BA0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D8BA8 Offset: 0x23D4BA8 VA: 0x23D8BA8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D8BB0 Offset: 0x23D4BB0 VA: 0x23D8BB0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D8BB8 Offset: 0x23D4BB8 VA: 0x23D8BB8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D8BC0 Offset: 0x23D4BC0 VA: 0x23D8BC0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D8BC8 Offset: 0x23D4BC8 VA: 0x23D8BC8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D8BD0 Offset: 0x23D4BD0 VA: 0x23D8BD0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D8BD8 Offset: 0x23D4BD8 VA: 0x23D8BD8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D8BE0 Offset: 0x23D4BE0 VA: 0x23D8BE0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D8BE8 Offset: 0x23D4BE8 VA: 0x23D8BE8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D8D2C Offset: 0x23D4D2C VA: 0x23D8D2C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D8DF4 Offset: 0x23D4DF4 VA: 0x23D8DF4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D8DFC Offset: 0x23D4DFC VA: 0x23D8DFC Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D908C Offset: 0x23D508C VA: 0x23D908C
	public void .ctor() { }
}
