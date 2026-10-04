// Assembly: mscorlib.dll
// Namespace: System
internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 9843
{
	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Methods

	// RVA: 0x303FB60 Offset: 0x303BB60 VA: 0x303FB60
	public void .ctor() { }

	// RVA: 0x303FCCC Offset: 0x303BCCC VA: 0x303FCCC Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x303FF0C Offset: 0x303BF0C VA: 0x303FF0C
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x303FBB4 Offset: 0x303BBB4 VA: 0x303FBB4
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x303FC38 Offset: 0x303BC38 VA: 0x303FC38
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x303FE04 Offset: 0x303BE04 VA: 0x303FE04
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }
}
