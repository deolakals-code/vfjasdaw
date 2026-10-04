// Assembly: System.dll
// Namespace: System.Net
public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 14379
{
	// Fields
	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private long _contentLength; // 0x78
	private long _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private bool _async; // 0x92
	private bool _aborted; // 0x93
	private bool _timedOut; // 0x94
	private Exception _exception; // 0x98
	private TimerThread.Queue _timerQueue; // 0xA0
	private TimerThread.Callback _timerCallback; // 0xA8
	private bool _enableSsl; // 0xB0
	private FtpControlStream _connection; // 0xB8
	private Stream _stream; // 0xC0
	private FtpWebRequest.RequestStage _requestStage; // 0xC8
	private bool _onceFailed; // 0xCC
	private WebHeaderCollection _ftpRequestHeaders; // 0xD0
	private FtpWebResponse _ftpWebResponse; // 0xD8
	private int _readWriteTimeout; // 0xE0
	private ContextAwareResult _writeAsyncResult; // 0xE8
	private LazyAsyncResult _readAsyncResult; // 0xF0
	private LazyAsyncResult _requestCompleteAsyncResult; // 0xF8
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private static readonly TimerThread.Queue s_DefaultTimerQueue; // 0x8

	// Properties
	internal FtpMethodInfo MethodInfo { get; }
	public override string Method { get; set; }
	public string RenameTo { get; }
	public override ICredentials Credentials { get; set; }
	public override Uri RequestUri { get; }
	public override int Timeout { get; }
	internal int RemainingTimeout { get; }
	public int ReadWriteTimeout { get; }
	public long ContentOffset { get; }
	public override long ContentLength { get; }
	public override IWebProxy Proxy { get; set; }
	internal bool Aborted { get; }
	private TimerThread.Queue TimerQueue { get; }
	public override RequestCachePolicy CachePolicy { set; }
	public bool UseBinary { get; }
	public bool UsePassive { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public bool EnableSsl { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool UseDefaultCredentials { get; }
	private bool InUse { get; }

	// Methods

	// RVA: 0x34E7408 Offset: 0x34E3408 VA: 0x34E7408
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x34E7410 Offset: 0x34E3410 VA: 0x34E7410 Slot: 9
	public override string get_Method() { }

	// RVA: 0x34E742C Offset: 0x34E342C VA: 0x34E742C Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x34E75F0 Offset: 0x34E35F0 VA: 0x34E75F0
	public string get_RenameTo() { }

	// RVA: 0x34E75F8 Offset: 0x34E35F8 VA: 0x34E75F8 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x34E7600 Offset: 0x34E3600 VA: 0x34E7600 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x34E774C Offset: 0x34E374C VA: 0x34E774C Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x34E7754 Offset: 0x34E3754 VA: 0x34E7754 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x34E775C Offset: 0x34E375C VA: 0x34E775C
	internal int get_RemainingTimeout() { }

	// RVA: 0x34E7764 Offset: 0x34E3764 VA: 0x34E7764
	public int get_ReadWriteTimeout() { }

	// RVA: 0x34E776C Offset: 0x34E376C VA: 0x34E776C
	public long get_ContentOffset() { }

	// RVA: 0x34E7774 Offset: 0x34E3774 VA: 0x34E7774 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x34E777C Offset: 0x34E377C VA: 0x34E777C Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x34E7784 Offset: 0x34E3784 VA: 0x34E7784 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x34E77E8 Offset: 0x34E37E8 VA: 0x34E77E8
	internal bool get_Aborted() { }

	// RVA: 0x34E77F0 Offset: 0x34E37F0 VA: 0x34E77F0
	internal void .ctor(Uri uri) { }

	// RVA: 0x34E7C8C Offset: 0x34E3C8C VA: 0x34E7C8C Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x34E974C Offset: 0x34E574C VA: 0x34E974C Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x34E9E7C Offset: 0x34E5E7C VA: 0x34E9E7C Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x34E8928 Offset: 0x34E4928 VA: 0x34E8928
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x34EABBC Offset: 0x34E6BBC VA: 0x34EABBC
	private Exception TranslateConnectException(Exception e) { }

	[AsyncStateMachine(typeof(FtpWebRequest.<CreateConnectionAsync>d__86))]
	// RVA: 0x34EA29C Offset: 0x34E629C VA: 0x34EA29C
	private void CreateConnectionAsync() { }

	// RVA: 0x34EA348 Offset: 0x34E6348 VA: 0x34EA348
	private FtpControlStream CreateConnection() { }

	// RVA: 0x34EA4FC Offset: 0x34E64FC VA: 0x34EA4FC
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x34EAD38 Offset: 0x34E6D38 VA: 0x34EAD38
	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x34EACBC Offset: 0x34E6CBC VA: 0x34EACBC
	private TimerThread.Queue get_TimerQueue() { }

	// RVA: 0x34EA924 Offset: 0x34E6924 VA: 0x34EA924
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x34E9380 Offset: 0x34E5380 VA: 0x34E9380
	private void SetException(Exception exception) { }

	// RVA: 0x34E8450 Offset: 0x34E4450 VA: 0x34E8450
	private void CheckError() { }

	// RVA: 0x34DECC0 Offset: 0x34DACC0 VA: 0x34DECC0
	internal void RequestCallback(object obj) { }

	// RVA: 0x34EC2C0 Offset: 0x34E82C0 VA: 0x34EC2C0
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x34EB7E0 Offset: 0x34E77E0 VA: 0x34EB7E0
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x34E84DC Offset: 0x34E44DC VA: 0x34E84DC
	private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage) { }

	// RVA: 0x34EC6CC Offset: 0x34E86CC VA: 0x34EC6CC Slot: 24
	public override void Abort() { }

	// RVA: 0x34ECB90 Offset: 0x34E8B90 VA: 0x34ECB90 Slot: 8
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x34ECBF4 Offset: 0x34E8BF4 VA: 0x34ECBF4
	public bool get_UseBinary() { }

	// RVA: 0x34ECBFC Offset: 0x34E8BFC VA: 0x34ECBFC
	public bool get_UsePassive() { }

	// RVA: 0x34E1B40 Offset: 0x34DDB40 VA: 0x34E1B40
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x34ECC04 Offset: 0x34E8C04 VA: 0x34ECC04
	public bool get_EnableSsl() { }

	// RVA: 0x34ECC0C Offset: 0x34E8C0C VA: 0x34ECC0C Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x34ECCDC Offset: 0x34E8CDC VA: 0x34ECCDC Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x34E75D8 Offset: 0x34E35D8 VA: 0x34E75D8
	private bool get_InUse() { }

	// RVA: 0x34E8E74 Offset: 0x34E4E74 VA: 0x34E8E74
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x34ECFA0 Offset: 0x34E8FA0 VA: 0x34ECFA0
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x34ED01C Offset: 0x34E901C VA: 0x34ED01C
	private static void .cctor() { }
}
