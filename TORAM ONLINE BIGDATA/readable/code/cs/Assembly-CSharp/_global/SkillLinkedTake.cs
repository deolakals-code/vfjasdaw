// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillLinkedTake // TypeDefIndex: 361
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <EndTakeId>k__BackingField; // 0x14
	[CompilerGenerated]
	private SkillLinkedTake <NextTakeData>k__BackingField; // 0x18
	[CompilerGenerated]
	private SkillLinkedTake <EventTakeData>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsEventTargetPosition>k__BackingField; // 0x28
	[CompilerGenerated]
	private Vector3 <EventTargetPosition>k__BackingField; // 0x2C
	[CompilerGenerated]
	private Quaternion <EventTargetRotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsChildEventTake>k__BackingField; // 0x48
	private Dictionary<TakeParameterType, int> _parameter; // 0x50

	// Properties
	public int Id { get; set; }
	public int EndTakeId { get; set; }
	public Dictionary<TakeParameterType, int> Parameter { get; }
	public SkillLinkedTake NextTakeData { get; set; }
	public SkillLinkedTake EventTakeData { get; set; }
	public bool IsEventTargetPosition { get; set; }
	public Vector3 EventTargetPosition { get; set; }
	public Quaternion EventTargetRotation { get; set; }
	public bool IsChildEventTake { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x248C408 Offset: 0x2488408 VA: 0x248C408
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x248C410 Offset: 0x2488410 VA: 0x248C410
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x248C418 Offset: 0x2488418 VA: 0x248C418
	public int get_EndTakeId() { }

	[CompilerGenerated]
	// RVA: 0x248C420 Offset: 0x2488420 VA: 0x248C420
	public void set_EndTakeId(int value) { }

	// RVA: 0x248C428 Offset: 0x2488428 VA: 0x248C428
	public Dictionary<TakeParameterType, int> get_Parameter() { }

	[CompilerGenerated]
	// RVA: 0x248C430 Offset: 0x2488430 VA: 0x248C430
	public SkillLinkedTake get_NextTakeData() { }

	[CompilerGenerated]
	// RVA: 0x248C438 Offset: 0x2488438 VA: 0x248C438
	public void set_NextTakeData(SkillLinkedTake value) { }

	[CompilerGenerated]
	// RVA: 0x248C440 Offset: 0x2488440 VA: 0x248C440
	public SkillLinkedTake get_EventTakeData() { }

	[CompilerGenerated]
	// RVA: 0x248C448 Offset: 0x2488448 VA: 0x248C448
	public void set_EventTakeData(SkillLinkedTake value) { }

	[CompilerGenerated]
	// RVA: 0x248C450 Offset: 0x2488450 VA: 0x248C450
	public bool get_IsEventTargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x248C458 Offset: 0x2488458 VA: 0x248C458
	public void set_IsEventTargetPosition(bool value) { }

	[CompilerGenerated]
	// RVA: 0x248C464 Offset: 0x2488464 VA: 0x248C464
	public Vector3 get_EventTargetPosition() { }

	[CompilerGenerated]
	// RVA: 0x248C470 Offset: 0x2488470 VA: 0x248C470
	public void set_EventTargetPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x248C47C Offset: 0x248847C VA: 0x248C47C
	public Quaternion get_EventTargetRotation() { }

	[CompilerGenerated]
	// RVA: 0x248C488 Offset: 0x2488488 VA: 0x248C488
	public void set_EventTargetRotation(Quaternion value) { }

	[CompilerGenerated]
	// RVA: 0x248C494 Offset: 0x2488494 VA: 0x248C494
	public bool get_IsChildEventTake() { }

	[CompilerGenerated]
	// RVA: 0x248C49C Offset: 0x248849C VA: 0x248C49C
	public void set_IsChildEventTake(bool value) { }

	// RVA: 0x248C4A8 Offset: 0x24884A8 VA: 0x248C4A8
	public void .ctor(int id) { }

	// RVA: 0x248C544 Offset: 0x2488544 VA: 0x248C544
	public void .ctor(int id, int endId) { }

	// RVA: 0x248C5E8 Offset: 0x24885E8 VA: 0x248C5E8
	public void ClearEndTake() { }

	// RVA: 0x248C5F4 Offset: 0x24885F4 VA: 0x248C5F4
	public SkillLinkedTake CreateNextTake(int id) { }

	// RVA: 0x248C668 Offset: 0x2488668 VA: 0x248C668
	public SkillLinkedTake CreateNextTake(int id, int endId) { }
}
