// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface BoneData.BoneTrans // TypeDefIndex: 5304
{
	// Properties
	public abstract Vector3 position { get; }
	public abstract Vector3 rotation { get; }
	public abstract Vector3 localScale { get; }
	public abstract byte boneIndex { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Vector3 get_position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Vector3 get_rotation();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Vector3 get_localScale();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract byte get_boneIndex();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddEffectData(GameObject data, Transform[] bones);
}
