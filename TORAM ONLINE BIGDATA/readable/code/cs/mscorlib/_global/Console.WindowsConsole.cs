// Assembly: mscorlib.dll
// Namespace: 
private class Console.WindowsConsole // TypeDefIndex: 9780
{
	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x302E484 Offset: 0x302A484 VA: 0x302E484
	private static extern int GetConsoleCP() { }

	// RVA: 0x302E4EC Offset: 0x302A4EC VA: 0x302E4EC
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x302E558 Offset: 0x302A558 VA: 0x302E558
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x302D498 Offset: 0x3029498 VA: 0x302D498
	public static int GetInputCodePage() { }

	// RVA: 0x302D4E4 Offset: 0x30294E4 VA: 0x302D4E4
	public static int GetOutputCodePage() { }

	// RVA: 0x302E5B8 Offset: 0x302A5B8 VA: 0x302E5B8
	private static void .cctor() { }
}
