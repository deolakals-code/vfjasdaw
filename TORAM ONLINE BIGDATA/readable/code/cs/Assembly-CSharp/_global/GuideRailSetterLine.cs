// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class GuideRailSetterLine : GuideRailSetterBase // TypeDefIndex: 4184
{
	// Properties
	public override GuideRailSetterBase.RailType Type { get; }

	// Methods

	// RVA: 0x24A1CC0 Offset: 0x249DCC0 VA: 0x24A1CC0 Slot: 4
	public override GuideRailSetterBase.RailType get_Type() { }

	// RVA: 0x24A1CC8 Offset: 0x249DCC8 VA: 0x24A1CC8 Slot: 7
	public override void OnWriteGuideRail(BinaryWriter bw) { }

	// RVA: 0x24A1CCC Offset: 0x249DCCC VA: 0x24A1CCC Slot: 9
	public override void OnReadGuideRail(BinaryReader br) { }

	// RVA: 0x24A1CD0 Offset: 0x249DCD0 VA: 0x24A1CD0
	public void .ctor(int newId, int preId, int nxId) { }

	// RVA: 0x24A1D2C Offset: 0x249DD2C VA: 0x24A1D2C Slot: 5
	public override void SetPreviousRailSlope(GuideRailSetterBase preRail) { }

	// RVA: 0x24A1E4C Offset: 0x249DE4C VA: 0x24A1E4C Slot: 6
	public override void SetNextRailSlope(GuideRailSetterBase nxRail) { }

	// RVA: 0x24A1F4C Offset: 0x249DF4C VA: 0x24A1F4C Slot: 10
	public override Vector3 CalcPosition(float dist) { }

	// RVA: 0x24A1FDC Offset: 0x249DFDC VA: 0x24A1FDC Slot: 11
	public override float CalcLength() { }

	// RVA: 0x24A2060 Offset: 0x249E060 VA: 0x24A2060 Slot: 12
	public override Vector3 CalcVec(float dist) { }
}
