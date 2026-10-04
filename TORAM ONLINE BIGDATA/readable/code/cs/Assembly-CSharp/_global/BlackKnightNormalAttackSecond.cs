// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightNormalAttackSecond : BlackKnightPlayerSkillBase // TypeDefIndex: 4243
{
	// Fields
	private bool isBusterBlade; // 0x90
	private BlackKnightPlayerManager playerManager; // 0x98
	private readonly float normalMoveSpeed; // 0xA0
	private bool isAirRush; // 0xA4
	private bool isSpiralAir; // 0xA5

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public override bool IsPermitInputMove { get; }

	// Methods

	// RVA: 0x24B3EAC Offset: 0x24AFEAC VA: 0x24B3EAC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B3EB4 Offset: 0x24AFEB4 VA: 0x24B3EB4 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B3EBC Offset: 0x24AFEBC VA: 0x24B3EBC Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B3EC4 Offset: 0x24AFEC4 VA: 0x24B3EC4 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B3ECC Offset: 0x24AFECC VA: 0x24B3ECC Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B3ED4 Offset: 0x24AFED4 VA: 0x24B3ED4 Slot: 26
	public override bool get_IsPermitInputMove() { }

	// RVA: 0x24B3EE4 Offset: 0x24AFEE4 VA: 0x24B3EE4 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B3EE8 Offset: 0x24AFEE8 VA: 0x24B3EE8 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B40A0 Offset: 0x24B00A0 VA: 0x24B40A0 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B4428 Offset: 0x24B0428 VA: 0x24B4428 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B44B0 Offset: 0x24B04B0 VA: 0x24B44B0 Slot: 17
	protected override void OnEnd() { }

	// RVA: 0x24B44E8 Offset: 0x24B04E8 VA: 0x24B44E8 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24B4638 Offset: 0x24B0638 VA: 0x24B4638
	public void .ctor() { }
}
