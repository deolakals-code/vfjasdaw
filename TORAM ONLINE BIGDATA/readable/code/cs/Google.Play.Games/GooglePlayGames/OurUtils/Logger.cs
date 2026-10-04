// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.OurUtils
public class Logger // TypeDefIndex: 16804
{
	// Fields
	private static bool debugLogEnabled; // 0x0
	private static bool warningLogEnabled; // 0x1

	// Properties
	public static bool DebugLogEnabled { get; set; }
	public static bool WarningLogEnabled { get; set; }

	// Methods

	// RVA: 0x2E2FBFC Offset: 0x2E2BBFC VA: 0x2E2FBFC
	public static bool get_DebugLogEnabled() { }

	// RVA: 0x2E2FC54 Offset: 0x2E2BC54 VA: 0x2E2FC54
	public static void set_DebugLogEnabled(bool value) { }

	// RVA: 0x2E2FCB4 Offset: 0x2E2BCB4 VA: 0x2E2FCB4
	public static bool get_WarningLogEnabled() { }

	// RVA: 0x2E2FD0C Offset: 0x2E2BD0C VA: 0x2E2FD0C
	public static void set_WarningLogEnabled(bool value) { }

	// RVA: 0x2E09720 Offset: 0x2E05720 VA: 0x2E09720
	public static void d(string msg) { }

	// RVA: 0x2E0EBF4 Offset: 0x2E0ABF4 VA: 0x2E0EBF4
	public static void w(string msg) { }

	// RVA: 0x2E0B88C Offset: 0x2E0788C VA: 0x2E0B88C
	public static void e(string msg) { }

	// RVA: 0x2E2FD84 Offset: 0x2E2BD84 VA: 0x2E2FD84
	public static string describe(byte[] b) { }

	// RVA: 0x2E2FE24 Offset: 0x2E2BE24 VA: 0x2E2FE24
	private static string ToLogMessage(string prefix, string logType, string msg) { }

	// RVA: 0x2E30158 Offset: 0x2E2C158 VA: 0x2E30158
	public void .ctor() { }

	// RVA: 0x2E30160 Offset: 0x2E2C160 VA: 0x2E30160
	private static void .cctor() { }
}
