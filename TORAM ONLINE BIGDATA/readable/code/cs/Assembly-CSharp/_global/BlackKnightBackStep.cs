// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightBackStep : BlackKnightPlayerSkillBase // TypeDefIndex: 4240
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x90
	private float motionEndTime; // 0x98
	private float motionTimer; // 0x9C
	private readonly float baseSpeed; // 0xA0

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public override bool IsPermitInputMove { get; }
	public override bool IsPermitJump { get; }
	public override bool IsPermitDash { get; }

	// Methods

	// RVA: 0x24B2C18 Offset: 0x24AEC18 VA: 0x24B2C18 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B2C20 Offset: 0x24AEC20 VA: 0x24B2C20 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B2C28 Offset: 0x24AEC28 VA: 0x24B2C28 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B2C30 Offset: 0x24AEC30 VA: 0x24B2C30 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B2C38 Offset: 0x24AEC38 VA: 0x24B2C38 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B2C40 Offset: 0x24AEC40 VA: 0x24B2C40 Slot: 26
	public override bool get_IsPermitInputMove() { }

	// RVA: 0x24B2C48 Offset: 0x24AEC48 VA: 0x24B2C48 Slot: 27
	public override bool get_IsPermitJump() { }

	// RVA: 0x24B2C50 Offset: 0x24AEC50 VA: 0x24B2C50 Slot: 28
	public override bool get_IsPermitDash() { }

	// RVA: 0x24B2C58 Offset: 0x24AEC58 VA: 0x24B2C58 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B2C5C Offset: 0x24AEC5C VA: 0x24B2C5C Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B2D84 Offset: 0x24AED84 VA: 0x24B2D84 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B2D88 Offset: 0x24AED88 VA: 0x24B2D88 Slot: 17
	protected override void OnEnd() { }

	// RVA: 0x24B2DA8 Offset: 0x24AEDA8 VA: 0x24B2DA8 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B2E68 Offset: 0x24AEE68 VA: 0x24B2E68
	private float CalcDashMoveSpeed() { }

	// RVA: 0x24B2EA0 Offset: 0x24AEEA0 VA: 0x24B2EA0 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF588 Offset: 0x24AB588 VA: 0x24AF588
	public void .ctor() { }
}
