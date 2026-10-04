// Assembly: System.dll
// Namespace: System.Net.Security
public class SslStream : AuthenticatedStream // TypeDefIndex: 14603
{
	// Fields
	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Properties
	internal MobileAuthenticatedStream Impl { get; }
	internal string InternalTargetHost { get; }
	public override bool IsAuthenticated { get; }
	public virtual X509Certificate LocalCertificate { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x345FEFC Offset: 0x345BEFC VA: 0x345FEFC
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x345FF70 Offset: 0x345BF70 VA: 0x345FF70
	internal string get_InternalTargetHost() { }

	// RVA: 0x345FF94 Offset: 0x345BF94 VA: 0x345FF94
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x3460004 Offset: 0x345C004 VA: 0x3460004
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x3460010 Offset: 0x345C010 VA: 0x3460010
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x346038C Offset: 0x345C38C VA: 0x346038C
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x34600CC Offset: 0x345C0CC VA: 0x34600CC
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x34601D0 Offset: 0x345C1D0 VA: 0x34601D0
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x34604D4 Offset: 0x345C4D4 VA: 0x34604D4 Slot: 38
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x3460528 Offset: 0x345C528 VA: 0x3460528 Slot: 39
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x346059C Offset: 0x345C59C VA: 0x346059C Slot: 40
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x34605A8 Offset: 0x345C5A8 VA: 0x34605A8 Slot: 41
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x34605FC Offset: 0x345C5FC VA: 0x34605FC Slot: 37
	public override bool get_IsAuthenticated() { }

	// RVA: 0x3460628 Offset: 0x345C628 VA: 0x3460628 Slot: 42
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x346064C Offset: 0x345C64C VA: 0x346064C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x3460654 Offset: 0x345C654 VA: 0x3460654 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x346066C Offset: 0x345C66C VA: 0x346066C Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x346068C Offset: 0x345C68C VA: 0x346068C Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34606A4 Offset: 0x345C6A4 VA: 0x34606A4 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x34606D0 Offset: 0x345C6D0 VA: 0x34606D0 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x346070C Offset: 0x345C70C VA: 0x346070C Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x3460738 Offset: 0x345C738 VA: 0x3460738 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x3460774 Offset: 0x345C774 VA: 0x3460774 Slot: 11
	public override long get_Length() { }

	// RVA: 0x346079C Offset: 0x345C79C VA: 0x346079C Slot: 12
	public override long get_Position() { }

	// RVA: 0x34607C4 Offset: 0x345C7C4 VA: 0x34607C4 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x346081C Offset: 0x345C81C VA: 0x346081C Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x3460858 Offset: 0x345C858 VA: 0x3460858 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x34608B0 Offset: 0x345C8B0 VA: 0x34608B0 Slot: 20
	public override void Flush() { }

	// RVA: 0x345FF14 Offset: 0x345BF14 VA: 0x345FF14
	private void CheckDisposed() { }

	// RVA: 0x34608D4 Offset: 0x345C8D4 VA: 0x34608D4 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3460990 Offset: 0x345C990 VA: 0x3460990 Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x34609E4 Offset: 0x345C9E4 VA: 0x34609E4 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x3460A38 Offset: 0x345CA38 VA: 0x3460A38 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x3460A94 Offset: 0x345CA94 VA: 0x3460A94 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x3460AF0 Offset: 0x345CAF0 VA: 0x3460AF0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3460B5C Offset: 0x345CB5C VA: 0x3460B5C Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x3460BA4 Offset: 0x345CBA4 VA: 0x3460BA4 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3460C10 Offset: 0x345CC10 VA: 0x3460C10 Slot: 26
	public override void EndWrite(IAsyncResult asyncResult) { }
}
