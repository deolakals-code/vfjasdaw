// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component // TypeDefIndex: 16254
{
	// Properties
	public Mesh sharedMesh { get; set; }
	public Mesh mesh { get; set; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37D76F8 Offset: 0x37D36F8 VA: 0x37D76F8
	private void DontStripMeshFilter() { }

	// RVA: 0x37D76FC Offset: 0x37D36FC VA: 0x37D76FC
	public Mesh get_sharedMesh() { }

	// RVA: 0x37D7738 Offset: 0x37D3738 VA: 0x37D7738
	public void set_sharedMesh(Mesh value) { }

	[NativeName("GetInstantiatedMeshFromScript")]
	// RVA: 0x37D777C Offset: 0x37D377C VA: 0x37D777C
	public Mesh get_mesh() { }

	[NativeName("SetInstantiatedMesh")]
	// RVA: 0x37D77B8 Offset: 0x37D37B8 VA: 0x37D77B8
	public void set_mesh(Mesh value) { }

	// RVA: 0x37D77FC Offset: 0x37D37FC VA: 0x37D77FC
	public void .ctor() { }
}
