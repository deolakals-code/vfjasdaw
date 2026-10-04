// Assembly: System.dll
// Namespace: Mono.Net.Security
internal class MonoTlsStream : IDisposable // TypeDefIndex: 14010
{
	// Fields
	private readonly MobileTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private SslStream sslStream; // 0x30
	private readonly object sslStreamLock; // 0x38
	private WebExceptionStatus status; // 0x40
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; // 0x44

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x319EBD8 Offset: 0x319ABD8 VA: 0x319EBD8
	internal HttpWebRequest get_Request() { }

	// RVA: 0x319EBE0 Offset: 0x319ABE0 VA: 0x319EBE0
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGenerated]
	// RVA: 0x319EBE8 Offset: 0x319ABE8 VA: 0x319EBE8
	internal bool get_CertificateValidationFailed() { }

	[CompilerGenerated]
	// RVA: 0x319EBF0 Offset: 0x319ABF0 VA: 0x319EBF0
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x319EBFC Offset: 0x319ABFC VA: 0x319EBFC
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	[AsyncStateMachine(typeof(MonoTlsStream.<CreateStream>d__18))]
	// RVA: 0x319EE28 Offset: 0x319AE28 VA: 0x319EE28
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0x319EF74 Offset: 0x319AF74 VA: 0x319EF74 Slot: 4
	public void Dispose() { }

	// RVA: 0x319EF78 Offset: 0x319AF78 VA: 0x319EF78
	private void CloseSslStream() { }
}
