// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct BoneData.BoneTransRotationData : BoneData.BoneTrans // TypeDefIndex: 5312
{
	// Fields
	private readonly Vector3 pos; // 0x0
	private readonly Vector3 rot; // 0xC
	private readonly Vector3 scale; // 0x18
	private readonly Vector3 animationRotation; // 0x24
	private readonly float loopTimer; // 0x30
	private readonly byte index; // 0x34
	private readonly string pBoneName; // 0x38

	// Properties
	public Vector3 position { get; }
	public Vector3 rotation { get; }
	public Vector3 localScale { get; }
	public byte boneIndex { get; }

	// Methods

	// RVA: 0x262C0F8 Offset: 0x26280F8 VA: 0x262C0F8 Slot: 4
	public Vector3 get_position() { }

	// RVA: 0x262C104 Offset: 0x2628104 VA: 0x262C104 Slot: 5
	public Vector3 get_rotation() { }

	// RVA: 0x262C110 Offset: 0x2628110 VA: 0x262C110 Slot: 6
	public Vector3 get_localScale() { }

	// RVA: 0x262C11C Offset: 0x262811C VA: 0x262C11C Slot: 7
	public byte get_boneIndex() { }

	// RVA: 0x262C124 Offset: 0x2628124 VA: 0x262C124 Slot: 8
	public void AddEffectData(GameObject data, Transform[] bones) { }

	// RVA: 0x262B9B0 Offset: 0x26279B0 VA: 0x262B9B0
	public void .ctor(Vector3 pos, Vector3 rot, Vector3 localScale, byte index, string pBoneName, float rotX, float rotY, float rotZ, float loop) { }
}
