// Assembly: System.dll
// Namespace: System.Net
internal class WebOperation // TypeDefIndex: 14525
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private WebConnection <Connection>k__BackingField; // 0x18
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private WebCompletionSource<WebRequestStream> requestTask; // 0x40
	private WebCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
	private WebCompletionSource<WebResponseStream> responseTask; // 0x50
	private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Properties
	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x351FB74 Offset: 0x351BB74 VA: 0x351FB74
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x351FB7C Offset: 0x351BB7C VA: 0x351FB7C
	public WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x351FB84 Offset: 0x351BB84 VA: 0x351FB84
	private void set_Connection(WebConnection value) { }

	[CompilerGenerated]
	// RVA: 0x351FB8C Offset: 0x351BB8C VA: 0x351FB8C
	public ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x351FB94 Offset: 0x351BB94 VA: 0x351FB94
	private void set_ServicePoint(ServicePoint value) { }

	[CompilerGenerated]
	// RVA: 0x351FB9C Offset: 0x351BB9C VA: 0x351FB9C
	public BufferOffsetSize get_WriteBuffer() { }

	[CompilerGenerated]
	// RVA: 0x351FBA4 Offset: 0x351BBA4 VA: 0x351FBA4
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x351FBAC Offset: 0x351BBAC VA: 0x351FBAC
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x3518320 Offset: 0x3514320 VA: 0x3518320
	public bool get_Aborted() { }

	// RVA: 0x351FD94 Offset: 0x351BD94 VA: 0x351FD94
	public bool get_Closed() { }

	// RVA: 0x351FDC0 Offset: 0x351BDC0 VA: 0x351FDC0
	public void Abort() { }

	// RVA: 0x351FFB0 Offset: 0x351BFB0 VA: 0x351FFB0
	public void Close() { }

	// RVA: 0x351FEE8 Offset: 0x351BEE8 VA: 0x351FEE8
	private void SetCanceled() { }

	// RVA: 0x3520298 Offset: 0x351C298 VA: 0x3520298
	private void SetError(Exception error) { }

	// RVA: 0x351FE00 Offset: 0x351BE00 VA: 0x351FE00
	private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x352033C Offset: 0x351C33C VA: 0x352033C
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x352041C Offset: 0x351C41C VA: 0x352041C
	internal void ThrowIfDisposed() { }

	// RVA: 0x351BF94 Offset: 0x3517F94 VA: 0x351BF94
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x351D788 Offset: 0x3519788 VA: 0x351D788
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x351CF04 Offset: 0x3518F04 VA: 0x351CF04
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x35203C4 Offset: 0x351C3C4 VA: 0x35203C4
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x351AFB4 Offset: 0x3516FB4 VA: 0x351AFB4
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x352047C Offset: 0x351C47C VA: 0x352047C
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x35205F8 Offset: 0x351C5F8 VA: 0x35205F8
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x3520648 Offset: 0x351C648 VA: 0x3520648
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x3520660 Offset: 0x351C660 VA: 0x3520660
	public Task<WebResponseStream> GetResponseStream() { }

	// RVA: 0x35206B0 Offset: 0x351C6B0 VA: 0x35206B0
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> get_Finished() { }

	[AsyncStateMachine(typeof(WebOperation.<Run>d__58))]
	// RVA: 0x351B238 Offset: 0x3517238 VA: 0x351B238
	internal void Run() { }

	// RVA: 0x35206B8 Offset: 0x351C6B8 VA: 0x35206B8
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x352005C Offset: 0x351C05C VA: 0x352005C
	internal void Finish(bool ok, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x3520738 Offset: 0x351C738 VA: 0x3520738
	private void <RegisterRequest>b__48_0() { }
}
