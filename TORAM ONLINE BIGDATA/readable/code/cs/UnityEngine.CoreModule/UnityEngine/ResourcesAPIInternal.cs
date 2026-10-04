// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
internal static class ResourcesAPIInternal // TypeDefIndex: 16324
{
	// Methods

	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	[TypeInferenceRule(2)]
	// RVA: 0x37E9608 Offset: 0x37E5608 VA: 0x37E9608
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	// RVA: 0x37E9644 Offset: 0x37E5644 VA: 0x37E9644
	public static Shader FindShaderByName(string name) { }

	[TypeInferenceRule(1)]
	[NativeThrows]
	[FreeFunction("Resources_Bindings::Load")]
	// RVA: 0x37E9680 Offset: 0x37E5680 VA: 0x37E9680
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunction("Scripting::UnloadAssetFromScripting")]
	// RVA: 0x37E96C4 Offset: 0x37E56C4 VA: 0x37E96C4
	public static void UnloadAsset(Object assetToUnload) { }
}
