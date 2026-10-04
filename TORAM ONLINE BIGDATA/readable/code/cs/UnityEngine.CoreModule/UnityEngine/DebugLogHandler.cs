// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 16222
{
	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x37CF9C0 Offset: 0x37CB9C0 VA: 0x37CF9C0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x37CFA1C Offset: 0x37CBA1C VA: 0x37CFA1C
	internal static void Internal_LogException(Exception ex, Object obj) { }

	// RVA: 0x37CFA60 Offset: 0x37CBA60 VA: 0x37CFA60 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x37CFAC8 Offset: 0x37CBAC8 VA: 0x37CFAC8 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x37CFB58 Offset: 0x37CBB58 VA: 0x37CFB58
	public void .ctor() { }
}
