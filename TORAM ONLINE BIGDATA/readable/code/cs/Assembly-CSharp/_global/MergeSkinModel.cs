// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MergeSkinModel // TypeDefIndex: 5319
{
	// Fields
	private Dictionary<int, List<int>> triangles; // 0x10
	private Dictionary<int, List<int>> trianglesAlpha; // 0x18
	[CompilerGenerated]
	private bool <IsMerge>k__BackingField; // 0x20
	private Vector3[] vertices; // 0x28
	private BoneWeight[] weight; // 0x30
	private Vector2[] uv1; // 0x38
	private Vector2[] uv2; // 0x40
	private Color[] color; // 0x48

	// Properties
	public bool IsMerge { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x262D7C0 Offset: 0x26297C0 VA: 0x262D7C0
	public bool get_IsMerge() { }

	[CompilerGenerated]
	// RVA: 0x262D7C8 Offset: 0x26297C8 VA: 0x262D7C8
	private void set_IsMerge(bool value) { }

	// RVA: 0x262D7D4 Offset: 0x26297D4 VA: 0x262D7D4
	public void .ctor() { }

	// RVA: 0x262D888 Offset: 0x2629888 VA: 0x262D888
	public void MergeSkinMesh(MergeData[] mergeData, int vertexCount, Rect[] uvs, Dictionary<string, int> boneId) { }

	// RVA: 0x262E614 Offset: 0x262A614 VA: 0x262E614
	public Mesh GetMeshData() { }

	// RVA: 0x262E6D0 Offset: 0x262A6D0 VA: 0x262E6D0
	public int[] GetTriangles(int matId) { }
}
