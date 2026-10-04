// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightContactImpact : BlackKnightPlayerSkillBase // TypeDefIndex: 4236
{
	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public override bool IsPermitInputMove { get; }

	// Methods

	// RVA: 0x24B0F7C Offset: 0x24ACF7C VA: 0x24B0F7C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B0F84 Offset: 0x24ACF84 VA: 0x24B0F84 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B0F8C Offset: 0x24ACF8C VA: 0x24B0F8C Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B0F94 Offset: 0x24ACF94 VA: 0x24B0F94 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B0F9C Offset: 0x24ACF9C VA: 0x24B0F9C Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B0FA4 Offset: 0x24ACFA4 VA: 0x24B0FA4 Slot: 26
	public override bool get_IsPermitInputMove() { }

	// RVA: 0x24B0FAC Offset: 0x24ACFAC VA: 0x24B0FAC Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B104C Offset: 0x24AD04C VA: 0x24B104C Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B1058 Offset: 0x24AD058 VA: 0x24B1058 Slot: 29
	public override GameObject GetTarget(BlackKnightMobObjectManager mobObjManager) { }

	// RVA: 0x24B1060 Offset: 0x24AD060 VA: 0x24B1060 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B11D0 Offset: 0x24AD1D0 VA: 0x24B11D0 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF648 Offset: 0x24AB648 VA: 0x24AF648
	public void .ctor() { }
}
