// Assembly: System.dll
// Namespace: Mono.Net.Security
internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable // TypeDefIndex: 14003
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private MobileAuthenticatedStream.Operation operation; // 0x80
	private static int uniqueNameInteger; // 0x0
	[CompilerGenerated]
	private readonly SslStream <SslStream>k__BackingField; // 0x88
	[CompilerGenerated]
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly MobileTlsProvider <Provider>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0xA0
	private static int nextId; // 0x4
	internal readonly int ID; // 0xA8

	// Properties
	public SslStream SslStream { get; }
	public MonoTlsSettings Settings { get; }
	public MobileTlsProvider Provider { get; }
	internal string TargetHost { get; set; }
	public override bool IsAuthenticated { get; }
	public X509Certificate LocalCertificate { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x3196DC4 Offset: 0x3192DC4 VA: 0x3196DC4
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[CompilerGenerated]
	// RVA: 0x319A8C0 Offset: 0x31968C0 VA: 0x319A8C0 Slot: 38
	public SslStream get_SslStream() { }

	[CompilerGenerated]
	// RVA: 0x319A8C8 Offset: 0x31968C8 VA: 0x319A8C8
	public MonoTlsSettings get_Settings() { }

	[CompilerGenerated]
	// RVA: 0x319A8D0 Offset: 0x31968D0 VA: 0x319A8D0
	public MobileTlsProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x319A8D8 Offset: 0x31968D8 VA: 0x319A8D8
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x319A8E0 Offset: 0x31968E0 VA: 0x319A8E0
	private void set_TargetHost(string value) { }

	// RVA: 0x319A8E8 Offset: 0x31968E8 VA: 0x319A8E8
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x31987E8 Offset: 0x31947E8 VA: 0x31987E8
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x319A9A8 Offset: 0x31969A8 VA: 0x319A9A8
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x319AB24 Offset: 0x3196B24 VA: 0x319AB24
	internal static Exception GetInternalError() { }

	// RVA: 0x319AB70 Offset: 0x3196B70 VA: 0x319AB70
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0x31981F0 Offset: 0x31941F0 VA: 0x31981F0
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x319ABBC Offset: 0x3196BBC VA: 0x319ABBC
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x319AF30 Offset: 0x3196F30 VA: 0x319AF30 Slot: 39
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48))]
	// RVA: 0x319AE00 Offset: 0x3196E00 VA: 0x319AE00
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

	// RVA: 0x319B04C Offset: 0x319704C VA: 0x319B04C Slot: 31
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x319B288 Offset: 0x3197288 VA: 0x319B288 Slot: 34
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x319B354 Offset: 0x3197354 VA: 0x319B354 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x319B3E8 Offset: 0x31973E8 VA: 0x319B3E8 Slot: 27
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<StartOperation>d__57))]
	// RVA: 0x319B12C Offset: 0x319712C VA: 0x319B12C
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x3195374 Offset: 0x3191374 VA: 0x3195374
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x319B47C Offset: 0x319747C VA: 0x319B47C
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x3194E78 Offset: 0x3190E78 VA: 0x3194E78
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x319B5F4 Offset: 0x31975F4 VA: 0x319B5F4
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerRead>d__66))]
	// RVA: 0x3198EA4 Offset: 0x3194EA4 VA: 0x3198EA4
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerWrite>d__67))]
	// RVA: 0x319897C Offset: 0x319497C VA: 0x319897C
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x319908C Offset: 0x319508C VA: 0x319908C
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0x31995D8 Offset: 0x31955D8 VA: 0x31995D8
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x31997B8 Offset: 0x31957B8 VA: 0x31997B8
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x319B6E8 Offset: 0x31976E8 VA: 0x319B6E8 Slot: 37
	public override bool get_IsAuthenticated() { }

	// RVA: 0x319B7D0 Offset: 0x31977D0 VA: 0x319B7D0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x319BA24 Offset: 0x3197A24 VA: 0x319BA24 Slot: 20
	public override void Flush() { }

	// RVA: 0x319BA48 Offset: 0x3197A48 VA: 0x319BA48 Slot: 41
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0x319BB24 Offset: 0x3197B24 VA: 0x319BB24 Slot: 42
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x319BC24 Offset: 0x3197C24 VA: 0x319BC24 Slot: 29
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x319BC5C Offset: 0x3197C5C VA: 0x319BC5C Slot: 30
	public override void SetLength(long value) { }

	// RVA: 0x319BC80 Offset: 0x3197C80 VA: 0x319BC80 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x319BCC4 Offset: 0x3197CC4 VA: 0x319BCC4 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x319BCE4 Offset: 0x3197CE4 VA: 0x319BCE4 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x319BD48 Offset: 0x3197D48 VA: 0x319BD48 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x319BD50 Offset: 0x3197D50 VA: 0x319BD50 Slot: 11
	public override long get_Length() { }

	// RVA: 0x319BD70 Offset: 0x3197D70 VA: 0x319BD70 Slot: 12
	public override long get_Position() { }

	// RVA: 0x319BD90 Offset: 0x3197D90 VA: 0x319BD90 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x319BDC8 Offset: 0x3197DC8 VA: 0x319BDC8 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x319BDEC Offset: 0x3197DEC VA: 0x319BDEC Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x319BE10 Offset: 0x3197E10 VA: 0x319BE10 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x319BE34 Offset: 0x3197E34 VA: 0x319BE34 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x319BE58 Offset: 0x3197E58 VA: 0x319BE58
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x319BEA4 Offset: 0x3197EA4 VA: 0x319BEA4
	private void <InnerWrite>b__67_0() { }
}
