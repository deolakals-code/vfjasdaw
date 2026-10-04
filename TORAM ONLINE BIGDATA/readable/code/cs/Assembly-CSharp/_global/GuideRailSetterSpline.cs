// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class GuideRailSetterSpline : GuideRailSetterBase // TypeDefIndex: 4185
{
	// Fields
	[SerializeField]
	protected Vector3 startVector; // 0x50
	[SerializeField]
	private Vector3 endVector; // 0x5C
	[SerializeField]
	private float startVecLength; // 0x68
	[SerializeField]
	private float endVecLength; // 0x6C

	// Properties
	public override GuideRailSetterBase.RailType Type { get; }

	// Methods

	// RVA: 0x24A2138 Offset: 0x249E138 VA: 0x24A2138 Slot: 4
	public override GuideRailSetterBase.RailType get_Type() { }

	// RVA: 0x24A2140 Offset: 0x249E140 VA: 0x24A2140
	public void .ctor(int newId, int preId, int nxId) { }

	// RVA: 0x24A219C Offset: 0x249E19C VA: 0x24A219C Slot: 5
	public override void SetPreviousRailSlope(GuideRailSetterBase preRail) { }

	// RVA: 0x24A22B4 Offset: 0x249E2B4 VA: 0x24A22B4 Slot: 6
	public override void SetNextRailSlope(GuideRailSetterBase nxRail) { }

	// RVA: 0x24A23CC Offset: 0x249E3CC VA: 0x24A23CC Slot: 10
	public override Vector3 CalcPosition(float dist) { }

	// RVA: 0x24A2418 Offset: 0x249E418 VA: 0x24A2418
	private Vector3 calcPosition(float rate) { }

	// RVA: 0x24A24B4 Offset: 0x249E4B4 VA: 0x24A24B4 Slot: 11
	public override float CalcLength() { }

	// RVA: 0x24A2604 Offset: 0x249E604 VA: 0x24A2604 Slot: 12
	public override Vector3 CalcVec(float dist) { }

	// RVA: 0x24A27C8 Offset: 0x249E7C8 VA: 0x24A27C8 Slot: 7
	public override void OnWriteGuideRail(BinaryWriter bw) { }

	// RVA: 0x24A28F4 Offset: 0x249E8F4 VA: 0x24A28F4 Slot: 9
	public override void OnReadGuideRail(BinaryReader br) { }
}
