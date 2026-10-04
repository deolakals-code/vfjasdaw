// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class MobBoneManager : CharacterBoneManager // TypeDefIndex: 923
{
	// Fields
	private Dictionary<int, MobBoneManager.BoneData> boneDataList; // 0x20

	// Methods

	// RVA: 0x1F05F04 Offset: 0x1F01F04 VA: 0x1F05F04
	public void .ctor(int boneId) { }

	// RVA: 0x1F05F94 Offset: 0x1F01F94 VA: 0x1F05F94
	public void .ctor(Transform transform) { }

	// RVA: 0x1F06024 Offset: 0x1F02024 VA: 0x1F06024
	public void CreateBoneList(Transform transform) { }

	// RVA: 0x1F06184 Offset: 0x1F02184 VA: 0x1F06184
	public bool TryGetBone(int id, out Transform bone) { }
}
