// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightDashAttackSecond : BlackKnightPlayerSkillBase // TypeDefIndex: 4234
{
	// Fields
	[CompilerGenerated]
	private bool <IsAccelBlade>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <IsHitAttack>k__BackingField; // 0x91
	private bool isPermitMove; // 0x92
	private BlackKnightPlayerManager playerManager; // 0x98
	private readonly float moveSpeed; // 0xA0

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	public override bool IsPermitInputMove { get; }
	public bool IsAccelBlade { get; set; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public bool IsHitAttack { get; set; }

	// Methods

	// RVA: 0x24AFF54 Offset: 0x24ABF54 VA: 0x24AFF54 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24AFF5C Offset: 0x24ABF5C VA: 0x24AFF5C Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24AFF64 Offset: 0x24ABF64 VA: 0x24AFF64 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24AFF6C Offset: 0x24ABF6C VA: 0x24AFF6C Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24AFF74 Offset: 0x24ABF74 VA: 0x24AFF74 Slot: 26
	public override bool get_IsPermitInputMove() { }

	[CompilerGenerated]
	// RVA: 0x24AFF7C Offset: 0x24ABF7C VA: 0x24AFF7C
	public bool get_IsAccelBlade() { }

	[CompilerGenerated]
	// RVA: 0x24AFF84 Offset: 0x24ABF84 VA: 0x24AFF84
	private void set_IsAccelBlade(bool value) { }

	// RVA: 0x24AFF90 Offset: 0x24ABF90 VA: 0x24AFF90 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	[CompilerGenerated]
	// RVA: 0x24AFF98 Offset: 0x24ABF98 VA: 0x24AFF98
	public bool get_IsHitAttack() { }

	[CompilerGenerated]
	// RVA: 0x24AFFA0 Offset: 0x24ABFA0 VA: 0x24AFFA0
	private void set_IsHitAttack(bool value) { }

	// RVA: 0x24AFFAC Offset: 0x24ABFAC VA: 0x24AFFAC Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24AFFB0 Offset: 0x24ABFB0 VA: 0x24AFFB0 Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B0108 Offset: 0x24AC108 VA: 0x24B0108 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B0280 Offset: 0x24AC280 VA: 0x24B0280 Slot: 14
	public override void ActionHit(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B0394 Offset: 0x24AC394 VA: 0x24B0394 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B0434 Offset: 0x24AC434 VA: 0x24B0434 Slot: 17
	protected override void OnEnd() { }

	// RVA: 0x24B0460 Offset: 0x24AC460 VA: 0x24B0460 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF658 Offset: 0x24AB658 VA: 0x24AF658
	public void .ctor() { }
}
