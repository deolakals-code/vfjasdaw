// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct BoneData.BoneTransBillBoardData : BoneData.BoneTrans // TypeDefIndex: 5309
{
	// Fields
	private readonly Vector3 pos; // 0x0
	private readonly Vector3 rot; // 0xC
	private readonly Vector3 scale; // 0x18
	private readonly byte index; // 0x24
	private readonly string pBoneName; // 0x28
	private readonly byte flag; // 0x30

	// Properties
	public Vector3 position { get; }
	public Vector3 rotation { get; }
	public Vector3 localScale { get; }
	public byte boneIndex { get; }

	// Methods

	// RVA: 0x262BEA8 Offset: 0x2627EA8 VA: 0x262BEA8 Slot: 4
	public Vector3 get_position() { }

	// RVA: 0x262BEB4 Offset: 0x2627EB4 VA: 0x262BEB4 Slot: 5
	public Vector3 get_rotation() { }

	// RVA: 0x262BEC0 Offset: 0x2627EC0 VA: 0x262BEC0 Slot: 6
	public Vector3 get_localScale() { }

	// RVA: 0x262BECC Offset: 0x2627ECC VA: 0x262BECC Slot: 7
	public byte get_boneIndex() { }

	// RVA: 0x262BED4 Offset: 0x2627ED4 VA: 0x262BED4 Slot: 8
	public void AddEffectData(GameObject data, Transform[] bones) { }

	// RVA: 0x262AA04 Offset: 0x2626A04 VA: 0x262AA04
	public void .ctor(Vector3 pos, Vector3 rot, Vector3 localScale, byte index, byte flag, string pBoneName) { }
}
