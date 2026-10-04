// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2 // TypeDefIndex: 14155
{
	// Methods

	[MonoTODO("Investigate replacement; see comments in source.")]
	// RVA: 0x3499688 Offset: 0x3495688 VA: 0x3499688
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x3496008 Offset: 0x3492008 VA: 0x3496008
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x349B8C8 Offset: 0x34978C8 VA: 0x349B8C8
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x3495F88 Offset: 0x3491F88 VA: 0x3495F88
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x3496FF4 Offset: 0x3492FF4 VA: 0x3496FF4
	internal static Exception GetInvalidChainContextException() { }
}
