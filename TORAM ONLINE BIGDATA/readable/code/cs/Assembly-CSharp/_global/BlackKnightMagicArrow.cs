// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightMagicArrow : BlackKnightPlayerSkillBase // TypeDefIndex: 4237
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x90
	private bool isGatlingArrow; // 0x98
	private readonly float targetRange; // 0x9C

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }

	// Methods

	// RVA: 0x24B12F0 Offset: 0x24AD2F0 VA: 0x24B12F0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B12F8 Offset: 0x24AD2F8 VA: 0x24B12F8 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B1300 Offset: 0x24AD300 VA: 0x24B1300 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B1308 Offset: 0x24AD308 VA: 0x24B1308 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B1310 Offset: 0x24AD310 VA: 0x24B1310 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B1318 Offset: 0x24AD318 VA: 0x24B1318 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B1440 Offset: 0x24AD440 VA: 0x24B1440 Slot: 29
	public override GameObject GetTarget(BlackKnightMobObjectManager mobObjManager) { }

	// RVA: 0x24B1648 Offset: 0x24AD648 VA: 0x24B1648 Slot: 30
	public override int CalcCostMp() { }

	// RVA: 0x24B165C Offset: 0x24AD65C VA: 0x24B165C Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B1C74 Offset: 0x24ADC74 VA: 0x24B1C74 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B1C78 Offset: 0x24ADC78 VA: 0x24B1C78 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B1C7C Offset: 0x24ADC7C VA: 0x24B1C7C Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF59C Offset: 0x24AB59C VA: 0x24AF59C
	public void .ctor() { }
}
