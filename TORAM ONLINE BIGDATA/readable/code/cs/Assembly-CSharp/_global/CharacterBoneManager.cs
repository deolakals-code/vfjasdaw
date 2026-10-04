// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CharacterBoneManager // TypeDefIndex: 541
{
	// Fields
	private Dictionary<string, Transform> partToBoneList; // 0x10
	private readonly Dictionary<byte, string> partsNameList; // 0x18

	// Methods

	// RVA: 0x1834B64 Offset: 0x1830B64 VA: 0x1834B64
	public void .ctor(int boneId) { }

	// RVA: 0x1834EDC Offset: 0x1830EDC VA: 0x1834EDC
	public void .ctor(Transform transform) { }

	// RVA: 0x1835454 Offset: 0x1831454 VA: 0x1835454
	public Transform GetBone(string partName) { }

	// RVA: 0x18355D4 Offset: 0x18315D4 VA: 0x18355D4
	public Transform GetBone(int id) { }

	// RVA: 0x1835674 Offset: 0x1831674 VA: 0x1835674
	public Transform GetBone(CharacterBoneManager.PartsName name) { }

	// RVA: 0x18356D8 Offset: 0x18316D8 VA: 0x18356D8
	public void BoneEntry(string partName, Transform bone) { }

	// RVA: 0x18357E4 Offset: 0x18317E4 VA: 0x18357E4
	public void BoneEntry(int id, Transform bone) { }

	// RVA: 0x1835234 Offset: 0x1831234 VA: 0x1835234
	public void BonesEntry(Transform transform) { }

	// RVA: 0x1835894 Offset: 0x1831894 VA: 0x1835894
	public bool ContainsPartName(string partName) { }

	// RVA: 0x18358EC Offset: 0x18318EC VA: 0x18358EC
	public bool IsBoneEntry(string partName) { }
}
