// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Platform
internal class FirebaseLogger // TypeDefIndex: 17753
{
	// Fields
	private static MainThreadProperty<bool> incompatibleStackUnwindingEnabled; // 0x0

	// Properties
	internal static bool CanRedirectNativeLogs { get; }

	// Methods

	// RVA: 0x266B984 Offset: 0x2667984 VA: 0x266B984
	private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType) { }

	// RVA: 0x266B990 Offset: 0x2667990 VA: 0x266B990
	private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs() { }

	// RVA: 0x266BC04 Offset: 0x2667C04 VA: 0x266BC04
	internal static bool get_CanRedirectNativeLogs() { }

	// RVA: 0x26685EC Offset: 0x26645EC VA: 0x26685EC
	internal static void LogMessage(PlatformLogLevel logLevel, string message) { }

	// RVA: 0x266BD8C Offset: 0x2667D8C VA: 0x266BD8C
	private static void .cctor() { }
}
