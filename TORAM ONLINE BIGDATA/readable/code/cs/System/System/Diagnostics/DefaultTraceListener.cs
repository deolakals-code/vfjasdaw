// Assembly: System.dll
// Namespace: System.Diagnostics
public class DefaultTraceListener : TraceListener // TypeDefIndex: 14105
{
	// Fields
	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x30

	// Properties
	[MonoTODO]
	public string LogFileName { get; }

	// Methods

	// RVA: 0x3488D6C Offset: 0x3484D6C VA: 0x3488D6C
	private static void .cctor() { }

	// RVA: 0x3488EDC Offset: 0x3484EDC VA: 0x3488EDC
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x3487CAC Offset: 0x3483CAC VA: 0x3487CAC
	public void .ctor() { }

	// RVA: 0x3488F58 Offset: 0x3484F58 VA: 0x3488F58
	public string get_LogFileName() { }

	// RVA: 0x3488F60 Offset: 0x3484F60 VA: 0x3488F60
	private static void WriteWindowsDebugString(char* message) { }

	// RVA: 0x3488F64 Offset: 0x3484F64 VA: 0x3488F64
	private void WriteDebugString(string message) { }

	// RVA: 0x3489014 Offset: 0x3485014 VA: 0x3489014
	private void WriteMonoTrace(string message) { }

	// RVA: 0x3489440 Offset: 0x3485440 VA: 0x3489440
	private void WritePrefix() { }

	// RVA: 0x34894C8 Offset: 0x34854C8 VA: 0x34894C8
	private void WriteImpl(string message) { }

	// RVA: 0x34891C8 Offset: 0x34851C8 VA: 0x34891C8
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x3489584 Offset: 0x3485584 VA: 0x3489584 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x3489588 Offset: 0x3485588 VA: 0x3489588 Slot: 12
	public override void WriteLine(string message) { }
}
