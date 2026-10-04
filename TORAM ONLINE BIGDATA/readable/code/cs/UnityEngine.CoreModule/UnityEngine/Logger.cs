// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public class Logger : ILogger, ILogHandler // TypeDefIndex: 16294
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x37D0E24 Offset: 0x37CCE24 VA: 0x37D0E24
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGenerated]
	// RVA: 0x37DF080 Offset: 0x37DB080 VA: 0x37DF080 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGenerated]
	// RVA: 0x37DF088 Offset: 0x37DB088 VA: 0x37DF088 Slot: 14
	public void set_logHandler(ILogHandler value) { }

	[CompilerGenerated]
	// RVA: 0x37DF090 Offset: 0x37DB090 VA: 0x37DF090 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGenerated]
	// RVA: 0x37DF098 Offset: 0x37DB098 VA: 0x37DF098 Slot: 15
	public void set_logEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37DF0A4 Offset: 0x37DB0A4 VA: 0x37DF0A4 Slot: 16
	public LogType get_filterLogType() { }

	[CompilerGenerated]
	// RVA: 0x37DF0AC Offset: 0x37DB0AC VA: 0x37DF0AC Slot: 17
	public void set_filterLogType(LogType value) { }

	// RVA: 0x37DF0B4 Offset: 0x37DB0B4 VA: 0x37DF0B4 Slot: 18
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x37DF0EC Offset: 0x37DB0EC VA: 0x37DF0EC
	private static string GetString(object message) { }

	// RVA: 0x37DF20C Offset: 0x37DB20C VA: 0x37DF20C Slot: 6
	public void Log(LogType logType, object message) { }

	// RVA: 0x37DF390 Offset: 0x37DB390 VA: 0x37DF390 Slot: 7
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x37DF518 Offset: 0x37DB518 VA: 0x37DF518 Slot: 8
	public void Log(LogType logType, string tag, object message) { }

	// RVA: 0x37DF6D4 Offset: 0x37DB6D4 VA: 0x37DF6D4 Slot: 9
	public void LogWarning(string tag, object message) { }

	// RVA: 0x37DF880 Offset: 0x37DB880 VA: 0x37DF880 Slot: 10
	public void LogError(string tag, object message) { }

	// RVA: 0x37DFA28 Offset: 0x37DBA28 VA: 0x37DFA28 Slot: 13
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x37DFAFC Offset: 0x37DBAFC VA: 0x37DFAFC Slot: 11
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x37DFBF8 Offset: 0x37DBBF8 VA: 0x37DFBF8 Slot: 12
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }
}
