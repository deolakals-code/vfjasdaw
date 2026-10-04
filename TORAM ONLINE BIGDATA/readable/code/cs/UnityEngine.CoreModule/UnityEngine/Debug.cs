// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug // TypeDefIndex: 16223
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	// RVA: 0x37CFB60 Offset: 0x37CBB60 VA: 0x37CFB60
	public static ILogger get_unityLogger() { }

	[ThreadSafe]
	// RVA: 0x37CFBB8 Offset: 0x37CBBB8 VA: 0x37CFBB8
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x37CFC0C Offset: 0x37CBC0C VA: 0x37CFC0C
	public static void Log(object message) { }

	// RVA: 0x37CFD14 Offset: 0x37CBD14 VA: 0x37CFD14
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x37CFE2C Offset: 0x37CBE2C VA: 0x37CFE2C
	public static void LogError(object message) { }

	// RVA: 0x37CFF34 Offset: 0x37CBF34 VA: 0x37CFF34
	public static void LogError(object message, Object context) { }

	// RVA: 0x37D004C Offset: 0x37CC04C VA: 0x37D004C
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x37CD4E0 Offset: 0x37C94E0 VA: 0x37CD4E0
	public static void LogException(Exception exception) { }

	// RVA: 0x37D0164 Offset: 0x37CC164 VA: 0x37D0164
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x37D0278 Offset: 0x37CC278 VA: 0x37D0278
	public static void LogWarning(object message) { }

	// RVA: 0x37D0380 Offset: 0x37CC380 VA: 0x37D0380
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x37D0498 Offset: 0x37CC498 VA: 0x37D0498
	public static void LogWarningFormat(string format, object[] args) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x37D05B0 Offset: 0x37CC5B0 VA: 0x37D05B0
	public static void Assert(bool condition) { }

	[RequiredByNativeCode]
	// RVA: 0x37D06E0 Offset: 0x37CC6E0 VA: 0x37D06E0
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[RequiredByNativeCode]
	// RVA: 0x37D0AD8 Offset: 0x37CCAD8 VA: 0x37D0AD8
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x37D0CFC Offset: 0x37CCCFC VA: 0x37D0CFC
	private static void .cctor() { }
}
