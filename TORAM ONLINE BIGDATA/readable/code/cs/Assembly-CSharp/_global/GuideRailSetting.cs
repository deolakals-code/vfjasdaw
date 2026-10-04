// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuideRailSetting : GuideRailSettingBase // TypeDefIndex: 4178
{
	// Properties
	public override GuideRailSettingType HandleType { get; }

	// Methods

	// RVA: 0x24A015C Offset: 0x249C15C VA: 0x24A015C Slot: 17
	public override GuideRailSettingType get_HandleType() { }

	// RVA: 0x24A0158 Offset: 0x249C158 VA: 0x24A0158
	public void .ctor() { }

	// RVA: 0x24A01EC Offset: 0x249C1EC VA: 0x24A01EC Slot: 21
	public override float CalcRate(Vector3 pos, int no) { }

	// RVA: 0x24A06A4 Offset: 0x249C6A4 VA: 0x24A06A4 Slot: 19
	public override Vector3 CalcPosition(float dist) { }

	// RVA: 0x24A08E4 Offset: 0x249C8E4 VA: 0x24A08E4 Slot: 20
	public override float TryMovePosition(float nowDist, float addMove) { }

	// RVA: 0x24A0AF8 Offset: 0x249CAF8 VA: 0x24A0AF8 Slot: 22
	public override Vector3 CalcVec(float dist) { }

	// RVA: 0x24A0D08 Offset: 0x249CD08 VA: 0x24A0D08 Slot: 24
	public override bool GetIsCameraRight(float dist) { }

	// RVA: 0x24A0EB4 Offset: 0x249CEB4 VA: 0x24A0EB4 Slot: 25
	public override float GetCameraDist(float dist) { }

	// RVA: 0x24A1048 Offset: 0x249D048 VA: 0x24A1048 Slot: 26
	public override float GetCameraRot(float dist) { }

	// RVA: 0x24A11DC Offset: 0x249D1DC VA: 0x24A11DC
	public float CalcAllLength() { }

	// RVA: 0x249FD54 Offset: 0x249BD54 VA: 0x249FD54
	public Vector2 GetPositionRailRange(float posLength) { }

	// RVA: 0x249FEEC Offset: 0x249BEEC VA: 0x249FEEC
	public GuideRailSetterBase.RailType GetRailType(float length) { }
}
