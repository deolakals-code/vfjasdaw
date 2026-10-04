// Assembly: UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper // TypeDefIndex: 17767
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x3816734 Offset: 0x3812734 VA: 0x3816734
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x38167FC Offset: 0x38127FC VA: 0x38167FC
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x3816798 Offset: 0x3812798 VA: 0x3816798
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x3816860 Offset: 0x3812860 VA: 0x3816860
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }
}
