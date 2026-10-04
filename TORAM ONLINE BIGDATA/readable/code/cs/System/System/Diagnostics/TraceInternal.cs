// Assembly: System.dll
// Namespace: System.Diagnostics
internal static class TraceInternal // TypeDefIndex: 14100
{
	// Fields
	private static string appName; // 0x0
	private static TraceListenerCollection listeners; // 0x8
	private static bool autoFlush; // 0x10
	private static bool useGlobalLock; // 0x11
	[ThreadStatic]
	private static int indentLevel; // 0x80000000
	private static int indentSize; // 0x14
	internal static readonly object critSec; // 0x18

	// Properties
	public static TraceListenerCollection Listeners { get; }
	public static bool AutoFlush { get; }
	public static bool UseGlobalLock { get; }
	public static int IndentLevel { get; }
	public static int IndentSize { get; }

	// Methods

	// RVA: 0x34879EC Offset: 0x34839EC VA: 0x34879EC
	public static TraceListenerCollection get_Listeners() { }

	// RVA: 0x3487F10 Offset: 0x3483F10 VA: 0x3487F10
	public static bool get_AutoFlush() { }

	// RVA: 0x3487F70 Offset: 0x3483F70 VA: 0x3487F70
	public static bool get_UseGlobalLock() { }

	// RVA: 0x3487FD0 Offset: 0x3483FD0 VA: 0x3487FD0
	public static int get_IndentLevel() { }

	// RVA: 0x3488028 Offset: 0x3484028 VA: 0x3488028
	public static int get_IndentSize() { }

	// RVA: 0x3487C38 Offset: 0x3483C38 VA: 0x3487C38
	private static void InitializeSettings() { }

	// RVA: 0x34868F0 Offset: 0x34828F0 VA: 0x34868F0
	public static void WriteLine(string message) { }

	// RVA: 0x34880AC Offset: 0x34840AC VA: 0x34880AC
	private static void .cctor() { }
}
