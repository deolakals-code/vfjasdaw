// Assembly: Assembly-CSharp.dll
// Namespace: 
private class EventAreaManager.TimeEventArea // TypeDefIndex: 3817
{
	// Fields
	private Dictionary<int, EventArea> eventAreaList; // 0x10
	private EventArea insideEventArea; // 0x18
	[CompilerGenerated]
	private float <BaseTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <LeftTime>k__BackingField; // 0x24
	private bool isLeaveReset; // 0x28
	private bool isInfoLoadt; // 0x29

	// Properties
	public float BaseTime { get; set; }
	public float LeftTime { get; set; }
	public Dictionary<int, EventArea> EventAreaList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x23F2268 Offset: 0x23EE268 VA: 0x23F2268
	public float get_BaseTime() { }

	[CompilerGenerated]
	// RVA: 0x23F2270 Offset: 0x23EE270 VA: 0x23F2270
	private void set_BaseTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x23F2278 Offset: 0x23EE278 VA: 0x23F2278
	public float get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x23F2280 Offset: 0x23EE280 VA: 0x23F2280
	private void set_LeftTime(float value) { }

	// RVA: 0x23F2288 Offset: 0x23EE288 VA: 0x23F2288
	public Dictionary<int, EventArea> get_EventAreaList() { }

	// RVA: 0x23F1204 Offset: 0x23ED204 VA: 0x23F1204
	public void .ctor(float time) { }

	// RVA: 0x23F0C30 Offset: 0x23ECC30 VA: 0x23F0C30
	public void .ctor(float time, bool leaveReset) { }

	// RVA: 0x23F00A4 Offset: 0x23EC0A4 VA: 0x23F00A4
	public void Destroy() { }

	// RVA: 0x23EF124 Offset: 0x23EB124 VA: 0x23EF124
	public EventArea Update(Vector3 pos, float rad) { }
}
