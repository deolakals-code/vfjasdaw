// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightDashAttack : BlackKnightPlayerSkillBase // TypeDefIndex: 4232
{
	// Fields
	[CompilerGenerated]
	private bool <IsAccelBlade>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <IsHitAttack>k__BackingField; // 0x91
	[CompilerGenerated]
	private bool <IsInvokeSecondAttack>k__BackingField; // 0x92
	private bool isPermitMove; // 0x93
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
	public override bool IsPermitJump { get; }
	public override bool IsPermitDash { get; }
	public bool IsHitAttack { get; set; }
	public bool IsInvokeSecondAttack { get; set; }

	// Methods

	// RVA: 0x24AF668 Offset: 0x24AB668 VA: 0x24AF668 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24AF670 Offset: 0x24AB670 VA: 0x24AF670 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24AF678 Offset: 0x24AB678 VA: 0x24AF678 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24AF680 Offset: 0x24AB680 VA: 0x24AF680 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24AF688 Offset: 0x24AB688 VA: 0x24AF688 Slot: 26
	public override bool get_IsPermitInputMove() { }

	[CompilerGenerated]
	// RVA: 0x24AF690 Offset: 0x24AB690 VA: 0x24AF690
	public bool get_IsAccelBlade() { }

	[CompilerGenerated]
	// RVA: 0x24AF698 Offset: 0x24AB698 VA: 0x24AF698
	private void set_IsAccelBlade(bool value) { }

	// RVA: 0x24AF6A4 Offset: 0x24AB6A4 VA: 0x24AF6A4 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24AF6AC Offset: 0x24AB6AC VA: 0x24AF6AC Slot: 27
	public override bool get_IsPermitJump() { }

	// RVA: 0x24AF6B4 Offset: 0x24AB6B4 VA: 0x24AF6B4 Slot: 28
	public override bool get_IsPermitDash() { }

	[CompilerGenerated]
	// RVA: 0x24AF6BC Offset: 0x24AB6BC VA: 0x24AF6BC
	public bool get_IsHitAttack() { }

	[CompilerGenerated]
	// RVA: 0x24AF6C4 Offset: 0x24AB6C4 VA: 0x24AF6C4
	private void set_IsHitAttack(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24AF6D0 Offset: 0x24AB6D0 VA: 0x24AF6D0
	public bool get_IsInvokeSecondAttack() { }

	[CompilerGenerated]
	// RVA: 0x24AF6D8 Offset: 0x24AB6D8 VA: 0x24AF6D8
	public void set_IsInvokeSecondAttack(bool value) { }

	// RVA: 0x24AF6E4 Offset: 0x24AB6E4 VA: 0x24AF6E4 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24AF6EC Offset: 0x24AB6EC VA: 0x24AF6EC Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24AF848 Offset: 0x24AB848 VA: 0x24AF848 Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24AFB58 Offset: 0x24ABB58 VA: 0x24AFB58 Slot: 14
	public override void ActionHit(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24AFC6C Offset: 0x24ABC6C VA: 0x24AFC6C Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24AFD0C Offset: 0x24ABD0C VA: 0x24AFD0C Slot: 17
	protected override void OnEnd() { }

	// RVA: 0x24AFD40 Offset: 0x24ABD40 VA: 0x24AFD40 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF64C Offset: 0x24AB64C VA: 0x24AF64C
	public void .ctor() { }
}
