// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager // TypeDefIndex: 16443
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static UnityAction<Scene> sceneUnloaded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeMethod("GetSceneCount")]
	[StaticAccessor("GetSceneManager()", 0)]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	// RVA: 0x37F705C Offset: 0x37F305C VA: 0x37F705C
	public static int get_sceneCount() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	// RVA: 0x37F7084 Offset: 0x37F3084 VA: 0x37F7084
	public static Scene GetActiveScene() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	[NativeThrows]
	// RVA: 0x37F713C Offset: 0x37F313C VA: 0x37F713C
	public static Scene GetSceneAt(int index) { }

	// RVA: 0x37F720C Offset: 0x37F320C VA: 0x37F720C
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[RequiredByNativeCode]
	// RVA: 0x37F72E8 Offset: 0x37F32E8 VA: 0x37F72E8
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	// RVA: 0x37F7350 Offset: 0x37F3350 VA: 0x37F7350
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x37F745C Offset: 0x37F345C VA: 0x37F745C
	public static void LoadScene(string sceneName) { }

	// RVA: 0x37F73BC Offset: 0x37F33BC VA: 0x37F73BC
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x37F74B4 Offset: 0x37F34B4 VA: 0x37F74B4
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x37F7584 Offset: 0x37F3584 VA: 0x37F7584
	public static AsyncOperation LoadSceneAsync(string sceneName) { }

	// RVA: 0x37F7518 Offset: 0x37F3518 VA: 0x37F7518
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	[RequiredByNativeCode]
	// RVA: 0x37F75DC Offset: 0x37F35DC VA: 0x37F75DC
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	// RVA: 0x37F768C Offset: 0x37F368C VA: 0x37F768C
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	// RVA: 0x37F7728 Offset: 0x37F3728 VA: 0x37F7728
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x37F77D8 Offset: 0x37F37D8 VA: 0x37F77D8
	private static void .cctor() { }

	// RVA: 0x37F7100 Offset: 0x37F3100 VA: 0x37F7100
	private static void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x37F71C8 Offset: 0x37F31C8 VA: 0x37F71C8
	private static void GetSceneAt_Injected(int index, out Scene ret) { }
}
