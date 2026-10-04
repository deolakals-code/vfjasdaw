// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GeometryUtilityScripting", 2)]
public sealed class GeometryUtility // TypeDefIndex: 16227
{
	// Methods

	// RVA: 0x37D1960 Offset: 0x37CD960 VA: 0x37D1960
	public static Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0x37D19C0 Offset: 0x37CD9C0 VA: 0x37D19C0
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0x37D1BA8 Offset: 0x37CDBA8 VA: 0x37D1BA8
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0x37D1CE8 Offset: 0x37CDCE8 VA: 0x37D1CE8
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	[NativeName("ExtractPlanes")]
	// RVA: 0x37D1CA4 Offset: 0x37CDCA4 VA: 0x37D1CA4
	private static void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0x37D1D2C Offset: 0x37CDD2C VA: 0x37D1D2C
	private static bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds) { }

	// RVA: 0x37D1D70 Offset: 0x37CDD70 VA: 0x37D1D70
	private static void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix) { }
}
