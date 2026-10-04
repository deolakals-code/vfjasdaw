// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public class PhotonPeer // TypeDefIndex: 16967
{
	// Fields
	public const bool NoSocket = False;
	public const bool NativeDatagramEncrypt = False;
	public const bool DebugBuild = True;
	protected internal byte ClientSdkId; // 0x10
	public static bool AsyncKeyExchange; // 0x0
	private string clientVersion; // 0x18
	public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Type <SocketImplementation>k__BackingField; // 0x28
	public DebugLevel DebugOut; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IPhotonPeerListener <Listener>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TrafficStats <TrafficStatsIncoming>k__BackingField; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TrafficStats <TrafficStatsOutgoing>k__BackingField; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TrafficStatsGameLevel <TrafficStatsGameLevel>k__BackingField; // 0x50
	private Stopwatch trafficStatsStopwatch; // 0x58
	private bool trafficStatsEnabled; // 0x60
	private int commandLogSize; // 0x64
	private byte quickResendAttempts; // 0x68
	public int RhttpMinConnections; // 0x6C
	public int RhttpMaxConnections; // 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <LimitOfUnreliableCommands>k__BackingField; // 0x74
	public byte ChannelCount; // 0x78
	private bool crcEnabled; // 0x79
	public int SentCountAllowance; // 0x7C
	public int TimePingInterval; // 0x80
	public int DisconnectTimeout; // 0x84
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ConnectionProtocol <TransportProtocol>k__BackingField; // 0x88
	public static int OutgoingStreamBufferSize; // 0x4
	private int mtu; // 0x8C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <IsSendingOnlyAcks>k__BackingField; // 0x90
	internal PeerBase peerBase; // 0x98
	private readonly object SendOutgoingLockObject; // 0xA0
	private readonly object DispatchLockObject; // 0xA8
	private readonly object EnqueueLock; // 0xB0
	protected internal byte[] PayloadEncryptionSecret; // 0xB8
	internal Encryptor encryptor; // 0xC0
	internal Decryptor decryptor; // 0xC8

	// Properties
	protected internal byte ClientSdkIdShifted { get; }
	public string ClientVersion { get; }
	public Type SocketImplementation { get; set; }
	public IPhotonPeerListener Listener { get; set; }
	public TrafficStats TrafficStatsIncoming { get; set; }
	public TrafficStats TrafficStatsOutgoing { get; set; }
	public TrafficStatsGameLevel TrafficStatsGameLevel { get; set; }
	public bool TrafficStatsEnabled { get; }
	public int CommandLogSize { get; }
	public byte QuickResendAttempts { get; set; }
	public PeerStateValue PeerState { get; }
	public int LimitOfUnreliableCommands { get; }
	public bool CrcEnabled { get; }
	public int ServerTimeInMilliSeconds { get; }
	public ConnectionProtocol TransportProtocol { get; set; }
	public int MaximumTransferUnit { get; }
	public bool IsEncryptionAvailable { get; }
	public bool IsSendingOnlyAcks { get; }

	// Methods

	// RVA: 0x30F2EE4 Offset: 0x30EEEE4 VA: 0x30F2EE4
	protected internal byte get_ClientSdkIdShifted() { }

	// RVA: 0x30F2EF0 Offset: 0x30EEEF0 VA: 0x30F2EF0
	public string get_ClientVersion() { }

	[CompilerGenerated]
	// RVA: 0x30F3184 Offset: 0x30EF184 VA: 0x30F3184
	public Type get_SocketImplementation() { }

	[CompilerGenerated]
	// RVA: 0x30F318C Offset: 0x30EF18C VA: 0x30F318C
	internal void set_SocketImplementation(Type value) { }

	[CompilerGenerated]
	// RVA: 0x30F3194 Offset: 0x30EF194 VA: 0x30F3194
	public IPhotonPeerListener get_Listener() { }

	[CompilerGenerated]
	// RVA: 0x30F319C Offset: 0x30EF19C VA: 0x30F319C
	protected void set_Listener(IPhotonPeerListener value) { }

	[CompilerGenerated]
	// RVA: 0x30F31A4 Offset: 0x30EF1A4 VA: 0x30F31A4
	public TrafficStats get_TrafficStatsIncoming() { }

	[CompilerGenerated]
	// RVA: 0x30F31AC Offset: 0x30EF1AC VA: 0x30F31AC
	internal void set_TrafficStatsIncoming(TrafficStats value) { }

	[CompilerGenerated]
	// RVA: 0x30F31B4 Offset: 0x30EF1B4 VA: 0x30F31B4
	public TrafficStats get_TrafficStatsOutgoing() { }

	[CompilerGenerated]
	// RVA: 0x30F31BC Offset: 0x30EF1BC VA: 0x30F31BC
	internal void set_TrafficStatsOutgoing(TrafficStats value) { }

	[CompilerGenerated]
	// RVA: 0x30F31C4 Offset: 0x30EF1C4 VA: 0x30F31C4
	public TrafficStatsGameLevel get_TrafficStatsGameLevel() { }

	[CompilerGenerated]
	// RVA: 0x30F31CC Offset: 0x30EF1CC VA: 0x30F31CC
	internal void set_TrafficStatsGameLevel(TrafficStatsGameLevel value) { }

	// RVA: 0x30F31D4 Offset: 0x30EF1D4 VA: 0x30F31D4
	public bool get_TrafficStatsEnabled() { }

	// RVA: 0x30F31DC Offset: 0x30EF1DC VA: 0x30F31DC
	internal void InitializeTrafficStats() { }

	// RVA: 0x30F3300 Offset: 0x30EF300 VA: 0x30F3300
	public int get_CommandLogSize() { }

	// RVA: 0x30F3308 Offset: 0x30EF308 VA: 0x30F3308
	public byte get_QuickResendAttempts() { }

	// RVA: 0x30F3310 Offset: 0x30EF310 VA: 0x30F3310
	public void set_QuickResendAttempts(byte value) { }

	// RVA: 0x30F3328 Offset: 0x30EF328 VA: 0x30F3328
	public PeerStateValue get_PeerState() { }

	[CompilerGenerated]
	// RVA: 0x30F3358 Offset: 0x30EF358 VA: 0x30F3358
	public int get_LimitOfUnreliableCommands() { }

	// RVA: 0x30F3360 Offset: 0x30EF360 VA: 0x30F3360
	public bool get_CrcEnabled() { }

	// RVA: 0x30F3368 Offset: 0x30EF368 VA: 0x30F3368
	public int get_ServerTimeInMilliSeconds() { }

	[CompilerGenerated]
	// RVA: 0x30F33E0 Offset: 0x30EF3E0 VA: 0x30F33E0
	public ConnectionProtocol get_TransportProtocol() { }

	[CompilerGenerated]
	// RVA: 0x30F33E8 Offset: 0x30EF3E8 VA: 0x30F33E8
	public void set_TransportProtocol(ConnectionProtocol value) { }

	// RVA: 0x30F33F0 Offset: 0x30EF3F0 VA: 0x30F33F0
	public int get_MaximumTransferUnit() { }

	// RVA: 0x30F33F8 Offset: 0x30EF3F8 VA: 0x30F33F8
	public bool get_IsEncryptionAvailable() { }

	[CompilerGenerated]
	// RVA: 0x30F3414 Offset: 0x30EF414 VA: 0x30F3414
	public bool get_IsSendingOnlyAcks() { }

	// RVA: 0x30F341C Offset: 0x30EF41C VA: 0x30F341C
	public void .ctor(ConnectionProtocol protocolType) { }

	// RVA: 0x30F37C4 Offset: 0x30EF7C4 VA: 0x30F37C4
	public void .ctor(IPhotonPeerListener listener, ConnectionProtocol protocolType) { }

	// RVA: 0x30F37F4 Offset: 0x30EF7F4 VA: 0x30F37F4 Slot: 4
	public virtual bool Connect(string serverAddress, string applicationName) { }

	// RVA: 0x30F3804 Offset: 0x30EF804 VA: 0x30F3804 Slot: 5
	public virtual bool Connect(string serverAddress, string applicationName, object custom) { }

	// RVA: 0x30F352C Offset: 0x30EF52C VA: 0x30F352C
	private void CreatePeerBase() { }

	// RVA: 0x30F3FB4 Offset: 0x30EFFB4 VA: 0x30F3FB4 Slot: 6
	public virtual void Disconnect() { }

	// RVA: 0x30F4108 Offset: 0x30F0108 VA: 0x30F4108 Slot: 7
	public virtual void FetchServerTimestamp() { }

	// RVA: 0x30F4128 Offset: 0x30F0128 VA: 0x30F4128
	public bool EstablishEncryption() { }

	// RVA: 0x30F4550 Offset: 0x30F0550 VA: 0x30F4550 Slot: 8
	public virtual void Service() { }

	// RVA: 0x30F4588 Offset: 0x30F0588 VA: 0x30F4588 Slot: 9
	public virtual bool SendOutgoingCommands() { }

	// RVA: 0x30F4668 Offset: 0x30F0668 VA: 0x30F4668 Slot: 10
	public virtual bool DispatchIncomingCommands() { }

	// RVA: 0x30F474C Offset: 0x30F074C VA: 0x30F474C Slot: 11
	public virtual bool OpCustom(byte customOpCode, Dictionary<byte, object> customOpParameters, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x30F48D4 Offset: 0x30F08D4 VA: 0x30F48D4
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x30F4924 Offset: 0x30F0924 VA: 0x30F4924
	private bool <EstablishEncryption>b__148_0() { }
}
