// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngineInternal
internal static class WebRequestUtils // TypeDefIndex: 17600
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x38240F0 Offset: 0x38200F0 VA: 0x38240F0
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x38241DC Offset: 0x38201DC VA: 0x38241DC
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x382454C Offset: 0x382054C VA: 0x382454C
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x3824930 Offset: 0x3820930 VA: 0x3824930
	private static string URLDecode(string encoded) { }

	// RVA: 0x3824A38 Offset: 0x3820A38 VA: 0x3824A38
	private static void .cctor() { }
}
