// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct BoneData.BoneTransExMotionData : BoneData.BoneTrans // TypeDefIndex: 5310
{
	// Fields
	private readonly Vector3 pos; // 0x0
	private readonly Vector3 rot; // 0xC
	private readonly Vector3 scale; // 0x18
	private readonly string pBoneName; // 0x28
	private readonly byte index; // 0x30
	private readonly BoneClip clip; // 0x38
	private readonly short len; // 0x40

	// Properties
	public Vector3 position { get; }
	public Vector3 rotation { get; }
	public Vector3 localScale { get; }
	public byte boneIndex { get; }

	// Methods

	// RVA: 0x262C0C8 Offset: 0x26280C8 VA: 0x262C0C8 Slot: 4
	public Vector3 get_position() { }

	// RVA: 0x262C0D4 Offset: 0x26280D4 VA: 0x262C0D4 Slot: 5
	public Vector3 get_rotation() { }

	// RVA: 0x262C0E0 Offset: 0x26280E0 VA: 0x262C0E0 Slot: 6
	public Vector3 get_localScale() { }

	// RVA: 0x262C0EC Offset: 0x26280EC VA: 0x262C0EC Slot: 7
	public byte get_boneIndex() { }

	// RVA: 0x262C0F4 Offset: 0x26280F4 VA: 0x262C0F4 Slot: 8
	public void AddEffectData(GameObject data, Transform[] bones) { }

	// RVA: 0x262B654 Offset: 0x2627654 VA: 0x262B654
	public void .ctor(Vector3 pos, Vector3 rot, Vector3 localScale, byte index, string pBoneName, BoneClip clipData, short len) { }
}
