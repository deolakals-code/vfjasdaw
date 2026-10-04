// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
public struct BatchDrawCommand // TypeDefIndex: 16635
{
	// Fields
	public uint visibleOffset; // 0x0
	public uint visibleCount; // 0x4
	public BatchID batchID; // 0x8
	public BatchMaterialID materialID; // 0xC
	public BatchMeshID meshID; // 0x10
	public ushort submeshIndex; // 0x14
	public ushort splitVisibilityMask; // 0x16
	public BatchDrawCommandFlags flags; // 0x18
	public int sortingPosition; // 0x1C
}
