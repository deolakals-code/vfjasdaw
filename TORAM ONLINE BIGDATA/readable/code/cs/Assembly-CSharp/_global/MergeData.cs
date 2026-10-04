// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MergeData // TypeDefIndex: 5318
{
	// Fields
	public MeshData Mesh; // 0x10
	public Dictionary<byte, MergeMaterial> MergeMaterialData; // 0x18
	private Dictionary<string, string> renameBones; // 0x20
	public Vector3 offsetBone; // 0x28

	// Methods

	// RVA: 0x262D54C Offset: 0x262954C VA: 0x262D54C
	public void .ctor(MeshData mesh, string[] renameBone) { }

	// RVA: 0x262D700 Offset: 0x2629700 VA: 0x262D700
	public string BoneName(int index) { }
}
