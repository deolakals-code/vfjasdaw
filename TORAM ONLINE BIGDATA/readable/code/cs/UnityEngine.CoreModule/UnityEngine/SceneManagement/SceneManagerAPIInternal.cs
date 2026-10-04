// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[StaticAccessor("SceneManagerBindings", 2)]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
internal static class SceneManagerAPIInternal // TypeDefIndex: 16441
{
	// Methods

	[NativeThrows]
	// RVA: 0x37F6DC8 Offset: 0x37F2DC8 VA: 0x37F6DC8
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x37F6E28 Offset: 0x37F2E28 VA: 0x37F6E28
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}
