// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightMagicImpact : BlackKnightPlayerSkillBase // TypeDefIndex: 4238
{
	// Fields
	private bool isExplode; // 0x90
	private bool isImpactDash; // 0x91

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }

	// Methods

	// RVA: 0x24B1E08 Offset: 0x24ADE08 VA: 0x24B1E08 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B1E10 Offset: 0x24ADE10 VA: 0x24B1E10 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B1E18 Offset: 0x24ADE18 VA: 0x24B1E18 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B1E20 Offset: 0x24ADE20 VA: 0x24B1E20 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B1E28 Offset: 0x24ADE28 VA: 0x24B1E28 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B1E30 Offset: 0x24ADE30 VA: 0x24B1E30 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B1ED0 Offset: 0x24ADED0 VA: 0x24B1ED0 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B1EDC Offset: 0x24ADEDC VA: 0x24B1EDC Slot: 29
	public override GameObject GetTarget(BlackKnightMobObjectManager mobObjManager) { }

	// RVA: 0x24B1EE4 Offset: 0x24ADEE4 VA: 0x24B1EE4 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B2114 Offset: 0x24AE114 VA: 0x24B2114 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF644 Offset: 0x24AB644 VA: 0x24AF644
	public void .ctor() { }
}
