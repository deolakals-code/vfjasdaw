// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MergeFieldObject.MergeObject // TypeDefIndex: 3981
{
	// Fields
	public readonly Material mainMaterial; // 0x10
	private AnimationClip animationClip; // 0x18
	private List<Vector3> vert; // 0x20
	private List<Vector2> uv; // 0x28
	private List<Vector2> uv2; // 0x30
	private List<Color> vsColor; // 0x38
	private List<int> triangles; // 0x40
	private bool normal; // 0x48

	// Properties
	public int Offset { get; }

	// Methods

	// RVA: 0x242DE68 Offset: 0x2429E68 VA: 0x242DE68
	public int get_Offset() { }

	// RVA: 0x242DC3C Offset: 0x2429C3C VA: 0x242DC3C
	public void .ctor(Material material, AnimationClip animationClip, bool isNormal) { }

	// RVA: 0x242E298 Offset: 0x242A298 VA: 0x242E298
	public void AddModel(Vector3 vertEx, Vector2 uvEx, Vector2 uv2Ex, Color vsColorEx, int trianglesEx) { }

	// RVA: 0x242DEB0 Offset: 0x2429EB0 VA: 0x242DEB0
	public GameObject MergeExportObject(GameObject modelLayer) { }
}
