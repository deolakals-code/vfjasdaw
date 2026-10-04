// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightNormalAttackVertical : BlackKnightPlayerSkillBase // TypeDefIndex: 4244
{
	// Fields
	[CompilerGenerated]
	private bool <IsInvokeSecondAttack>k__BackingField; // 0x90
	private bool isBusterBlade; // 0x91
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
	public bool IsInvokeSecondAttack { get; set; }

	// Methods

	// RVA: 0x24B4648 Offset: 0x24B0648 VA: 0x24B4648 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B4650 Offset: 0x24B0650 VA: 0x24B4650 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B4658 Offset: 0x24B0658 VA: 0x24B4658 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B4660 Offset: 0x24B0660 VA: 0x24B4660 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B4668 Offset: 0x24B0668 VA: 0x24B4668 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B4670 Offset: 0x24B0670 VA: 0x24B4670 Slot: 26
	public override bool get_IsPermitInputMove() { }

	[CompilerGenerated]
	// RVA: 0x24B4680 Offset: 0x24B0680 VA: 0x24B4680
	public bool get_IsInvokeSecondAttack() { }

	[CompilerGenerated]
	// RVA: 0x24B4688 Offset: 0x24B0688 VA: 0x24B4688
	public void set_IsInvokeSecondAttack(bool value) { }

	// RVA: 0x24B4694 Offset: 0x24B0694 VA: 0x24B4694 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B469C Offset: 0x24B069C VA: 0x24B469C Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B4858 Offset: 0x24B0858 VA: 0x24B4858 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B4D68 Offset: 0x24B0D68 VA: 0x24B4D68 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B4DF0 Offset: 0x24B0DF0 VA: 0x24B4DF0 Slot: 17
	protected override void OnEnd() { }

	// RVA: 0x24B4E10 Offset: 0x24B0E10 VA: 0x24B4E10 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24B4F84 Offset: 0x24B0F84 VA: 0x24B4F84
	public void .ctor() { }
}
