// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class GuideRailSettingBase : IGuideRailSetting // TypeDefIndex: 4179
{
	// Fields
	protected int railNum; // 0x10
	protected List<GuideRailSetterBase> guideRails; // 0x18
	protected bool isBossStart; // 0x20
	[CompilerGenerated]
	private float <RailLength>k__BackingField; // 0x24

	// Properties
	public abstract GuideRailSettingType HandleType { get; }
	public int RailNum { get; }
	public float RailLength { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract GuideRailSettingType get_HandleType();

	// RVA: 0x24A1358 Offset: 0x249D358 VA: 0x24A1358 Slot: 5
	public int get_RailNum() { }

	[CompilerGenerated]
	// RVA: 0x24A1360 Offset: 0x249D360 VA: 0x24A1360 Slot: 6
	public float get_RailLength() { }

	[CompilerGenerated]
	// RVA: 0x24A1368 Offset: 0x249D368 VA: 0x24A1368
	private void set_RailLength(float value) { }

	// RVA: 0x24A0164 Offset: 0x249C164 VA: 0x24A0164
	public void .ctor() { }

	// RVA: 0x24A1370 Offset: 0x249D370 VA: 0x24A1370 Slot: 18
	public virtual void AddRailData(GuideRailSetterBase railData) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract Vector3 CalcPosition(float dist);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract float TryMovePosition(float nowDist, float addMove);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract float CalcRate(Vector3 pos, int no);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Vector3 CalcVec(float dist);

	// RVA: 0x24A1490 Offset: 0x249D490 VA: 0x24A1490 Slot: 23
	public virtual bool CheckExistRail(float dist) { }

	// RVA: 0x24A14B0 Offset: 0x249D4B0 VA: 0x24A14B0 Slot: 24
	public virtual bool GetIsCameraRight(float dist) { }

	// RVA: 0x24A14B8 Offset: 0x249D4B8 VA: 0x24A14B8 Slot: 25
	public virtual float GetCameraDist(float dist) { }

	// RVA: 0x24A14C0 Offset: 0x249D4C0 VA: 0x24A14C0 Slot: 26
	public virtual float GetCameraRot(float dist) { }

	// RVA: 0x24A14C8 Offset: 0x249D4C8 VA: 0x24A14C8 Slot: 27
	public virtual float CalcLength(int no) { }

	// RVA: 0x24A1570 Offset: 0x249D570 VA: 0x24A1570 Slot: 28
	public virtual void StartBossBattle() { }
}
