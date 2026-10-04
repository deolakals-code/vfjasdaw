// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryTraceTargetState : MercenaryAIStateBase // TypeDefIndex: 650
{
	// Fields
	[CompilerGenerated]
	private BufferingVector3 <Target>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <Range>k__BackingField; // 0x38
	[CompilerGenerated]
	private float <AbandonTime>k__BackingField; // 0x3C
	[CompilerGenerated]
	private float <WarpRange>k__BackingField; // 0x40
	[CompilerGenerated]
	private Action<Vector3> EndCallBack; // 0x48
	protected float SnapShotCounter; // 0x50
	protected Vector3 oldMove; // 0x54
	protected bool isWarp; // 0x60

	// Properties
	protected BufferingVector3 Target { get; set; }
	protected float Range { get; set; }
	protected float AbandonTime { get; set; }
	protected float WarpRange { get; set; }
	public Vector3 OldMove { set; }
	protected virtual float SnapshotDefault { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19E6D98 Offset: 0x19E2D98 VA: 0x19E6D98
	protected BufferingVector3 get_Target() { }

	[CompilerGenerated]
	// RVA: 0x19E6DA0 Offset: 0x19E2DA0 VA: 0x19E6DA0
	public void set_Target(BufferingVector3 value) { }

	[CompilerGenerated]
	// RVA: 0x19E6DA8 Offset: 0x19E2DA8 VA: 0x19E6DA8
	protected float get_Range() { }

	[CompilerGenerated]
	// RVA: 0x19E6DB0 Offset: 0x19E2DB0 VA: 0x19E6DB0
	public void set_Range(float value) { }

	[CompilerGenerated]
	// RVA: 0x19E6DB8 Offset: 0x19E2DB8 VA: 0x19E6DB8
	protected float get_AbandonTime() { }

	[CompilerGenerated]
	// RVA: 0x19E6DC0 Offset: 0x19E2DC0 VA: 0x19E6DC0
	public void set_AbandonTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x19E6DC8 Offset: 0x19E2DC8 VA: 0x19E6DC8
	protected float get_WarpRange() { }

	[CompilerGenerated]
	// RVA: 0x19E6DD0 Offset: 0x19E2DD0 VA: 0x19E6DD0
	public void set_WarpRange(float value) { }

	// RVA: 0x19E6DD8 Offset: 0x19E2DD8 VA: 0x19E6DD8
	public void set_OldMove(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x19E1990 Offset: 0x19DD990 VA: 0x19E1990
	public void add_EndCallBack(Action<Vector3> value) { }

	[CompilerGenerated]
	// RVA: 0x19E6DE4 Offset: 0x19E2DE4 VA: 0x19E6DE4
	public void remove_EndCallBack(Action<Vector3> value) { }

	// RVA: 0x19E6E94 Offset: 0x19E2E94 VA: 0x19E6E94 Slot: 19
	protected virtual float get_SnapshotDefault() { }

	// RVA: 0x19E6E9C Offset: 0x19E2E9C VA: 0x19E6E9C Slot: 15
	public override void LateUpdate() { }

	// RVA: 0x19E6EFC Offset: 0x19E2EFC VA: 0x19E6EFC Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x19E6F00 Offset: 0x19E2F00 VA: 0x19E6F00 Slot: 14
	public override void Dispose() { }

	// RVA: 0x19E6F1C Offset: 0x19E2F1C VA: 0x19E6F1C Slot: 16
	public override void TurnEnd(IAICentral central) { }

	[IteratorStateMachine(typeof(MercenaryTraceTargetState.<GetState>d__30))]
	// RVA: 0x19E7050 Offset: 0x19E3050 VA: 0x19E7050 Slot: 17
	protected override IEnumerator GetState() { }

	// RVA: 0x19E5BE8 Offset: 0x19E1BE8 VA: 0x19E5BE8
	public void .ctor() { }
}
