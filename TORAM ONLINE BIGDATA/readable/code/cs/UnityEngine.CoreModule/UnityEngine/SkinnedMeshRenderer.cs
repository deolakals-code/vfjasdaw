// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 16274
{
	// Properties
	public bool updateWhenOffscreen { set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativeProperty("Mesh")]
	public Mesh sharedMesh { get; set; }

	// Methods

	// RVA: 0x37D7804 Offset: 0x37D3804 VA: 0x37D7804
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x37D7848 Offset: 0x37D3848 VA: 0x37D7848
	public Transform get_rootBone() { }

	// RVA: 0x37D7884 Offset: 0x37D3884 VA: 0x37D7884
	public void set_rootBone(Transform value) { }

	// RVA: 0x37D78C8 Offset: 0x37D38C8 VA: 0x37D78C8
	public Transform[] get_bones() { }

	// RVA: 0x37D7904 Offset: 0x37D3904 VA: 0x37D7904
	public void set_bones(Transform[] value) { }

	// RVA: 0x37D7948 Offset: 0x37D3948 VA: 0x37D7948
	public Mesh get_sharedMesh() { }

	// RVA: 0x37D7984 Offset: 0x37D3984 VA: 0x37D7984
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x37D79C8 Offset: 0x37D39C8 VA: 0x37D79C8
	public void BakeMesh(Mesh mesh, bool useScale) { }

	// RVA: 0x37D7A1C Offset: 0x37D3A1C VA: 0x37D7A1C
	public void .ctor() { }
}
