// Assembly: System.dll
// Namespace: Mono.Unity
internal static class UnityTlsConversions // TypeDefIndex: 13978
{
	// Methods

	// RVA: 0x3193DA4 Offset: 0x318FDA4 VA: 0x3193DA4
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x3193DDC Offset: 0x318FDDC VA: 0x3193DDC
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x3194BDC Offset: 0x3190BDC VA: 0x3194BDC
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x3191524 Offset: 0x318D524 VA: 0x3191524
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x31960F0 Offset: 0x31920F0 VA: 0x31960F0
	public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

	// RVA: 0x3196120 Offset: 0x3192120 VA: 0x3196120
	public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult) { }
}
