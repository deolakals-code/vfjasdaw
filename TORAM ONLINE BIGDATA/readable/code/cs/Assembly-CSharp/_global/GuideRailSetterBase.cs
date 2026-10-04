// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public abstract class GuideRailSetterBase // TypeDefIndex: 4183
{
	// Fields
	[SerializeField]
	private int id; // 0x10
	[SerializeField]
	private int nextId; // 0x14
	[SerializeField]
	private int previousId; // 0x18
	[SerializeField]
	protected Vector3 startPoint; // 0x1C
	[SerializeField]
	protected Vector3 endPoint; // 0x28
	[SerializeField]
	protected float moveTime; // 0x34
	[SerializeField]
	private bool isCameraRight; // 0x38
	private float cameraDist; // 0x3C
	private float cameraRot; // 0x40
	private const float allowanceVal = 0.001;
	protected float length; // 0x44
	[CompilerGenerated]
	private bool <IsAutoStartPosition>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsAutoEndPosition>k__BackingField; // 0x49
	[CompilerGenerated]
	private bool <IsAutoPreviousRailSlope>k__BackingField; // 0x4A
	[CompilerGenerated]
	private bool <IsAutoNextRailSlope>k__BackingField; // 0x4B
	[CompilerGenerated]
	private bool <IsInsertRail>k__BackingField; // 0x4C
	[CompilerGenerated]
	private bool <IsDelete>k__BackingField; // 0x4D

	// Properties
	public int Id { get; }
	public int NextId { get; }
	public int PreviousId { get; }
	public Vector3 StartPoint { get; }
	public Vector3 EndPoint { get; }
	public bool IsAutoStartPosition { get; set; }
	public bool IsAutoEndPosition { get; set; }
	public bool IsAutoPreviousRailSlope { get; set; }
	public bool IsAutoNextRailSlope { get; set; }
	public bool IsInsertRail { get; set; }
	public bool IsDelete { get; set; }
	public bool IsCameraRight { get; }
	public float CameraDist { get; }
	public float CameraRot { get; }
	public int MoveEndFrame { get; }
	public float MoveTime { get; }
	public float Length { get; }
	public abstract GuideRailSetterBase.RailType Type { get; }

	// Methods

	// RVA: 0x24A157C Offset: 0x249D57C VA: 0x24A157C
	public int get_Id() { }

	// RVA: 0x24A1584 Offset: 0x249D584 VA: 0x24A1584
	public int get_NextId() { }

	// RVA: 0x24A158C Offset: 0x249D58C VA: 0x24A158C
	public int get_PreviousId() { }

	// RVA: 0x24A1594 Offset: 0x249D594 VA: 0x24A1594
	public Vector3 get_StartPoint() { }

	// RVA: 0x24A15A0 Offset: 0x249D5A0 VA: 0x24A15A0
	public Vector3 get_EndPoint() { }

	[CompilerGenerated]
	// RVA: 0x24A15AC Offset: 0x249D5AC VA: 0x24A15AC
	public bool get_IsAutoStartPosition() { }

	[CompilerGenerated]
	// RVA: 0x24A15B4 Offset: 0x249D5B4 VA: 0x24A15B4
	private void set_IsAutoStartPosition(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A15C0 Offset: 0x249D5C0 VA: 0x24A15C0
	public bool get_IsAutoEndPosition() { }

	[CompilerGenerated]
	// RVA: 0x24A15C8 Offset: 0x249D5C8 VA: 0x24A15C8
	private void set_IsAutoEndPosition(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A15D4 Offset: 0x249D5D4 VA: 0x24A15D4
	public bool get_IsAutoPreviousRailSlope() { }

	[CompilerGenerated]
	// RVA: 0x24A15DC Offset: 0x249D5DC VA: 0x24A15DC
	private void set_IsAutoPreviousRailSlope(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A15E8 Offset: 0x249D5E8 VA: 0x24A15E8
	public bool get_IsAutoNextRailSlope() { }

	[CompilerGenerated]
	// RVA: 0x24A15F0 Offset: 0x249D5F0 VA: 0x24A15F0
	private void set_IsAutoNextRailSlope(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A15FC Offset: 0x249D5FC VA: 0x24A15FC
	public bool get_IsInsertRail() { }

	[CompilerGenerated]
	// RVA: 0x24A1604 Offset: 0x249D604 VA: 0x24A1604
	private void set_IsInsertRail(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24A1610 Offset: 0x249D610 VA: 0x24A1610
	public bool get_IsDelete() { }

	[CompilerGenerated]
	// RVA: 0x24A1618 Offset: 0x249D618 VA: 0x24A1618
	private void set_IsDelete(bool value) { }

	// RVA: 0x24A1624 Offset: 0x249D624 VA: 0x24A1624
	public bool get_IsCameraRight() { }

	// RVA: 0x24A162C Offset: 0x249D62C VA: 0x24A162C
	public float get_CameraDist() { }

	// RVA: 0x24A1634 Offset: 0x249D634 VA: 0x24A1634
	public float get_CameraRot() { }

	// RVA: 0x24A163C Offset: 0x249D63C VA: 0x24A163C
	public int get_MoveEndFrame() { }

	// RVA: 0x24A1664 Offset: 0x249D664 VA: 0x24A1664
	public float get_MoveTime() { }

	// RVA: 0x24A08B4 Offset: 0x249C8B4 VA: 0x24A08B4
	public float get_Length() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GuideRailSetterBase.RailType get_Type();

	// RVA: 0x24A166C Offset: 0x249D66C VA: 0x24A166C
	public void .ctor(int newId, int preId, int nxId) { }

	// RVA: 0x24A16C8 Offset: 0x249D6C8 VA: 0x24A16C8
	public void SetStartPoint(Vector3 pos) { }

	// RVA: 0x24A16F0 Offset: 0x249D6F0 VA: 0x24A16F0
	public void SetEndPoint(Vector3 pos) { }

	// RVA: 0x24A1718 Offset: 0x249D718 VA: 0x24A1718
	public void SetData(GuideRailSetterBase origin) { }

	// RVA: 0x24A17AC Offset: 0x249D7AC VA: 0x24A17AC
	public void SetData(Vector3 start, Vector3 end, float time, int newId, int preId, int nxId, bool isRight, float dist, float rot) { }

	// RVA: 0x24A17F4 Offset: 0x249D7F4 VA: 0x24A17F4
	public void SetId(int newId, int preId, int nxId) { }

	// RVA: 0x24A1800 Offset: 0x249D800 VA: 0x24A1800
	public void SetId(int newId) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetPreviousRailSlope(GuideRailSetterBase preRail);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetNextRailSlope(GuideRailSetterBase nxRail);

	// RVA: 0x24A0320 Offset: 0x249C320 VA: 0x24A0320
	public float CalcRate(Vector3 pos) { }

	// RVA: 0x24A1808 Offset: 0x249D808 VA: 0x24A1808
	public void WriteGuideRail(BinaryWriter bw) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnWriteGuideRail(BinaryWriter bw);

	// RVA: 0x24A1A40 Offset: 0x249DA40 VA: 0x24A1A40 Slot: 8
	public virtual void ReadGuideRail(BinaryReader br, int ver) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnReadGuideRail(BinaryReader br);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Vector3 CalcPosition(float dist);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract float CalcLength();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract Vector3 CalcVec(float dist);
}
