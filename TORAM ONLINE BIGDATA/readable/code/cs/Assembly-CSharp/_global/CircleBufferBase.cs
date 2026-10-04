// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class CircleBufferBase : SkillBufferDataBase // TypeDefIndex: 3099
{
	// Fields
	private const float CheckInterval = 3;
	protected List<Transform> targetList; // 0x20
	protected float range; // 0x28
	private float intervalTime; // 0x2C
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <IsUpdate>k__BackingField; // 0x31

	// Properties
	public float Range { get; }
	public byte LocalId { get; set; }
	public bool IsUpdate { get; set; }
	public override bool IsRange { get; }
	public virtual bool IsPlace { get; }

	// Methods

	// RVA: 0x2322534 Offset: 0x231E534 VA: 0x2322534
	public float get_Range() { }

	[CompilerGenerated]
	// RVA: 0x232253C Offset: 0x231E53C VA: 0x232253C
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x2322544 Offset: 0x231E544 VA: 0x2322544
	private void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x232254C Offset: 0x231E54C VA: 0x232254C
	public bool get_IsUpdate() { }

	[CompilerGenerated]
	// RVA: 0x2322554 Offset: 0x231E554 VA: 0x2322554
	private void set_IsUpdate(bool value) { }

	// RVA: 0x2322560 Offset: 0x231E560 VA: 0x2322560 Slot: 6
	public override bool get_IsRange() { }

	// RVA: 0x2322568 Offset: 0x231E568 VA: 0x2322568 Slot: 21
	public virtual bool get_IsPlace() { }

	// RVA: 0x23212C4 Offset: 0x231D2C4 VA: 0x23212C4
	public void .ctor(byte lv, bool self, float time) { }

	// RVA: 0x2322570 Offset: 0x231E570 VA: 0x2322570
	public void SetLocalId(byte id) { }

	// RVA: 0x2322584 Offset: 0x231E584 VA: 0x2322584 Slot: 11
	public override void Updata() { }

	// RVA: 0x2322668 Offset: 0x231E668 VA: 0x2322668
	public void UpdateClear() { }

	// RVA: 0x2322670 Offset: 0x231E670 VA: 0x2322670 Slot: 22
	public virtual bool CheckRange(Transform actor, Transform target, float size) { }

	// RVA: 0x23227D4 Offset: 0x231E7D4 VA: 0x23227D4 Slot: 23
	public virtual bool CheckTestRange(Transform actor, Transform target, float size) { }

	// RVA: 0x2322868 Offset: 0x231E868 VA: 0x2322868
	public bool CheckTarget(Transform target) { }
}
