// Assembly: mscorlib.dll
// Namespace: System
public static class Console // TypeDefIndex: 9781
{
	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	internal static bool IsRunningOnAndroid; // 0x18
	private static Encoding inputEncoding; // 0x20
	private static Encoding outputEncoding; // 0x28
	private static ConsoleCancelEventHandler cancel_event; // 0x30

	// Properties
	public static TextWriter Error { get; }
	public static TextWriter Out { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; }

	// Methods

	// RVA: 0x302D1E8 Offset: 0x30291E8 VA: 0x302D1E8
	private static void .cctor() { }

	// RVA: 0x302D530 Offset: 0x3029530 VA: 0x302D530
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x302DC0C Offset: 0x3029C0C VA: 0x302DC0C
	public static TextWriter get_Error() { }

	// RVA: 0x302DC64 Offset: 0x3029C64 VA: 0x302DC64
	public static TextWriter get_Out() { }

	// RVA: 0x302DCBC Offset: 0x3029CBC VA: 0x302DCBC
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x302DB7C Offset: 0x3029B7C VA: 0x302DB7C
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x302DA5C Offset: 0x3029A5C VA: 0x302DA5C
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x302DAEC Offset: 0x3029AEC VA: 0x302DAEC
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x302DE0C Offset: 0x3029E0C VA: 0x302DE0C
	public static void SetError(TextWriter newError) { }

	// RVA: 0x302DEF0 Offset: 0x3029EF0 VA: 0x302DEF0
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x302DFDC Offset: 0x3029FDC VA: 0x302DFDC
	public static void WriteLine(string value) { }

	// RVA: 0x302E050 Offset: 0x302A050 VA: 0x302E050
	public static Encoding get_InputEncoding() { }

	// RVA: 0x302E0A8 Offset: 0x302A0A8 VA: 0x302E0A8
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x302E100 Offset: 0x302A100 VA: 0x302E100
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x302E158 Offset: 0x302A158 VA: 0x302E158
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x302E28C Offset: 0x302A28C VA: 0x302E28C
	private static void DoConsoleCancelEvent() { }
}
