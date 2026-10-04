// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BoneData // TypeDefIndex: 5313
{
	// Fields
	public Dictionary<string, BoneData.BoneTrans> Bone; // 0x10
	public Dictionary<byte, string> BoneIndex; // 0x18
	public byte RootBoneId; // 0x20
	public Vector3 RenderCenter; // 0x24
	public Vector3 RenderSize; // 0x30

	// Methods

	// RVA: 0x262A0B4 Offset: 0x26260B4 VA: 0x262A0B4
	public bool Load(BinaryReader read) { }

	// RVA: 0x262A360 Offset: 0x2626360 VA: 0x262A360
	public bool LoadDynamicBone(BinaryReader read) { }

	// RVA: 0x262A720 Offset: 0x2626720 VA: 0x262A720
	public bool LoadBillBoardBone(BinaryReader read) { }

	// RVA: 0x262AA50 Offset: 0x2626A50 VA: 0x262AA50
	public bool LoadExMotionBone(BinaryReader read) { }

	// RVA: 0x262B6B0 Offset: 0x26276B0 VA: 0x262B6B0
	public bool LoadRotationBone(BinaryReader read) { }

	// RVA: 0x262BA14 Offset: 0x2627A14 VA: 0x262BA14
	public void .ctor() { }
}
