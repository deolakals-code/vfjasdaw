// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct BoneData.BoneTransData : BoneData.BoneTrans // TypeDefIndex: 5305
{
	// Fields
	private readonly Vector3 pos; // 0x0
	private readonly Vector3 rot; // 0xC
	private readonly Vector3 scale; // 0x18
	private readonly byte index; // 0x24

	// Properties
	public Vector3 position { get; }
	public Vector3 rotation { get; }
	public Vector3 localScale { get; }
	public byte boneIndex { get; }

	// Methods

	// RVA: 0x262BB6C Offset: 0x2627B6C VA: 0x262BB6C Slot: 4
	public Vector3 get_position() { }

	// RVA: 0x262BB78 Offset: 0x2627B78 VA: 0x262BB78 Slot: 5
	public Vector3 get_rotation() { }

	// RVA: 0x262BB84 Offset: 0x2627B84 VA: 0x262BB84 Slot: 6
	public Vector3 get_localScale() { }

	// RVA: 0x262BB90 Offset: 0x2627B90 VA: 0x262BB90 Slot: 7
	public byte get_boneIndex() { }

	// RVA: 0x262BB98 Offset: 0x2627B98 VA: 0x262BB98 Slot: 8
	public void AddEffectData(GameObject data, Transform[] bones) { }

	// RVA: 0x262A33C Offset: 0x262633C VA: 0x262A33C
	public void .ctor(Vector3 pos, Vector3 rot, Vector3 localScale, byte index) { }
}
