// Assembly: mscorlib.dll
// Namespace: System
internal static class ConsoleDriver // TypeDefIndex: 9782
{
	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x302E70C Offset: 0x302A70C VA: 0x302E70C
	private static void .cctor() { }

	// RVA: 0x302E7DC Offset: 0x302A7DC VA: 0x302E7DC
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x302E81C Offset: 0x302A81C VA: 0x302E81C
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x302E870 Offset: 0x302A870 VA: 0x302E870
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x302E1B4 Offset: 0x302A1B4 VA: 0x302E1B4
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x302D91C Offset: 0x302991C VA: 0x302D91C
	public static bool get_IsConsole() { }

	// RVA: 0x302EC74 Offset: 0x302AC74 VA: 0x302EC74
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x302EC78 Offset: 0x302AC78 VA: 0x302EC78
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x302EC7C Offset: 0x302AC7C VA: 0x302EC7C
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x302EC80 Offset: 0x302AC80 VA: 0x302EC80
	internal static bool SetEcho(bool wantEcho) { }
}
