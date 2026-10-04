// Assembly: System.dll
// Namespace: Mono.Net.Security
internal abstract class MobileTlsProvider : MonoTlsProvider // TypeDefIndex: 14005
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

	// RVA: 0x3196DBC Offset: 0x3192DBC VA: 0x3196DBC
	protected void .ctor() { }
}
