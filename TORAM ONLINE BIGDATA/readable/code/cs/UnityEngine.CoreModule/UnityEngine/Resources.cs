// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
public sealed class Resources // TypeDefIndex: 16326
{
	// Methods

	// RVA: 0x37E9968 Offset: 0x37E5968 VA: 0x37E9968
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x37E99D0 Offset: 0x37E59D0 VA: 0x37E99D0
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E7458 Offset: 0x26E3458 VA: 0x26E7458
	|-Resources.Load<object>
	*/

	// RVA: 0x37E9580 Offset: 0x37E5580 VA: 0x37E9580
	public static Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x37E9A54 Offset: 0x37E5A54 VA: 0x37E9A54
	public static void UnloadAsset(Object assetToUnload) { }

	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	// RVA: 0x37E9ABC Offset: 0x37E5ABC VA: 0x37E9ABC
	public static AsyncOperation UnloadUnusedAssets() { }
}
