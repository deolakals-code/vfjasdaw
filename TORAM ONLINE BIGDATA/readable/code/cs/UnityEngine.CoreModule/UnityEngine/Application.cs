// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/BuildSettings.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
public class Application // TypeDefIndex: 16198
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Application.LowMemoryCallback lowMemory; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Application.MemoryUsageChangedCallback memoryUsageChanged; // 0x8
	private static Application.LogCallback s_LogCallbackHandler; // 0x10
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> focusChanged; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string> deepLinkActivated; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Func<bool> wantsToQuit; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action quitting; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action unloading; // 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; // 0x48

	// Properties
	public static bool isPlaying { get; }
	public static bool isFocused { get; }
	public static string buildGUID { get; }
	public static bool runInBackground { set; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	public static string persistentDataPath { get; }
	public static string temporaryCachePath { get; }
	public static string unityVersion { get; }
	public static string version { get; }
	public static string identifier { get; }
	public static string cloudProjectId { get; }
	public static int targetFrameRate { get; set; }
	public static ThreadPriority backgroundLoadingPriority { set; }
	public static RuntimePlatform platform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunction("GetInputManager().QuitApplication")]
	// RVA: 0x37CCA8C Offset: 0x37C8A8C VA: 0x37CCA8C
	public static void Quit(int exitCode) { }

	// RVA: 0x37CCAC8 Offset: 0x37C8AC8 VA: 0x37CCAC8
	public static void Quit() { }

	[FreeFunction("IsWorldPlaying")]
	// RVA: 0x37CCB38 Offset: 0x37C8B38 VA: 0x37CCB38
	public static bool get_isPlaying() { }

	[FreeFunction("IsPlayerFocused")]
	// RVA: 0x37CCB60 Offset: 0x37C8B60 VA: 0x37CCB60
	public static bool get_isFocused() { }

	[FreeFunction("Application_Bindings::GetBuildGUID")]
	// RVA: 0x37CCB88 Offset: 0x37C8B88 VA: 0x37CCB88
	public static string get_buildGUID() { }

	[FreeFunction("SetPlayerSettingsRunInBackground")]
	// RVA: 0x37CCBB0 Offset: 0x37C8BB0 VA: 0x37CCBB0
	public static void set_runInBackground(bool value) { }

	[FreeFunction("GetAppDataPath", IsThreadSafe = True)]
	// RVA: 0x37CCBEC Offset: 0x37C8BEC VA: 0x37CCBEC
	public static string get_dataPath() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	// RVA: 0x37CCC14 Offset: 0x37C8C14 VA: 0x37CCC14
	public static string get_streamingAssetsPath() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	// RVA: 0x37CCC3C Offset: 0x37C8C3C VA: 0x37CCC3C
	public static string get_persistentDataPath() { }

	[FreeFunction("GetTemporaryCachePathApplicationSpecific")]
	// RVA: 0x37CCC64 Offset: 0x37C8C64 VA: 0x37CCC64
	public static string get_temporaryCachePath() { }

	[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = True)]
	// RVA: 0x37CCC8C Offset: 0x37C8C8C VA: 0x37CCC8C
	public static string get_unityVersion() { }

	[FreeFunction("GetApplicationInfo().GetVersion")]
	// RVA: 0x37CCCB4 Offset: 0x37C8CB4 VA: 0x37CCCB4
	public static string get_version() { }

	[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
	// RVA: 0x37CCCDC Offset: 0x37C8CDC VA: 0x37CCCDC
	public static string get_identifier() { }

	[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
	// RVA: 0x37CCD04 Offset: 0x37C8D04 VA: 0x37CCD04
	public static string get_cloudProjectId() { }

	[FreeFunction("OpenURL")]
	// RVA: 0x37CCD2C Offset: 0x37C8D2C VA: 0x37CCD2C
	public static void OpenURL(string url) { }

	[FreeFunction("GetTargetFrameRate")]
	// RVA: 0x37CCD68 Offset: 0x37C8D68 VA: 0x37CCD68
	public static int get_targetFrameRate() { }

	[FreeFunction("SetTargetFrameRate")]
	// RVA: 0x37CCD90 Offset: 0x37C8D90 VA: 0x37CCD90
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("GetStackTraceLogType")]
	// RVA: 0x37CCDCC Offset: 0x37C8DCC VA: 0x37CCDCC
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunction("GetPreloadManager().SetThreadPriority")]
	// RVA: 0x37CCE08 Offset: 0x37C8E08 VA: 0x37CCE08
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	// RVA: 0x37CCE44 Offset: 0x37C8E44 VA: 0x37CCE44
	public static RuntimePlatform get_platform() { }

	[FreeFunction("(SystemLanguage)systeminfo::GetSystemLanguage")]
	// RVA: 0x37CCE6C Offset: 0x37C8E6C VA: 0x37CCE6C
	public static SystemLanguage get_systemLanguage() { }

	[RequiredByNativeCode]
	// RVA: 0x37CCE94 Offset: 0x37C8E94 VA: 0x37CCE94
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[RequiredByNativeCode]
	// RVA: 0x37CCFCC Offset: 0x37C8FCC VA: 0x37CCFCC
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	// RVA: 0x37CD050 Offset: 0x37C9050 VA: 0x37CD050
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[CompilerGenerated]
	// RVA: 0x37CD12C Offset: 0x37C912C VA: 0x37CD12C
	public static void add_quitting(Action value) { }

	[CompilerGenerated]
	// RVA: 0x37CD208 Offset: 0x37C9208 VA: 0x37CD208
	public static void remove_quitting(Action value) { }

	[RequiredByNativeCode]
	// RVA: 0x37CD2E4 Offset: 0x37C92E4 VA: 0x37CD2E4
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x37CD5E8 Offset: 0x37C95E8 VA: 0x37CD5E8
	private static void Internal_ApplicationInit() { }

	[RequiredByNativeCode]
	// RVA: 0x37CD66C Offset: 0x37C966C VA: 0x37CD66C
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x37CD718 Offset: 0x37C9718 VA: 0x37CD718
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	// RVA: 0x37CD7AC Offset: 0x37C97AC VA: 0x37CD7AC
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCode]
	// RVA: 0x37CD9A0 Offset: 0x37C99A0 VA: 0x37CD9A0
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	// RVA: 0x37CDA3C Offset: 0x37C9A3C VA: 0x37CDA3C
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x37CDAD8 Offset: 0x37C9AD8 VA: 0x37CDAD8
	public static bool get_isEditor() { }

	// RVA: 0x37CDAE0 Offset: 0x37C9AE0 VA: 0x37CDAE0
	private static void .cctor() { }
}
