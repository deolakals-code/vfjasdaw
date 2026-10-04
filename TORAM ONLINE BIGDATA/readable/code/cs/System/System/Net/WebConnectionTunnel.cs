// Assembly: System.dll
// Namespace: System.Net
internal class WebConnectionTunnel // TypeDefIndex: 14523
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	[CompilerGenerated]
	private bool <Success>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <CloseConnection>k__BackingField; // 0x2D
	[CompilerGenerated]
	private int <StatusCode>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <Challenge>k__BackingField; // 0x40
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	[CompilerGenerated]
	private Version <ProxyVersion>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x58

	// Properties
	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	private string StatusDescription { set; }
	public string[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public byte[] Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x351E10C Offset: 0x351A10C VA: 0x351E10C
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x351E114 Offset: 0x351A114 VA: 0x351E114
	public Uri get_ConnectUri() { }

	// RVA: 0x351C7D4 Offset: 0x35187D4 VA: 0x351C7D4
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	[CompilerGenerated]
	// RVA: 0x351E11C Offset: 0x351A11C VA: 0x351E11C
	public bool get_Success() { }

	[CompilerGenerated]
	// RVA: 0x351E124 Offset: 0x351A124 VA: 0x351E124
	private void set_Success(bool value) { }

	[CompilerGenerated]
	// RVA: 0x351E130 Offset: 0x351A130 VA: 0x351E130
	public bool get_CloseConnection() { }

	[CompilerGenerated]
	// RVA: 0x351E138 Offset: 0x351A138 VA: 0x351E138
	private void set_CloseConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x351E144 Offset: 0x351A144 VA: 0x351E144
	public int get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x351E14C Offset: 0x351A14C VA: 0x351E14C
	private void set_StatusCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x351E154 Offset: 0x351A154 VA: 0x351E154
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x351E15C Offset: 0x351A15C VA: 0x351E15C
	public string[] get_Challenge() { }

	[CompilerGenerated]
	// RVA: 0x351E164 Offset: 0x351A164 VA: 0x351E164
	private void set_Challenge(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x351E16C Offset: 0x351A16C VA: 0x351E16C
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x351E174 Offset: 0x351A174 VA: 0x351E174
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x351E17C Offset: 0x351A17C VA: 0x351E17C
	public Version get_ProxyVersion() { }

	[CompilerGenerated]
	// RVA: 0x351E184 Offset: 0x351A184 VA: 0x351E184
	private void set_ProxyVersion(Version value) { }

	[CompilerGenerated]
	// RVA: 0x351E18C Offset: 0x351A18C VA: 0x351E18C
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x351E194 Offset: 0x351A194 VA: 0x351E194
	private void set_Data(byte[] value) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<Initialize>d__42))]
	// RVA: 0x351C818 Offset: 0x3518818 VA: 0x351C818
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<ReadHeaders>d__43))]
	// RVA: 0x351E19C Offset: 0x351A19C VA: 0x351E19C
	private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x351E2EC Offset: 0x351A2EC VA: 0x351E2EC
	private void FlushContents(Stream stream, int contentLength) { }
}
