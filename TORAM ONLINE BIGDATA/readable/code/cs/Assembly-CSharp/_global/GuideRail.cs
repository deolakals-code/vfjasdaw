// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuideRail // TypeDefIndex: 4177
{
	// Fields
	private readonly int version; // 0x10
	private IGuideRailSetting guideRails; // 0x18
	private const float offset = 0.0001;

	// Methods

	// RVA: 0x24978A0 Offset: 0x24938A0 VA: 0x24978A0
	public void .ctor() { }

	// RVA: 0x249F9B0 Offset: 0x249B9B0 VA: 0x249F9B0
	public bool GetIsCameraRight(float dist) { }

	// RVA: 0x249FA74 Offset: 0x249BA74 VA: 0x249FA74
	public float GetCameraDist(float dist) { }

	// RVA: 0x249FB38 Offset: 0x249BB38 VA: 0x249FB38
	public float GetCameraRot(float dist) { }

	// RVA: 0x24920F0 Offset: 0x248E0F0 VA: 0x24920F0
	public Vector3 GetRailVec(float origin, GuideRailSettingType searchType = 0) { }

	// RVA: 0x249826C Offset: 0x249426C VA: 0x249826C
	public Vector3 GetEdgePointPos(bool isStart, GuideRailSettingType searchType = 0) { }

	// RVA: 0x249293C Offset: 0x248E93C VA: 0x249293C
	public float TryGetPosition(float nowDist, float addMove) { }

	// RVA: 0x2491FF8 Offset: 0x248DFF8 VA: 0x2491FF8
	public Vector3 GetPosition(float origin, GuideRailSettingType type) { }

	// RVA: 0x249FBFC Offset: 0x249BBFC VA: 0x249FBFC
	public float GetAllLength(GuideRailSettingType searchType = 0) { }

	// RVA: 0x249FCAC Offset: 0x249BCAC VA: 0x249FCAC
	public Vector2 GetRailDataRange(float objectPosition) { }

	// RVA: 0x2493118 Offset: 0x248F118 VA: 0x2493118
	public GuideRailSetterBase.RailType GetRailType(float length) { }

	// RVA: 0x2496CF8 Offset: 0x2492CF8 VA: 0x2496CF8
	public void StartBossBattle() { }

	// RVA: 0x2497938 Offset: 0x2493938 VA: 0x2497938
	public void ReadGuideRail(byte[] text) { }

	// RVA: 0x24A0108 Offset: 0x249C108 VA: 0x24A0108
	private GuideRailSettingBase CreateGuideRailSettings() { }

	// RVA: 0x24A00D8 Offset: 0x249C0D8 VA: 0x24A00D8
	private void Initialize() { }
}
