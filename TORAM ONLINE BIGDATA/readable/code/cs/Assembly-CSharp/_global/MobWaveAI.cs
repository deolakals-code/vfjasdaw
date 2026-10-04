// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobWaveAI : MobServerAIBase // TypeDefIndex: 719
{
	// Fields
	private MobActionPattern currentPattern; // 0x60
	private CharacterActionManagerBase targetActionManager; // 0x68
	private bool isAttackControl; // 0x70
	private bool isEventAttack; // 0x71
	private object syncData; // 0x78
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x80

	// Properties
	public int TargetId { get; set; }
	public override bool IsCurrentPattern { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B8EB40 Offset: 0x1B8AB40 VA: 0x1B8EB40
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x1B8EB48 Offset: 0x1B8AB48 VA: 0x1B8EB48
	private void set_TargetId(int value) { }

	// RVA: 0x1B8EB50 Offset: 0x1B8AB50 VA: 0x1B8EB50 Slot: 12
	public override bool get_IsCurrentPattern() { }

	// RVA: 0x1B8EC48 Offset: 0x1B8AC48 VA: 0x1B8EC48
	public void .ctor() { }

	// RVA: 0x1B8ED80 Offset: 0x1B8AD80 VA: 0x1B8ED80
	public void SetAttackControl(bool isAttackControl, int targetId, bool isEventAttack) { }

	// RVA: 0x1B8ED98 Offset: 0x1B8AD98 VA: 0x1B8ED98 Slot: 9
	public override void OnChangeTarget(GameObject target) { }

	// RVA: 0x1B8EE48 Offset: 0x1B8AE48 VA: 0x1B8EE48 Slot: 6
	public override void AIUpdate() { }

	// RVA: 0x1B8EF14 Offset: 0x1B8AF14 VA: 0x1B8EF14 Slot: 13
	public override bool CheckChangeEnemy(GameObject target) { }

	// RVA: 0x1B8EF1C Offset: 0x1B8AF1C VA: 0x1B8EF1C Slot: 10
	public override void OnActionCancel() { }

	// RVA: 0x1B8EF88 Offset: 0x1B8AF88 VA: 0x1B8EF88 Slot: 11
	public override void OnActionEnd() { }

	// RVA: 0x1B8EFC0 Offset: 0x1B8AFC0 VA: 0x1B8EFC0 Slot: 7
	public override void SetNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1B8F148 Offset: 0x1B8B148 VA: 0x1B8F148 Slot: 8
	public override void SetChangeHyperModeNextAction(MobActionPattern nextAction) { }

	// RVA: 0x1B8F1B4 Offset: 0x1B8B1B4 VA: 0x1B8F1B4 Slot: 5
	protected override void OnInitialize() { }

	// RVA: 0x1B8EE98 Offset: 0x1B8AE98 VA: 0x1B8EE98
	private bool CheckNaturalAnimation() { }

	// RVA: 0x1B8F1C4 Offset: 0x1B8B1C4 VA: 0x1B8F1C4
	private void Natural() { }

	// RVA: 0x1B8F1E8 Offset: 0x1B8B1E8 VA: 0x1B8F1E8
	private void Move() { }

	// RVA: 0x1B8F20C Offset: 0x1B8B20C VA: 0x1B8F20C
	private void TargetAttack() { }

	// RVA: 0x1B8F25C Offset: 0x1B8B25C VA: 0x1B8F25C
	private bool selectAction() { }

	// RVA: 0x1B8F02C Offset: 0x1B8B02C VA: 0x1B8F02C
	private bool ReserveAction(MobAttackBase mobAttack) { }
}
