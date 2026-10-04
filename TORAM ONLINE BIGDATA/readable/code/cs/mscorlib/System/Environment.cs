// Assembly: mscorlib.dll
// Namespace: System
[ComVisible(True)]
public static class Environment // TypeDefIndex: 9774
{
	// Fields
	private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	// Properties
	public static string CurrentDirectory { get; }
	public static int CurrentManagedThreadId { get; }
	public static bool HasShutdownStarted { get; }
	public static string MachineName { get; }
	public static string NewLine { get; }
	internal static PlatformID Platform { get; }
	public static OperatingSystem OSVersion { get; }
	public static string StackTrace { get; }
	public static int TickCount { get; }
	public static string UserDomainName { get; }
	public static string UserName { get; }
	public static int ProcessorCount { get; }
	internal static bool IsRunningOnWindows { get; }
	internal static bool IsUnix { get; }

	// Methods

	// RVA: 0x3027DC4 Offset: 0x3023DC4 VA: 0x3027DC4
	internal static string GetResourceString(string key) { }

	// RVA: 0x3029D00 Offset: 0x3025D00 VA: 0x3029D00
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x302B680 Offset: 0x3027680 VA: 0x302B680
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x302B7FC Offset: 0x30277FC VA: 0x302B7FC
	public static string get_CurrentDirectory() { }

	// RVA: 0x302B804 Offset: 0x3027804 VA: 0x302B804
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x302B824 Offset: 0x3027824 VA: 0x302B824
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x302B828 Offset: 0x3027828 VA: 0x302B828
	public static string get_MachineName() { }

	// RVA: 0x302B82C Offset: 0x302782C VA: 0x302B82C
	private static string GetNewLine() { }

	// RVA: 0x302B830 Offset: 0x3027830 VA: 0x302B830
	public static string get_NewLine() { }

	[CompilerGenerated]
	// RVA: 0x302B8A8 Offset: 0x30278A8 VA: 0x302B8A8
	internal static PlatformID get_Platform() { }

	// RVA: 0x302B8AC Offset: 0x30278AC VA: 0x302B8AC
	internal static string GetOSVersionString() { }

	// RVA: 0x302B8B0 Offset: 0x30278B0 VA: 0x302B8B0
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x302B974 Offset: 0x3027974 VA: 0x302B974
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x302BB90 Offset: 0x3027B90 VA: 0x302BB90
	public static string get_StackTrace() { }

	// RVA: 0x302BBFC Offset: 0x3027BFC VA: 0x302BBFC
	public static int get_TickCount() { }

	// RVA: 0x302BC00 Offset: 0x3027C00 VA: 0x302BC00
	public static string get_UserDomainName() { }

	// RVA: 0x302BC04 Offset: 0x3027C04 VA: 0x302BC04
	public static string get_UserName() { }

	// RVA: 0x302BC08 Offset: 0x3027C08 VA: 0x302BC08
	public static void Exit(int exitCode) { }

	// RVA: 0x302BC0C Offset: 0x3027C0C VA: 0x302BC0C
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x302BC10 Offset: 0x3027C10 VA: 0x302BC10
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x302BCD4 Offset: 0x3027CD4 VA: 0x302BCD4
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x302BCD8 Offset: 0x3027CD8 VA: 0x302BCD8
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x302BD14 Offset: 0x3027D14 VA: 0x302BD14
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x302BCE0 Offset: 0x3027CE0 VA: 0x302BCE0
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x302C1F0 Offset: 0x30281F0 VA: 0x302C1F0
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x302BD30 Offset: 0x3027D30 VA: 0x302BD30
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x302C668 Offset: 0x3028668 VA: 0x302C668
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x302C670 Offset: 0x3028670 VA: 0x302C670
	internal static void FailFast(string message, Exception exception, string errorSource) { }

	// RVA: 0x302C674 Offset: 0x3028674 VA: 0x302C674
	public static int get_ProcessorCount() { }

	// RVA: 0x302BD18 Offset: 0x3027D18 VA: 0x302BD18
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x302C678 Offset: 0x3028678 VA: 0x302C678
	internal static string GetMachineConfigPath() { }

	// RVA: 0x302C664 Offset: 0x3028664 VA: 0x302C664
	internal static string internalGetHome() { }

	// RVA: 0x302C67C Offset: 0x302867C VA: 0x302C67C
	internal static int GetPageSize() { }

	// RVA: 0x302C680 Offset: 0x3028680 VA: 0x302C680
	internal static bool get_IsUnix() { }

	// RVA: 0x302C6B8 Offset: 0x30286B8 VA: 0x302C6B8
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }
}
