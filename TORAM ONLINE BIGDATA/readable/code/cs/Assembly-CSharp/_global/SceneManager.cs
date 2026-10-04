// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SceneManager : Singleton<SceneManager> // TypeDefIndex: 5576
{
	// Fields
	[CompilerGenerated]
	private AsyncOperation <AsyncInfoChange>k__BackingField; // 0x20
	[CompilerGenerated]
	private AsyncOperation <AsyncInfoAdditive>k__BackingField; // 0x28
	[CompilerGenerated]
	private SceneManager.SceneType <LastLoadScene>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <TermsOfServiceOk>k__BackingField; // 0x34
	private string[] SceneName; // 0x38
	private static bool isiPhoneX; // 0x0
	private static bool isCheckiPhoneX; // 0x1

	// Properties
	public AsyncOperation AsyncInfoChange { get; set; }
	public AsyncOperation AsyncInfoAdditive { get; set; }
	public SceneManager.SceneType LastLoadScene { get; set; }
	public bool TermsOfServiceOk { get; set; }
	private string loadPlatformManagerPath { get; }
	public static bool IsiPhoneX { get; }
	public static float ScreenRate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x179C8F8 Offset: 0x17988F8 VA: 0x179C8F8
	public AsyncOperation get_AsyncInfoChange() { }

	[CompilerGenerated]
	// RVA: 0x179C900 Offset: 0x1798900 VA: 0x179C900
	private void set_AsyncInfoChange(AsyncOperation value) { }

	[CompilerGenerated]
	// RVA: 0x179C908 Offset: 0x1798908 VA: 0x179C908
	public AsyncOperation get_AsyncInfoAdditive() { }

	[CompilerGenerated]
	// RVA: 0x179C910 Offset: 0x1798910 VA: 0x179C910
	private void set_AsyncInfoAdditive(AsyncOperation value) { }

	[CompilerGenerated]
	// RVA: 0x179C918 Offset: 0x1798918 VA: 0x179C918
	public SceneManager.SceneType get_LastLoadScene() { }

	[CompilerGenerated]
	// RVA: 0x179C920 Offset: 0x1798920 VA: 0x179C920
	private void set_LastLoadScene(SceneManager.SceneType value) { }

	[CompilerGenerated]
	// RVA: 0x179C928 Offset: 0x1798928 VA: 0x179C928
	public bool get_TermsOfServiceOk() { }

	[CompilerGenerated]
	// RVA: 0x179C930 Offset: 0x1798930 VA: 0x179C930
	public void set_TermsOfServiceOk(bool value) { }

	// RVA: 0x179C93C Offset: 0x179893C VA: 0x179C93C
	private string get_loadPlatformManagerPath() { }

	// RVA: 0x179C97C Offset: 0x179897C VA: 0x179C97C
	private void Awake() { }

	// RVA: 0x179CB80 Offset: 0x1798B80 VA: 0x179CB80
	public bool CheckSceneData(SceneManager.SceneType scene) { }

	// RVA: 0x179CC24 Offset: 0x1798C24 VA: 0x179CC24
	public bool CheckScene(SceneManager.SceneType[] scene) { }

	// RVA: 0x179CC80 Offset: 0x1798C80 VA: 0x179CC80
	public void ChangeScene(SceneManager.SceneType scene) { }

	// RVA: 0x179CDF0 Offset: 0x1798DF0 VA: 0x179CDF0
	public void ChangeSceneForce(SceneManager.SceneType scene) { }

	// RVA: 0x179CE98 Offset: 0x1798E98 VA: 0x179CE98
	public void ChangeSceneAsync(SceneManager.SceneType scene) { }

	// RVA: 0x179CF2C Offset: 0x1798F2C VA: 0x179CF2C
	public void AdditiveScene(SceneManager.SceneType scene) { }

	// RVA: 0x179CFB0 Offset: 0x1798FB0 VA: 0x179CFB0
	public void AdditiveSceneAsync(SceneManager.SceneType scene) { }

	// RVA: 0x179D034 Offset: 0x1799034 VA: 0x179D034
	public static bool get_IsiPhoneX() { }

	// RVA: 0x179D104 Offset: 0x1799104 VA: 0x179D104
	public static float get_ScreenRate() { }

	// RVA: 0x179D1A0 Offset: 0x17991A0 VA: 0x179D1A0
	public void ChangeScreenOrientation(bool Landscape) { }

	// RVA: 0x179D1A4 Offset: 0x17991A4 VA: 0x179D1A4
	public void .ctor() { }
}
