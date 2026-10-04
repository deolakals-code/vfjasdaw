// Assembly: System.dll
// Namespace: Mono.Unity
internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 13977
{
	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate2 remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }
	public override X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x3193480 Offset: 0x318F480 VA: 0x3193480
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0x3193E14 Offset: 0x318FE14 VA: 0x3193E14
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x3194168 Offset: 0x3190168 VA: 0x3194168 Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x3194170 Offset: 0x3190170 VA: 0x3194170 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x3194178 Offset: 0x3190178 VA: 0x3194178 Slot: 10
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0x3194180 Offset: 0x3190180 VA: 0x3194180 Slot: 11
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x3194348 Offset: 0x3190348 VA: 0x3194348 Slot: 12
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x3194504 Offset: 0x3190504 VA: 0x3194504 Slot: 15
	public override void Renegotiate() { }

	// RVA: 0x319453C Offset: 0x319053C VA: 0x319453C Slot: 14
	public override bool PendingRenegotiation() { }

	// RVA: 0x3194544 Offset: 0x3190544 VA: 0x3194544 Slot: 13
	public override void Shutdown() { }

	// RVA: 0x3194658 Offset: 0x3190658 VA: 0x3194658 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3194750 Offset: 0x3190750 VA: 0x3194750 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x31948D0 Offset: 0x31908D0 VA: 0x31948D0 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x3194AA4 Offset: 0x3190AA4 VA: 0x3194AA4 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
	// RVA: 0x3193178 Offset: 0x318F178 VA: 0x3193178
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x3194BFC Offset: 0x3190BFC VA: 0x3194BFC
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
	// RVA: 0x3193240 Offset: 0x318F240 VA: 0x3193240
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x3195060 Offset: 0x3191060 VA: 0x3195060
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
	// RVA: 0x3193308 Offset: 0x318F308 VA: 0x3193308
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x3195480 Offset: 0x3191480 VA: 0x3195480
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
	// RVA: 0x31933B8 Offset: 0x318F3B8 VA: 0x31933B8
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x3195928 Offset: 0x3191928 VA: 0x3195928
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}
