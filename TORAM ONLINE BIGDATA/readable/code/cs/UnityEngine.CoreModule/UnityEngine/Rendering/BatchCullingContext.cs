// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchCullingContext // TypeDefIndex: 16640
{
	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public readonly NativeArray<CullingSplit> cullingSplits; // 0x10
	public readonly LODParameters lodParameters; // 0x20
	public readonly Matrix4x4 localToWorldMatrix; // 0x3C
	public readonly BatchCullingViewType viewType; // 0x7C
	public readonly BatchCullingProjectionType projectionType; // 0x80
	public readonly BatchCullingFlags cullingFlags; // 0x84
	public readonly BatchPackedCullingViewID viewID; // 0x88
	public readonly uint cullingLayerMask; // 0x90
	public readonly ulong sceneCullingMask; // 0x98
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic; // 0xA0
	public readonly int receiverPlaneOffset; // 0xA4
	public readonly int receiverPlaneCount; // 0xA8

	// Methods

	// RVA: 0x37FC5D8 Offset: 0x37F85D8 VA: 0x37FC5D8
	internal void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) { }
}
