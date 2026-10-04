// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobBattleAI : MobAIBase // TypeDefIndex: 706
{
	// Fields
	private PlayerDataManager player; // 0x40
	private int currentCommandId; // 0x48
	private int nextCommandId; // 0x4C
	private CharacterActionManagerBase targetActionManager; // 0x50
	private float aiWait; // 0x58
	private Vector3 lastPos; // 0x5C
	private int stopCount; // 0x68
	private bool nearMove; // 0x6C
	private bool isDelayWait; // 0x6D
	private float giveupTime; // 0x70
	private bool isGuildRaid; // 0x74

	// Properties
	public bool IsHeightLimit { get; }
	public int CurrentCommandId { get; }
	public int NextCommandId { get; }

	// Methods

	// RVA: 0x1AC811C Offset: 0x1AC411C VA: 0x1AC811C
	public bool get_IsHeightLimit() { }

	// RVA: 0x1AC8144 Offset: 0x1AC4144 VA: 0x1AC8144
	public int get_CurrentCommandId() { }

	// RVA: 0x1AC814C Offset: 0x1AC414C VA: 0x1AC814C
	public int get_NextCommandId() { }

	// RVA: 0x1AC8154 Offset: 0x1AC4154 VA: 0x1AC8154 Slot: 9
	public override void OnChangeTarget(GameObject target) { }

	// RVA: 0x1AC8204 Offset: 0x1AC4204 VA: 0x1AC8204 Slot: 6
	public override void AIUpdate() { }

	// RVA: 0x1AC8FF8 Offset: 0x1AC4FF8 VA: 0x1AC8FF8 Slot: 7
	public override void SetNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1AC9FD4 Offset: 0x1AC5FD4 VA: 0x1AC9FD4 Slot: 8
	public override void SetChangeHyperModeNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1ACA160 Offset: 0x1AC6160 VA: 0x1ACA160 Slot: 10
	public override void OnActionCancel() { }

	// RVA: 0x1ACA18C Offset: 0x1AC618C VA: 0x1ACA18C Slot: 11
	public override void OnActionEnd() { }

	// RVA: 0x1ACA1BC Offset: 0x1AC61BC VA: 0x1ACA1BC
	public void RetransAction() { }

	// RVA: 0x1ACA230 Offset: 0x1AC6230 VA: 0x1ACA230 Slot: 5
	protected override void OnInitialize() { }

	// RVA: 0x1AC8580 Offset: 0x1AC4580 VA: 0x1AC8580
	private bool InvokeNextAction() { }

	// RVA: 0x1AC85E4 Offset: 0x1AC45E4 VA: 0x1AC85E4
	private void CheckAction() { }

	// RVA: 0x1ACA31C Offset: 0x1AC631C VA: 0x1ACA31C
	private void SelectAction() { }

	// RVA: 0x1AC8938 Offset: 0x1AC4938 VA: 0x1AC8938
	private void PersonaNegligence(bool reset) { }

	// RVA: 0x1AC8A50 Offset: 0x1AC4A50 VA: 0x1AC8A50
	private void PersonaMoody() { }

	// RVA: 0x1AC9120 Offset: 0x1AC5120 VA: 0x1AC9120
	private void PersonaFree(MobAttackBase mobAttack) { }

	// RVA: 0x1AC9B50 Offset: 0x1AC5B50 VA: 0x1AC9B50
	private void PersonaCapricious(MobAttackBase mobAttack) { }

	// RVA: 0x1AC95A8 Offset: 0x1AC55A8 VA: 0x1AC95A8
	private void PersonaStubborn(MobAttackBase mobAttack) { }

	// RVA: 0x1ACAC90 Offset: 0x1AC6C90 VA: 0x1ACAC90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1ACACF0 Offset: 0x1AC6CF0 VA: 0x1ACACF0
	private void <CheckAction>b__26_0() { }
}
