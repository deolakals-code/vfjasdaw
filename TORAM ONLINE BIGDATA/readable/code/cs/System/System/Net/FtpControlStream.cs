// Assembly: System.dll
// Namespace: System.Net
internal class FtpControlStream : CommandStream // TypeDefIndex: 14371
{
	// Fields
	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private long _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Properties
	internal NetworkCredential Credentials { get; set; }
	internal long ContentLength { get; }
	internal DateTime LastModified { get; }
	internal Uri ResponseUri { get; }
	internal string BannerMessage { get; }
	internal string WelcomeMessage { get; }
	internal string ExitMessage { get; }

	// Methods

	// RVA: 0x34E0C7C Offset: 0x34DCC7C VA: 0x34E0C7C
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x34E0D24 Offset: 0x34DCD24 VA: 0x34E0D24
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x34E0DB0 Offset: 0x34DCDB0 VA: 0x34E0DB0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x34E0E4C Offset: 0x34DCE4C VA: 0x34E0E4C
	internal void AbortConnect() { }

	// RVA: 0x34E0ED8 Offset: 0x34DCED8 VA: 0x34E0ED8
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x34E12F0 Offset: 0x34DD2F0 VA: 0x34E12F0
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x34E14A0 Offset: 0x34DD4A0 VA: 0x34E14A0
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x34E1650 Offset: 0x34DD650 VA: 0x34E1650
	private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x34E1C3C Offset: 0x34DDC3C VA: 0x34E1C3C Slot: 38
	protected override void ClearState() { }

	// RVA: 0x34E1D0C Offset: 0x34DDD0C VA: 0x34E1D0C Slot: 40
	protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x34E3640 Offset: 0x34DF640 VA: 0x34E3640 Slot: 39
	protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x34E25AC Offset: 0x34DE5AC VA: 0x34E25AC
	private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	// RVA: 0x34E46AC Offset: 0x34E06AC VA: 0x34E46AC
	private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	// RVA: 0x34E50D8 Offset: 0x34E10D8 VA: 0x34E50D8
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x34E5204 Offset: 0x34E1204 VA: 0x34E5204
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x34E5314 Offset: 0x34E1314 VA: 0x34E5314
	internal long get_ContentLength() { }

	// RVA: 0x34E531C Offset: 0x34E131C VA: 0x34E531C
	internal DateTime get_LastModified() { }

	// RVA: 0x34E5324 Offset: 0x34E1324 VA: 0x34E5324
	internal Uri get_ResponseUri() { }

	// RVA: 0x34E532C Offset: 0x34E132C VA: 0x34E532C
	internal string get_BannerMessage() { }

	// RVA: 0x34E5344 Offset: 0x34E1344 VA: 0x34E5344
	internal string get_WelcomeMessage() { }

	// RVA: 0x34E535C Offset: 0x34E135C VA: 0x34E535C
	internal string get_ExitMessage() { }

	// RVA: 0x34E30D8 Offset: 0x34DF0D8 VA: 0x34E30D8
	private long GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x34E3210 Offset: 0x34DF210 VA: 0x34E3210
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x34E2D6C Offset: 0x34DED6C VA: 0x34E2D6C
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x34E2C74 Offset: 0x34DEC74 VA: 0x34E2C74
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x34E3590 Offset: 0x34DF590 VA: 0x34E3590
	private string GetLoginDirectory(string str) { }

	// RVA: 0x34E4C30 Offset: 0x34E0C30 VA: 0x34E4C30
	private int GetPortV4(string responseString) { }

	// RVA: 0x34E4E18 Offset: 0x34E0E18 VA: 0x34E4E18
	private int GetPortV6(string responseString) { }

	// RVA: 0x34E48AC Offset: 0x34E08AC VA: 0x34E48AC
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x34E4A30 Offset: 0x34E0A30 VA: 0x34E4A30
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x34E4588 Offset: 0x34E0588 VA: 0x34E4588
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x34E4FD0 Offset: 0x34E0FD0 VA: 0x34E4FD0
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x34E5374 Offset: 0x34E1374 VA: 0x34E5374 Slot: 41
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x34E1924 Offset: 0x34DD924 VA: 0x34E1924
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x34E576C Offset: 0x34E176C VA: 0x34E576C
	private static void .cctor() { }
}
