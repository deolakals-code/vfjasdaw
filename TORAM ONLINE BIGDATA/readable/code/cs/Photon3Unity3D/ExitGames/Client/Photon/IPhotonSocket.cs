// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public abstract class IPhotonSocket // TypeDefIndex: 17002
{
	// Fields
	protected internal PeerBase peerBase; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ConnectionProtocol <Protocol>k__BackingField; // 0x18
	public bool PollReceive; // 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private PhotonSocketState <State>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <ServerAddress>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <ServerPort>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <AddressResolvedAsIpv6>k__BackingField; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <UrlProtocol>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <UrlPath>k__BackingField; // 0x38

	// Properties
	protected IPhotonPeerListener Listener { get; }
	public ConnectionProtocol Protocol { get; set; }
	public PhotonSocketState State { get; set; }
	public string ServerAddress { get; set; }
	public int ServerPort { get; set; }
	public bool AddressResolvedAsIpv6 { get; set; }
	protected string UrlProtocol { set; }
	protected string UrlPath { set; }
	public bool Connected { get; }
	protected internal int MTU { get; }

	// Methods

	// RVA: 0x310A058 Offset: 0x3106058 VA: 0x310A058
	protected IPhotonPeerListener get_Listener() { }

	[CompilerGenerated]
	// RVA: 0x310A074 Offset: 0x3106074 VA: 0x310A074
	public ConnectionProtocol get_Protocol() { }

	[CompilerGenerated]
	// RVA: 0x310A07C Offset: 0x310607C VA: 0x310A07C
	protected void set_Protocol(ConnectionProtocol value) { }

	[CompilerGenerated]
	// RVA: 0x310A084 Offset: 0x3106084 VA: 0x310A084
	public PhotonSocketState get_State() { }

	[CompilerGenerated]
	// RVA: 0x310A08C Offset: 0x310608C VA: 0x310A08C
	protected void set_State(PhotonSocketState value) { }

	[CompilerGenerated]
	// RVA: 0x310A094 Offset: 0x3106094 VA: 0x310A094
	public string get_ServerAddress() { }

	[CompilerGenerated]
	// RVA: 0x310A09C Offset: 0x310609C VA: 0x310A09C
	protected void set_ServerAddress(string value) { }

	[CompilerGenerated]
	// RVA: 0x310A0A4 Offset: 0x31060A4 VA: 0x310A0A4
	public int get_ServerPort() { }

	[CompilerGenerated]
	// RVA: 0x310A0AC Offset: 0x31060AC VA: 0x310A0AC
	protected void set_ServerPort(int value) { }

	[CompilerGenerated]
	// RVA: 0x310A0B4 Offset: 0x31060B4 VA: 0x310A0B4
	public bool get_AddressResolvedAsIpv6() { }

	[CompilerGenerated]
	// RVA: 0x310A0BC Offset: 0x31060BC VA: 0x310A0BC
	protected internal void set_AddressResolvedAsIpv6(bool value) { }

	[CompilerGenerated]
	// RVA: 0x310A0C8 Offset: 0x31060C8 VA: 0x310A0C8
	protected void set_UrlProtocol(string value) { }

	[CompilerGenerated]
	// RVA: 0x310A0D0 Offset: 0x31060D0 VA: 0x310A0D0
	protected void set_UrlPath(string value) { }

	// RVA: 0x3102834 Offset: 0x30FE834 VA: 0x3102834
	public bool get_Connected() { }

	// RVA: 0x310A0D8 Offset: 0x31060D8 VA: 0x310A0D8
	protected internal int get_MTU() { }

	// RVA: 0x310A0F4 Offset: 0x31060F4 VA: 0x310A0F4
	public void .ctor(PeerBase peerBase) { }

	// RVA: 0x310A170 Offset: 0x3106170 VA: 0x310A170 Slot: 4
	public virtual bool Connect() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Disconnect();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract PhotonSocketError Send(byte[] data, int length);

	// RVA: 0x310A934 Offset: 0x3106934 VA: 0x310A934
	public void HandleReceivedDatagram(byte[] inBuffer, int length, bool willBeReused) { }

	// RVA: 0x310AB74 Offset: 0x3106B74 VA: 0x310AB74
	public bool ReportDebugOfLevel(DebugLevel levelOfMessage) { }

	// RVA: 0x310ABA4 Offset: 0x3106BA4 VA: 0x310ABA4
	public void EnqueueDebugReturn(DebugLevel debugLevel, string message) { }

	// RVA: 0x310ABC0 Offset: 0x3106BC0 VA: 0x310ABC0
	protected internal void HandleException(StatusCode statusCode) { }

	// RVA: 0x310A6CC Offset: 0x31066CC VA: 0x310A6CC
	protected internal bool TryParseAddress(string url, out string address, out ushort port, out string urlProtocol, out string urlPath) { }

	// RVA: 0x310AC70 Offset: 0x3106C70 VA: 0x310AC70
	protected internal bool IsIpv6SimpleCheck(IPAddress address) { }

	// RVA: 0x310ACE4 Offset: 0x3106CE4 VA: 0x310ACE4
	protected internal static IPAddress GetIpAddress(string address) { }

	[CompilerGenerated]
	// RVA: 0x310ADE4 Offset: 0x3106DE4 VA: 0x310ADE4
	private void <HandleException>b__44_0() { }
}
