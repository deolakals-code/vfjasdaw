// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightJumpAttack : BlackKnightPlayerSkillBase // TypeDefIndex: 4235
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x90
	private bool isUpDraft; // 0x98
	private bool isEndInvokeSuction; // 0x99

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }

	// Methods

	// RVA: 0x24B0650 Offset: 0x24AC650 VA: 0x24B0650 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B0658 Offset: 0x24AC658 VA: 0x24B0658 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B0660 Offset: 0x24AC660 VA: 0x24B0660 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B0668 Offset: 0x24AC668 VA: 0x24B0668 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B0670 Offset: 0x24AC670 VA: 0x24B0670 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B0678 Offset: 0x24AC678 VA: 0x24B0678 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B0A74 Offset: 0x24ACA74 VA: 0x24B0A74 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B0AE4 Offset: 0x24ACAE4 VA: 0x24B0AE4 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24B0D28 Offset: 0x24ACD28 VA: 0x24B0D28 Slot: 31
	protected override void OnEndFirstHitCheck() { }

	// RVA: 0x24AF664 Offset: 0x24AB664 VA: 0x24AF664
	public void .ctor() { }
}
