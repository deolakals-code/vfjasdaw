// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public class BatchRendererGroup // TypeDefIndex: 16644
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37FC64C Offset: 0x37F864C VA: 0x37FC64C
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }
}
