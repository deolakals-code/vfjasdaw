// Assembly: Assembly-CSharp.dll
// Namespace: 
public struct BoneData.BoneTransDynamicData : BoneData.BoneTrans // TypeDefIndex: 5307
{
	// Fields
	private readonly Vector3 pos; // 0x0
	private readonly Vector3 rot; // 0xC
	private readonly Vector3 scale; // 0x18
	private readonly Vector3 max; // 0x24
	private readonly float power; // 0x30
	private readonly float weight; // 0x34
	private readonly float limit; // 0x38
	private readonly byte index; // 0x3C
	private readonly string pBoneName; // 0x40

	// Properties
	public Vector3 position { get; }
	public Vector3 rotation { get; }
	public Vector3 localScale { get; }
	public byte boneIndex { get; }

	// Methods

	// RVA: 0x262BB9C Offset: 0x2627B9C VA: 0x262BB9C Slot: 4
	public Vector3 get_position() { }

	// RVA: 0x262BBA8 Offset: 0x2627BA8 VA: 0x262BBA8 Slot: 5
	public Vector3 get_rotation() { }

	// RVA: 0x262BBB4 Offset: 0x2627BB4 VA: 0x262BBB4 Slot: 6
	public Vector3 get_localScale() { }

	// RVA: 0x262BBC0 Offset: 0x2627BC0 VA: 0x262BBC0 Slot: 7
	public byte get_boneIndex() { }

	// RVA: 0x262BBC8 Offset: 0x2627BC8 VA: 0x262BBC8 Slot: 8
	public void AddEffectData(GameObject data, Transform[] bones) { }

	// RVA: 0x262A6AC Offset: 0x26266AC VA: 0x262A6AC
	public void .ctor(Vector3 pos, Vector3 rot, Vector3 localScale, byte index, string pBoneName, Vector3 max, float p, float w, float l) { }
}
