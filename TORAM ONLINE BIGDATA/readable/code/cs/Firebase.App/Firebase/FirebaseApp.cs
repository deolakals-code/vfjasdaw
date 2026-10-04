// Assembly: Firebase.App.dll
// Namespace: Firebase
public sealed class FirebaseApp : IDisposable // TypeDefIndex: 17227
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	private bool swigCMemOwn; // 0x20
	internal static readonly object disposeLock; // 0x0
	private string name; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private EventHandler AppDisposed; // 0x30
	private static Dictionary<string, FirebaseApp> nameToProxy; // 0x8
	private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy; // 0x10
	private static bool AppUtilCallbacksInitialized; // 0x18
	private static object AppUtilCallbacksLock; // 0x20
	private static bool PreventOnAllAppsDestroyed; // 0x28
	private static bool crashlyticsInitializationAttempted; // 0x29
	private static bool userAgentRegistered; // 0x2A
	private static int CheckDependenciesThread; // 0x2C
	private static object CheckDependenciesThreadLock; // 0x30
	private FirebaseAppPlatform appPlatform; // 0x38

	// Properties
	public static FirebaseApp DefaultInstance { get; }
	public string Name { get; }
	public static LogLevel LogLevel { get; }
	internal string NameInternal { get; }
	public static string DefaultName { get; }

	// Methods

	// RVA: 0x265A5F4 Offset: 0x26565F4 VA: 0x265A5F4
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x265A664 Offset: 0x2656664 VA: 0x265A664
	internal static HandleRef getCPtr(FirebaseApp obj) { }

	// RVA: 0x265A6A8 Offset: 0x26566A8 VA: 0x265A6A8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x265A7FC Offset: 0x26567FC VA: 0x265A7FC Slot: 4
	public void Dispose() { }

	// RVA: 0x265A740 Offset: 0x2656740 VA: 0x265A740
	public void Dispose(bool disposing) { }

	// RVA: 0x265ABE8 Offset: 0x2656BE8 VA: 0x265ABE8
	private static void .cctor() { }

	// RVA: 0x265ADB8 Offset: 0x2656DB8 VA: 0x265ADB8
	internal static void TranslateDllNotFoundException(Action closureToExecute) { }

	// RVA: 0x265AF04 Offset: 0x2656F04 VA: 0x265AF04
	public static FirebaseApp get_DefaultInstance() { }

	// RVA: 0x265B030 Offset: 0x2657030 VA: 0x265B030
	public static FirebaseApp GetInstance(string name) { }

	// RVA: 0x265B1F4 Offset: 0x26571F4 VA: 0x265B1F4
	public static FirebaseApp Create() { }

	// RVA: 0x265C128 Offset: 0x2658128 VA: 0x265C128
	public string get_Name() { }

	// RVA: 0x265C1D8 Offset: 0x26581D8 VA: 0x265C1D8
	public static LogLevel get_LogLevel() { }

	// RVA: 0x265C28C Offset: 0x265828C VA: 0x265C28C
	private void AddReference() { }

	// RVA: 0x265A928 Offset: 0x2656928 VA: 0x265A928
	private void RemoveReference() { }

	// RVA: 0x265C170 Offset: 0x2658170 VA: 0x265C170
	private void ThrowIfNull() { }

	// RVA: 0x265C6C0 Offset: 0x26586C0 VA: 0x265C6C0
	private static void InitializeAppUtilCallbacks() { }

	// RVA: 0x265C50C Offset: 0x265850C VA: 0x265C50C
	private static void OnAllAppsDestroyed() { }

	// RVA: 0x265D41C Offset: 0x265941C VA: 0x265D41C
	internal static Uri UrlStringToUri(string urlString) { }

	// RVA: 0x265D500 Offset: 0x2659500 VA: 0x265D500
	private static bool InitializeCrashlyticsIfPresent() { }

	// RVA: 0x265B538 Offset: 0x2657538 VA: 0x265B538
	private static FirebaseApp CreateAndTrack(FirebaseApp.CreateDelegate createDelegate, FirebaseApp existingProxy) { }

	// RVA: 0x265DC14 Offset: 0x2659C14 VA: 0x265DC14
	private static void SetCheckDependenciesThread(int threadId) { }

	// RVA: 0x265B2F8 Offset: 0x26572F8 VA: 0x265B2F8
	private static void ThrowIfCheckDependenciesRunning() { }

	// RVA: 0x265DAF8 Offset: 0x2659AF8 VA: 0x265DAF8
	private static bool IsCheckDependenciesRunning() { }

	// RVA: 0x265DE0C Offset: 0x2659E0C VA: 0x265DE0C
	public static Task<DependencyStatus> CheckDependenciesAsync() { }

	// RVA: 0x265DFB0 Offset: 0x2659FB0 VA: 0x265DFB0
	public static Task<DependencyStatus> CheckAndFixDependenciesAsync() { }

	// RVA: 0x265E0FC Offset: 0x265A0FC VA: 0x265E0FC
	private static DependencyStatus CheckDependencies() { }

	// RVA: 0x265E1D4 Offset: 0x265A1D4 VA: 0x265E1D4
	private static DependencyStatus CheckDependenciesInternal() { }

	// RVA: 0x265E42C Offset: 0x265A42C VA: 0x265E42C
	public static Task FixDependenciesAsync() { }

	// RVA: 0x265E51C Offset: 0x265A51C VA: 0x265E51C
	private static void ResetDefaultAppCPtr() { }

	// RVA: 0x265A860 Offset: 0x2656860 VA: 0x265A860
	internal string get_NameInternal() { }

	// RVA: 0x265E924 Offset: 0x265A924 VA: 0x265E924
	internal static FirebaseApp CreateInternal() { }

	// RVA: 0x265C420 Offset: 0x2658420 VA: 0x265C420
	internal static void ReleaseReferenceInternal(FirebaseApp app) { }

	// RVA: 0x265D890 Offset: 0x2659890 VA: 0x265D890
	internal static void RegisterLibrariesInternal(StringStringMap libraries) { }

	// RVA: 0x265DA0C Offset: 0x2659A0C VA: 0x265DA0C
	internal static void LogHeartbeatInternal(FirebaseApp app) { }

	// RVA: 0x265D958 Offset: 0x2659958 VA: 0x265D958
	internal static void AppSetDefaultConfigPath(string path) { }

	// RVA: 0x265AF78 Offset: 0x2656F78 VA: 0x265AF78
	public static string get_DefaultName() { }
}
