// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MergeList // TypeDefIndex: 5317
{
	// Fields
	public readonly ModelManager.LoadModelType LoadType; // 0x10
	public readonly int LoadId; // 0x14
	public readonly byte[] Color; // 0x18
	public readonly Color32[] SetColor; // 0x20
	public readonly string[] RenameBone; // 0x28
	public readonly int BoneId; // 0x30
	private string loadFile; // 0x38

	// Properties
	public string LoadFile { get; }

	// Methods

	// RVA: 0x262CFD4 Offset: 0x2628FD4 VA: 0x262CFD4
	public string get_LoadFile() { }

	// RVA: 0x262D070 Offset: 0x2629070 VA: 0x262D070
	public void .ctor(ModelManager.LoadModelType type, int id) { }

	// RVA: 0x262D12C Offset: 0x262912C VA: 0x262D12C
	public void .ctor(ModelManager.LoadModelType type, int id, string file) { }

	// RVA: 0x262D158 Offset: 0x2629158 VA: 0x262D158
	public void .ctor(ModelManager.LoadModelType type, int id, int color) { }

	// RVA: 0x262D200 Offset: 0x2629200 VA: 0x262D200
	public void .ctor(ModelManager.LoadModelType type, int id, int color, string file) { }

	// RVA: 0x262D22C Offset: 0x262922C VA: 0x262D22C
	public void .ctor(ModelManager.LoadModelType type, int id, int color, string[] renameBone) { }

	// RVA: 0x262D2D8 Offset: 0x26292D8 VA: 0x262D2D8
	public void .ctor(ModelManager.LoadModelType type, int id, Color32 r, Color32 g, Color32 b) { }

	// RVA: 0x262D3D0 Offset: 0x26293D0 VA: 0x262D3D0
	public void .ctor(ModelManager.LoadModelType type, int id, string file, Color32 r, Color32 g, Color32 b) { }

	// RVA: 0x262D408 Offset: 0x2629408 VA: 0x262D408
	public void .ctor(ModelManager.LoadModelType type, int id, Color32 r, Color32 g, Color32 b, int boneId) { }

	// RVA: 0x262D510 Offset: 0x2629510 VA: 0x262D510
	public void .ctor(ModelManager.LoadModelType type, int id, string file, Color32 r, Color32 g, Color32 b, int boneId) { }
}
