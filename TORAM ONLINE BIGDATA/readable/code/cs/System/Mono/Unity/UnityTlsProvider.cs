// Assembly: System.dll
// Namespace: Mono.Unity
internal class UnityTlsProvider : MobileTlsProvider // TypeDefIndex: 13979
{
	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x31961C4 Offset: 0x31921C4 VA: 0x31961C4 Slot: 5
	public override string get_Name() { }

	// RVA: 0x3196204 Offset: 0x3192204 VA: 0x3196204 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x319625C Offset: 0x319225C VA: 0x319625C Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x3196264 Offset: 0x3192264 VA: 0x3196264 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x319626C Offset: 0x319226C VA: 0x319626C Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x3196274 Offset: 0x3192274 VA: 0x3196274 Slot: 10
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x319627C Offset: 0x319227C VA: 0x319627C Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x3196284 Offset: 0x3192284 VA: 0x3196284 Slot: 11
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
	// RVA: 0x3196160 Offset: 0x3192160 VA: 0x3196160
	private static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x31963A0 Offset: 0x31923A0 VA: 0x31963A0 Slot: 12
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x3196DB4 Offset: 0x3192DB4 VA: 0x3196DB4
	public void .ctor() { }
}
