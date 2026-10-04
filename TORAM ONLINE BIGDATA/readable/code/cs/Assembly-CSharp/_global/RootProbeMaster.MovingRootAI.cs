// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RootProbeMaster.MovingRootAI // TypeDefIndex: 3999
{
	// Fields
	private readonly RootProbeMaster master; // 0x10
	[CompilerGenerated]
	private bool <IsGoal>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <CurrentProbe>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <GoalProbe>k__BackingField; // 0x1A
	private Vector3 shakePos; // 0x1C

	// Properties
	public bool IsGoal { get; set; }
	public byte CurrentProbe { get; set; }
	public byte GoalProbe { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x246D978 Offset: 0x2469978 VA: 0x246D978
	public bool get_IsGoal() { }

	[CompilerGenerated]
	// RVA: 0x246D980 Offset: 0x2469980 VA: 0x246D980
	private void set_IsGoal(bool value) { }

	[CompilerGenerated]
	// RVA: 0x246D98C Offset: 0x246998C VA: 0x246D98C
	public byte get_CurrentProbe() { }

	[CompilerGenerated]
	// RVA: 0x246D994 Offset: 0x2469994 VA: 0x246D994
	private void set_CurrentProbe(byte value) { }

	[CompilerGenerated]
	// RVA: 0x246D99C Offset: 0x246999C VA: 0x246D99C
	public byte get_GoalProbe() { }

	[CompilerGenerated]
	// RVA: 0x246D9A4 Offset: 0x24699A4 VA: 0x246D9A4
	private void set_GoalProbe(byte value) { }

	// RVA: 0x246D9AC Offset: 0x24699AC VA: 0x246D9AC
	public void .ctor(RootProbeMaster master) { }

	// RVA: 0x246DA20 Offset: 0x2469A20 VA: 0x246DA20
	public void SetGoalProbe(byte goalProbe, Vector3 pos) { }

	// RVA: 0x246DC10 Offset: 0x2469C10 VA: 0x246DC10
	public Vector3 MoveProbePosition() { }

	// RVA: 0x246DC70 Offset: 0x2469C70 VA: 0x246DC70
	public bool CheckNextProbe(Vector3 pos) { }
}
