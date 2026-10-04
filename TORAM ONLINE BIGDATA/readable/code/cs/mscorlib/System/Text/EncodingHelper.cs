// Assembly: mscorlib.dll
// Namespace: System.Text
internal static class EncodingHelper // TypeDefIndex: 10064
{
	// Fields
	private static Encoding utf8EncodingWithoutMarkers; // 0x0
	private static readonly object lockobj; // 0x8
	private static Assembly i18nAssembly; // 0x10
	private static bool i18nDisabled; // 0x18

	// Properties
	internal static Encoding UTF8Unmarked { get; }

	// Methods

	// RVA: 0x2EA1A8C Offset: 0x2E9DA8C VA: 0x2EA1A8C
	internal static Encoding get_UTF8Unmarked() { }

	// RVA: 0x2EA1C80 Offset: 0x2E9DC80 VA: 0x2EA1C80
	internal static string InternalCodePage(ref int code_page) { }

	// RVA: 0x2E9E7A8 Offset: 0x2E9A7A8 VA: 0x2E9E7A8
	internal static Encoding GetDefaultEncoding() { }

	// RVA: 0x2E9CC3C Offset: 0x2E98C3C VA: 0x2E9CC3C
	internal static object InvokeI18N(string name, object[] args) { }

	// RVA: 0x2EA1C84 Offset: 0x2E9DC84 VA: 0x2EA1C84
	private static void .cctor() { }
}
