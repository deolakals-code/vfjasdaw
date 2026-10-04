// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public static class StackTraceUtility // TypeDefIndex: 16367
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37EDA68 Offset: 0x37E9A68 VA: 0x37EDA68
	internal static void SetProjectFolder(string folder) { }

	[RequiredByNativeCode]
	// RVA: 0x37EDB6C Offset: 0x37E9B6C VA: 0x37EDB6C
	public static string ExtractStackTrace() { }

	[RequiredByNativeCode]
	// RVA: 0x37EE3D4 Offset: 0x37EA3D4 VA: 0x37EE3D4
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	// RVA: 0x37EDCC8 Offset: 0x37E9CC8 VA: 0x37EDCC8
	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x37EE750 Offset: 0x37EA750 VA: 0x37EE750
	private static void .cctor() { }
}
