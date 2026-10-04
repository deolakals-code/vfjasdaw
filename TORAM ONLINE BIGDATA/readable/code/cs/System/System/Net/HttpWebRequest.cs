// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 14489
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x138
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private HttpWebRequest.AuthorizationState auth_state; // 0x168
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x178
	internal Func<Stream, Task> ResendContentFactory; // 0x188
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; // 0x190
	private bool unsafe_auth_blah; // 0x191

	// Properties
	public Uri Address { get; }
	public virtual bool AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MobileTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override long ContentLength { get; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override ICredentials Credentials { get; set; }
	[MonoTODO]
	public static int DefaultMaximumErrorResponseLength { get; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; }
	public bool KeepAlive { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public Version ProtocolVersion { get; }
	public override IWebProxy Proxy { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }
	internal bool FinishedReading { set; }
	internal bool Aborted { get; }

	// Methods

	// RVA: 0x350C608 Offset: 0x3508608 VA: 0x350C608
	private static void .cctor() { }

	// RVA: 0x350C400 Offset: 0x3508400 VA: 0x350C400
	public void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x350C704 Offset: 0x3508704 VA: 0x350C704
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x350C690 Offset: 0x3508690 VA: 0x350C690
	private void ResetAuthorization() { }

	// RVA: 0x350C89C Offset: 0x350889C VA: 0x350C89C
	public Uri get_Address() { }

	// RVA: 0x350C8A4 Offset: 0x35088A4 VA: 0x350C8A4 Slot: 25
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x350C8AC Offset: 0x35088AC VA: 0x350C8AC
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x350C8B4 Offset: 0x35088B4 VA: 0x350C8B4
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x350C8C8 Offset: 0x35088C8 VA: 0x350C8C8
	private bool get_MethodWithBuffer() { }

	// RVA: 0x350C9C4 Offset: 0x35089C4 VA: 0x350C9C4
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x350C9CC Offset: 0x35089CC VA: 0x350C9CC
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x350C9D4 Offset: 0x35089D4 VA: 0x350C9D4
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x350CA44 Offset: 0x3508A44 VA: 0x350CA44 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x350CA4C Offset: 0x3508A4C VA: 0x350CA4C
	internal void set_InternalContentLength(long value) { }

	[CompilerGenerated]
	// RVA: 0x350CA54 Offset: 0x3508A54 VA: 0x350CA54
	internal bool get_ThrowOnError() { }

	[CompilerGenerated]
	// RVA: 0x350CA5C Offset: 0x3508A5C VA: 0x350CA5C
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x350CA68 Offset: 0x3508A68 VA: 0x350CA68 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x350CA70 Offset: 0x3508A70 VA: 0x350CA70 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x350CA78 Offset: 0x3508A78 VA: 0x350CA78
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x350CAD0 Offset: 0x3508AD0 VA: 0x350CAD0 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x350CAD8 Offset: 0x3508AD8 VA: 0x350CAD8
	public string get_Host() { }

	// RVA: 0x350CBE0 Offset: 0x3508BE0 VA: 0x350CBE0
	public bool get_KeepAlive() { }

	// RVA: 0x350CBE8 Offset: 0x3508BE8 VA: 0x350CBE8
	public int get_ReadWriteTimeout() { }

	// RVA: 0x350CBF0 Offset: 0x3508BF0 VA: 0x350CBF0 Slot: 9
	public override string get_Method() { }

	// RVA: 0x350CBF8 Offset: 0x3508BF8 VA: 0x350CBF8 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x350CE44 Offset: 0x3508E44 VA: 0x350CE44
	public Version get_ProtocolVersion() { }

	// RVA: 0x350CE4C Offset: 0x3508E4C VA: 0x350CE4C Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x350CE54 Offset: 0x3508E54 VA: 0x350CE54 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x350D030 Offset: 0x3509030 VA: 0x350D030 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x350D038 Offset: 0x3509038 VA: 0x350D038
	public bool get_SendChunked() { }

	// RVA: 0x350D040 Offset: 0x3509040 VA: 0x350D040
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x350D044 Offset: 0x3509044 VA: 0x350D044
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x350D04C Offset: 0x350904C VA: 0x350D04C Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x350D054 Offset: 0x3509054 VA: 0x350D054
	public string get_TransferEncoding() { }

	// RVA: 0x350D0A8 Offset: 0x35090A8 VA: 0x350D0A8 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x350D120 Offset: 0x3509120 VA: 0x350D120
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x350D128 Offset: 0x3509128 VA: 0x350D128
	internal bool get_ExpectContinue() { }

	// RVA: 0x350D130 Offset: 0x3509130 VA: 0x350D130
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x350D13C Offset: 0x350913C VA: 0x350D13C
	internal Uri get_AuthUri() { }

	// RVA: 0x350D144 Offset: 0x3509144 VA: 0x350D144
	internal bool get_ProxyQuery() { }

	// RVA: 0x350D178 Offset: 0x3509178 VA: 0x350D178
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x350D180 Offset: 0x3509180 VA: 0x350D180
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x350CEF4 Offset: 0x3508EF4 VA: 0x350CEF4
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x350D198 Offset: 0x3509198 VA: 0x350D198
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C52B4 Offset: 0x26C12B4 VA: 0x26C52B4
	|-HttpWebRequest.RunWithTimeout<int>
	|
	|-RVA: 0x26C53AC Offset: 0x26C13AC VA: 0x26C53AC
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<T>))]
	// RVA: -1 Offset: -1
	private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C54CC Offset: 0x26C14CC VA: 0x26C54CC
	|-HttpWebRequest.RunWithTimeoutWorker<int>
	|
	|-RVA: 0x26C560C Offset: 0x26C160C VA: 0x26C560C
	|-HttpWebRequest.RunWithTimeoutWorker<object>
	|
	|-RVA: 0x26C574C Offset: 0x26C174C VA: 0x26C574C
	|-HttpWebRequest.RunWithTimeoutWorker<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C4FEC Offset: 0x26C0FEC VA: 0x26C4FEC
	|-HttpWebRequest.RunWithTimeout<object>
	|
	|-RVA: 0x26C513C Offset: 0x26C113C VA: 0x26C513C
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<MyGetResponseAsync>d__243))]
	// RVA: 0x350D3CC Offset: 0x35093CC VA: 0x350D3CC
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpWebRequest.<GetResponseFromData>d__244))]
	// RVA: 0x350D500 Offset: 0x3509500 VA: 0x350D500
	private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x350D650 Offset: 0x3509650 VA: 0x350D650
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x350D70C Offset: 0x350970C VA: 0x350D70C
	private WebException GetWebException(Exception e) { }

	// RVA: 0x350D7B8 Offset: 0x35097B8 VA: 0x350D7B8
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x350D95C Offset: 0x350995C VA: 0x350D95C
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x350DA18 Offset: 0x3509A18 VA: 0x350DA18 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x350DB88 Offset: 0x3509B88 VA: 0x350DB88 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x350DCA8 Offset: 0x3509CA8 VA: 0x350DCA8 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x350DDA8 Offset: 0x3509DA8 VA: 0x350DDA8
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x350D790 Offset: 0x3509790 VA: 0x350D790
	internal bool get_Aborted() { }

	// RVA: 0x350DDB4 Offset: 0x3509DB4 VA: 0x350DDB4 Slot: 24
	public override void Abort() { }

	// RVA: 0x350DED0 Offset: 0x3509ED0 VA: 0x350DED0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x350DF08 Offset: 0x3509F08 VA: 0x350DF08 Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x350CE98 Offset: 0x3508E98 VA: 0x350CE98
	private void CheckRequestStarted() { }

	// RVA: 0x350DF40 Offset: 0x3509F40 VA: 0x350DF40
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x350DF5C Offset: 0x3509F5C VA: 0x350DF5C
	private void RewriteRedirectToGet() { }

	// RVA: 0x350DFE0 Offset: 0x3509FE0 VA: 0x350DFE0
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x350E4B8 Offset: 0x350A4B8 VA: 0x350E4B8
	private string GetHeaders() { }

	// RVA: 0x350EB0C Offset: 0x350AB0C VA: 0x350EB0C
	private void DoPreAuthenticate() { }

	// RVA: 0x350ED08 Offset: 0x350AD08 VA: 0x350ED08
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x350F050 Offset: 0x350B050 VA: 0x350F050
	private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x350F2E8 Offset: 0x350B2E8 VA: 0x350F2E8
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x350F618 Offset: 0x350B618 VA: 0x350F618
	private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x350F818 Offset: 0x350B818 VA: 0x350F818
	private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <RunWithTimeout>b__242_0<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C4FDC Offset: 0x26C0FDC VA: 0x26C4FDC
	|-HttpWebRequest.<RunWithTimeout>b__242_0<object>
	|
	|-RVA: 0x26C4FE4 Offset: 0x26C0FE4 VA: 0x26C4FE4
	|-HttpWebRequest.<RunWithTimeout>b__242_0<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d))]
	[CompilerGenerated]
	// RVA: 0x350FD58 Offset: 0x350BD58 VA: 0x350FD58
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	// RVA: 0x350FE6C Offset: 0x350BE6C VA: 0x350FE6C
	public void .ctor() { }
}
