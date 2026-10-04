// Assembly: mscorlib.dll
// Namespace: System.Diagnostics
[ComVisible(True)]
public sealed class Debugger // TypeDefIndex: 10844
{
	// Fields
	public static readonly string DefaultCategory; // 0x0

	// Methods

	// RVA: 0x2FB1088 Offset: 0x2FAD088 VA: 0x2FB1088
	public static bool IsLogging() { }

	// RVA: 0x2FB108C Offset: 0x2FAD08C VA: 0x2FB108C
	private static void Log_icall(int level, ref string category, ref string message) { }

	// RVA: 0x2FB1090 Offset: 0x2FAD090 VA: 0x2FB1090
	public static void Log(int level, string category, string message) { }

	// RVA: 0x2FB10FC Offset: 0x2FAD0FC VA: 0x2FB10FC
	public static void NotifyOfCrossThreadDependency() { }

	// RVA: 0x2FB1100 Offset: 0x2FAD100 VA: 0x2FB1100
	private static void .cctor() { }
}
