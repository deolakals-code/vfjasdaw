// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
public class Graphics // TypeDefIndex: 16240
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0
	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x8

	// Methods

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	// RVA: 0x37D418C Offset: 0x37D018C VA: 0x37D418C
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunction("GraphicsScripting::DrawMeshNow")]
	// RVA: 0x37D41B4 Offset: 0x37D01B4 VA: 0x37D41B4
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	[FreeFunction("GraphicsScripting::DrawMesh")]
	// RVA: 0x37D4294 Offset: 0x37D0294 VA: 0x37D4294
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	// RVA: 0x37D4444 Offset: 0x37D0444 VA: 0x37D4444
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x37D455C Offset: 0x37D055C VA: 0x37D455C
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x37D45F0 Offset: 0x37D05F0 VA: 0x37D45F0
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[ExcludeFromDocs]
	// RVA: 0x37D4788 Offset: 0x37D0788 VA: 0x37D4788
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	[ExcludeFromDocs]
	// RVA: 0x37D4854 Offset: 0x37D0854 VA: 0x37D4854
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera) { }

	// RVA: 0x37D4924 Offset: 0x37D0924 VA: 0x37D4924
	private static void .cctor() { }

	// RVA: 0x37D4240 Offset: 0x37D0240 VA: 0x37D4240
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

	// RVA: 0x37D4384 Offset: 0x37D0384 VA: 0x37D4384
	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }
}
