// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class BlackKnightNormalAttackHelmetSplit : BlackKnightPlayerSkillBase // TypeDefIndex: 4242
{
	// Fields
	private BlackKnightPlayerManager playerManager; // 0x90
	private bool isMeteorBreaker; // 0x98
	private bool isEndMeteorBreakerEffect; // 0x99
	private bool isUpSpeed; // 0x9A
	private SkillLinkedTake hitCheckTake; // 0xA0
	private float endTimer; // 0xA8
	private readonly float forceEndTime; // 0xAC
	private float beforePlayerPosY; // 0xB0

	// Properties
	public override int ActionID { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsUseMp { get; }
	protected override BlackKnightSkillActionBase.AttackType AtkType { get; }
	public override bool IsPermitInputMove { get; }
	public override bool IsPermitDash { get; }

	// Methods

	// RVA: 0x24B3460 Offset: 0x24AF460 VA: 0x24B3460 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x24B3468 Offset: 0x24AF468 VA: 0x24B3468 Slot: 6
	public override bool get_IsInterruptable() { }

	// RVA: 0x24B3470 Offset: 0x24AF470 VA: 0x24B3470 Slot: 7
	public override bool get_IsPlace() { }

	// RVA: 0x24B3478 Offset: 0x24AF478 VA: 0x24B3478 Slot: 23
	public override bool get_IsUseMp() { }

	// RVA: 0x24B3480 Offset: 0x24AF480 VA: 0x24B3480 Slot: 8
	protected override BlackKnightSkillActionBase.AttackType get_AtkType() { }

	// RVA: 0x24B3488 Offset: 0x24AF488 VA: 0x24B3488 Slot: 26
	public override bool get_IsPermitInputMove() { }

	// RVA: 0x24B3490 Offset: 0x24AF490 VA: 0x24B3490 Slot: 28
	public override bool get_IsPermitDash() { }

	// RVA: 0x24B3498 Offset: 0x24AF498 VA: 0x24B3498 Slot: 11
	protected override void OnInitialize(BlackKnightCharacterManagerBase actarAction) { }

	// RVA: 0x24B349C Offset: 0x24AF49C VA: 0x24B349C Slot: 12
	public override void ActionPreparation(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B35AC Offset: 0x24AF5AC VA: 0x24B35AC Slot: 13
	public override void ActionStart(BlackKnightCharacterManagerBase actarAction, GameObject target) { }

	// RVA: 0x24B3854 Offset: 0x24AF854 VA: 0x24B3854 Slot: 15
	public override void ActionSkillEvent(BlackKnightCharacterManagerBase actarAction, int param) { }

	// RVA: 0x24B3D40 Offset: 0x24AFD40 VA: 0x24B3D40 Slot: 19
	protected override void calcPlayerToMobDamage(BlackKnightPlayerManager playerAction, BlackKnightMobManagerBase mobAction) { }

	// RVA: 0x24AF574 Offset: 0x24AB574 VA: 0x24AF574
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24B3E80 Offset: 0x24AFE80 VA: 0x24B3E80
	private bool <ActionSkillEvent>b__25_0(TakePlayer t) { }
}
