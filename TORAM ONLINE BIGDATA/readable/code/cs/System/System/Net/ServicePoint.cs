// Assembly: System.dll
// Namespace: System.Net
public class ServicePoint // TypeDefIndex: 14499
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	[CompilerGenerated]
	private readonly ServicePointManager.SPKey <Key>k__BackingField; // 0x68
	[CompilerGenerated]
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Properties
	internal ServicePointManager.SPKey Key { get; }
	private ServicePointScheduler Scheduler { get; set; }
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x3514DC0 Offset: 0x3510DC0 VA: 0x3514DC0
	internal void .ctor(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGenerated]
	// RVA: 0x35150D8 Offset: 0x35110D8 VA: 0x35150D8
	internal ServicePointManager.SPKey get_Key() { }

	[CompilerGenerated]
	// RVA: 0x35150E0 Offset: 0x35110E0 VA: 0x35150E0
	private ServicePointScheduler get_Scheduler() { }

	[CompilerGenerated]
	// RVA: 0x35150E8 Offset: 0x35110E8 VA: 0x35150E8
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x35150F0 Offset: 0x35110F0 VA: 0x35150F0
	public Uri get_Address() { }

	// RVA: 0x35150F8 Offset: 0x35110F8 VA: 0x35150F8
	public int get_ConnectionLimit() { }

	// RVA: 0x3515100 Offset: 0x3511100 VA: 0x3515100 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x3515108 Offset: 0x3511108 VA: 0x3515108
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x3515114 Offset: 0x3511114 VA: 0x3515114
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x351511C Offset: 0x351111C VA: 0x351511C
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x3515128 Offset: 0x3511128 VA: 0x3515128
	internal bool get_SendContinue() { }

	// RVA: 0x35151C4 Offset: 0x35111C4 VA: 0x35151C4
	internal void set_SendContinue(bool value) { }

	// RVA: 0x35151D0 Offset: 0x35111D0 VA: 0x35151D0
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x3515280 Offset: 0x3511280 VA: 0x3515280
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x3515334 Offset: 0x3511334 VA: 0x3515334
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x35153B4 Offset: 0x35113B4 VA: 0x35153B4
	internal bool get_UsesProxy() { }

	// RVA: 0x35153BC Offset: 0x35113BC VA: 0x35153BC
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x35153C8 Offset: 0x35113C8 VA: 0x35153C8
	internal bool get_UseConnect() { }

	// RVA: 0x35153D0 Offset: 0x35113D0 VA: 0x35153D0
	internal void set_UseConnect(bool value) { }

	// RVA: 0x35153DC Offset: 0x35113DC VA: 0x35153DC
	private bool get_HasTimedOut() { }

	// RVA: 0x3515508 Offset: 0x3511508 VA: 0x3515508
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x35158C8 Offset: 0x35118C8 VA: 0x35158C8
	internal void SetVersion(Version version) { }

	// RVA: 0x35158D0 Offset: 0x35118D0 VA: 0x35158D0
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x3515B28 Offset: 0x3511B28 VA: 0x3515B28
	internal void FreeServicePoint() { }

	// RVA: 0x3515B3C Offset: 0x3511B3C VA: 0x3515B3C
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x3515B78 Offset: 0x3511B78 VA: 0x3515B78
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x3515BB4 Offset: 0x3511BB4 VA: 0x3515BB4
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }
}
