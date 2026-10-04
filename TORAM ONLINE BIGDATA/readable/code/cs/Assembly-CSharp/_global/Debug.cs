// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class Debug // TypeDefIndex: 5216
{
	// Properties
	public static bool isDebugBuild { get; }

	// Methods

	// RVA: 0x2603890 Offset: 0x25FF890 VA: 0x2603890
	public static void Log(string str) { }

	// RVA: 0x260EC10 Offset: 0x260AC10 VA: 0x260EC10
	public static void Log(string str, Object obj) { }

	// RVA: 0x260EC14 Offset: 0x260AC14 VA: 0x260EC14
	public static void Log(object obj) { }

	// RVA: 0x260EC18 Offset: 0x260AC18 VA: 0x260EC18
	public static void Log(Exception e) { }

	// RVA: 0x260EC1C Offset: 0x260AC1C VA: 0x260EC1C
	public static void LogWarning(string str) { }

	// RVA: 0x260EC20 Offset: 0x260AC20 VA: 0x260EC20
	public static void LogWarning(string str, Object obj) { }

	// RVA: 0x260EC24 Offset: 0x260AC24 VA: 0x260EC24
	public static void LogWarning(Exception e) { }

	// RVA: 0x260EC28 Offset: 0x260AC28 VA: 0x260EC28
	public static void LogWarning(object obj) { }

	// RVA: 0x2604C18 Offset: 0x2600C18 VA: 0x2604C18
	public static void LogError(string str) { }

	// RVA: 0x260EC2C Offset: 0x260AC2C VA: 0x260EC2C
	public static void LogError(string str, Object obj) { }

	// RVA: 0x260EC30 Offset: 0x260AC30 VA: 0x260EC30
	public static void LogError(Exception e) { }

	// RVA: 0x26050E0 Offset: 0x26010E0 VA: 0x26050E0
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x260EC34 Offset: 0x260AC34 VA: 0x260EC34
	public static void DrawLine(Vector3 point1, Vector3 point2, Color color) { }

	// RVA: 0x260EC38 Offset: 0x260AC38 VA: 0x260EC38
	public static void DrawLine(Vector3 point1, Vector3 point2, Color color, float duration, bool depthTest) { }

	// RVA: 0x260EC3C Offset: 0x260AC3C VA: 0x260EC3C
	public static void LogException(Exception e) { }

	// RVA: 0x260EC40 Offset: 0x260AC40 VA: 0x260EC40
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x2608320 Offset: 0x2604320 VA: 0x2608320
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x260EC44 Offset: 0x260AC44 VA: 0x260EC44
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	// RVA: 0x260EC48 Offset: 0x260AC48 VA: 0x260EC48
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x260EC4C Offset: 0x260AC4C VA: 0x260EC4C
	public static bool get_isDebugBuild() { }
}
