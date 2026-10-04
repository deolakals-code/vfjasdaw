// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
internal struct BatchRendererCullingOutput // TypeDefIndex: 16642
{
	// Fields
	public JobHandle cullingJobsFence; // 0x0
	public Matrix4x4 localToWorldMatrix; // 0x10
	public Plane* cullingPlanes; // 0x50
	public int cullingPlaneCount; // 0x58
	public int receiverPlaneOffset; // 0x5C
	public int receiverPlaneCount; // 0x60
	public CullingSplit* cullingSplits; // 0x68
	public int cullingSplitCount; // 0x70
	public BatchCullingViewType viewType; // 0x74
	public BatchCullingProjectionType projectionType; // 0x78
	public BatchCullingFlags cullingFlags; // 0x7C
	public ulong viewID; // 0x80
	public uint cullingLayerMask; // 0x88
	public ulong sceneCullingMask; // 0x90
	public BatchCullingOutputDrawCommands* drawCommands; // 0x98
}
