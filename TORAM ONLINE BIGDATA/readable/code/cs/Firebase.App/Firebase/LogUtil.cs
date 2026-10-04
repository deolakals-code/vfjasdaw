// Assembly: Firebase.App.dll
// Namespace: Firebase
internal sealed class LogUtil : IDisposable // TypeDefIndex: 17203
{
	// Fields
	private static LogUtil _instance; // 0x0
	private static object InitializeLoggingLock; // 0x8
	private bool _disposed; // 0x10

	// Methods

	// RVA: 0x2651BCC Offset: 0x264DBCC VA: 0x2651BCC
	private static void .cctor() { }

	// RVA: 0x2651D84 Offset: 0x264DD84 VA: 0x2651D84
	public static void InitializeLogging() { }

	// RVA: 0x2651F30 Offset: 0x264DF30 VA: 0x2651F30
	internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	// RVA: 0x2651F3C Offset: 0x264DF3C VA: 0x2651F3C
	internal static void LogMessage(LogLevel logLevel, string message) { }

	[MonoPInvokeCallback(typeof(LogUtil.LogMessageDelegate))]
	// RVA: 0x2651B28 Offset: 0x264DB28 VA: 0x2651B28
	internal static void LogMessageFromCallback(LogLevel logLevel, string message) { }

	// RVA: 0x2651C88 Offset: 0x264DC88 VA: 0x2651C88
	public void .ctor() { }

	// RVA: 0x2652120 Offset: 0x264E120 VA: 0x2652120 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x26521F0 Offset: 0x264E1F0 VA: 0x26521F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x26521C8 Offset: 0x264E1C8 VA: 0x26521C8
	protected void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x2652260 Offset: 0x264E260 VA: 0x2652260
	private void <.ctor>b__9_0(object sender, EventArgs e) { }
}
