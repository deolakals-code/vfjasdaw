// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI // TypeDefIndex: 16442
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static SceneManagerAPI ActiveAPI { get; }
	public static SceneManagerAPI overrideAPI { get; }

	// Methods

	// RVA: 0x37F6E84 Offset: 0x37F2E84 VA: 0x37F6E84
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x37F6F2C Offset: 0x37F2F2C VA: 0x37F6F2C
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x37F6F84 Offset: 0x37F2F84 VA: 0x37F6F84
	protected internal void .ctor() { }

	// RVA: 0x37F6F8C Offset: 0x37F2F8C VA: 0x37F6F8C Slot: 4
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x37F6FEC Offset: 0x37F2FEC VA: 0x37F6FEC Slot: 5
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x37F6FF4 Offset: 0x37F2FF4 VA: 0x37F6FF4
	private static void .cctor() { }
}
