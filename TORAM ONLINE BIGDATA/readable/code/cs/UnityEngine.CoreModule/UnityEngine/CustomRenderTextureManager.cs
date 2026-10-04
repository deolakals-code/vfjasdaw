// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
public static class CustomRenderTextureManager // TypeDefIndex: 16235
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<CustomRenderTexture> textureLoaded; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37D37B8 Offset: 0x37CF7B8 VA: 0x37D37B8
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCode]
	// RVA: 0x37D3824 Offset: 0x37CF824 VA: 0x37D3824
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }
}
