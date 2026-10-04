// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class FamiliaCrystalLaserAction : FamiliaSkillBase // TypeDefIndex: 3354
{
	// Fields
	private Vector3 crystalPos; // 0x130
	private IOtherPlayerActionManager otherPlayer; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override SkillChargingType ChargingType { get; }

	// Methods

	// RVA: 0x234A43C Offset: 0x234643C VA: 0x234A43C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x234A444 Offset: 0x2346444 VA: 0x234A444 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x234A44C Offset: 0x234644C VA: 0x234A44C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x234A454 Offset: 0x2346454 VA: 0x234A454 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x234A45C Offset: 0x234645C VA: 0x234A45C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x234A464 Offset: 0x2346464 VA: 0x234A464 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x234A46C Offset: 0x234646C VA: 0x234A46C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x234A474 Offset: 0x2346474 VA: 0x234A474 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x234A47C Offset: 0x234647C VA: 0x234A47C Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x234A484 Offset: 0x2346484 VA: 0x234A484 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x234A59C Offset: 0x234659C VA: 0x234A59C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x234A5C0 Offset: 0x23465C0 VA: 0x234A5C0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x234AA74 Offset: 0x2346A74 VA: 0x234AA74 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x234ACE0 Offset: 0x2346CE0 VA: 0x234ACE0
	public void .ctor() { }
}
