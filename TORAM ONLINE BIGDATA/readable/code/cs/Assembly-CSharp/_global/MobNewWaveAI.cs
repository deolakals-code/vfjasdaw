// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobNewWaveAI : MobServerAIBase // TypeDefIndex: 717
{
	// Fields
	protected static readonly float StageLine; // 0x0
	private MobActionPattern currentPattern; // 0x60
	private bool isAttackControl; // 0x68
	private bool isEventAttack; // 0x69
	private float checkTimer; // 0x6C
	private float nextRotationTimer; // 0x70
	private object syncData; // 0x78
	private bool nextServerAttack; // 0x80
	private bool gameEnd; // 0x81

	// Methods

	// RVA: 0x1B8D488 Offset: 0x1B89488 VA: 0x1B8D488
	public void .ctor() { }

	// RVA: 0x1B8D59C Offset: 0x1B8959C VA: 0x1B8D59C Slot: 6
	public override void AIUpdate() { }

	// RVA: 0x1B8DF1C Offset: 0x1B89F1C VA: 0x1B8DF1C Slot: 13
	public override bool CheckChangeEnemy(GameObject target) { }

	// RVA: 0x1B8DF24 Offset: 0x1B89F24 VA: 0x1B8DF24 Slot: 10
	public override void OnActionCancel() { }

	// RVA: 0x1B8DF54 Offset: 0x1B89F54 VA: 0x1B8DF54 Slot: 11
	public override void OnActionEnd() { }

	// RVA: 0x1B8DF8C Offset: 0x1B89F8C VA: 0x1B8DF8C Slot: 7
	public override void SetNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1B8E5FC Offset: 0x1B8A5FC VA: 0x1B8E5FC Slot: 8
	public override void SetChangeHyperModeNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1B8E668 Offset: 0x1B8A668 VA: 0x1B8E668
	public void SetAttackControl(bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1B8D6C4 Offset: 0x1B896C4 VA: 0x1B8D6C4
	private void Natural() { }

	// RVA: 0x1B8E684 Offset: 0x1B8A684 VA: 0x1B8E684
	private void TargetAttack() { }

	// RVA: 0x1B8D6E8 Offset: 0x1B896E8 VA: 0x1B8D6E8
	private void Move() { }

	// RVA: 0x1B8DCD4 Offset: 0x1B89CD4 VA: 0x1B8DCD4
	private bool selectAction() { }

	// RVA: 0x1B8E4E0 Offset: 0x1B8A4E0 VA: 0x1B8E4E0
	private bool ReserveAction(MobAttackBase mobAttack) { }

	// RVA: 0x1B8E714 Offset: 0x1B8A714 VA: 0x1B8E714
	private static void .cctor() { }
}
