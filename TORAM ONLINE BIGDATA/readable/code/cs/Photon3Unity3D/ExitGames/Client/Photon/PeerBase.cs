// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public abstract class PeerBase // TypeDefIndex: 16974
{
	// Fields
	internal PhotonPeer ppeer; // 0x10
	internal IProtocol protocol; // 0x18
	internal ConnectionProtocol usedProtocol; // 0x20
	internal IPhotonSocket rt; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <ServerAddress>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <HttpUrlParameters>k__BackingField; // 0x38
	internal int ByteCountLastOperation; // 0x40
	internal int ByteCountCurrentDispatch; // 0x44
	internal NCommand CommandInCurrentDispatch; // 0x48
	internal int TrafficPackageHeaderSize; // 0x50
	internal int packetLossByCrc; // 0x54
	internal int packetLossByChallenge; // 0x58
	internal readonly Queue<PeerBase.MyAction> ActionQueue; // 0x60
	internal short peerID; // 0x68
	internal PeerBase.ConnectionStateValue peerConnectionState; // 0x6A
	internal int serverTimeOffset; // 0x6C
	internal bool serverTimeOffsetIsAvailable; // 0x70
	internal int roundTripTime; // 0x74
	internal int roundTripTimeVariance; // 0x78
	internal int lastRoundTripTime; // 0x7C
	internal int lowestRoundTripTime; // 0x80
	internal int lastRoundTripTimeVariance; // 0x84
	internal int highestRoundTripTimeVariance; // 0x88
	internal int timestampOfLastReceive; // 0x8C
	internal int packetThrottleInterval; // 0x90
	internal static short peerCount; // 0x0
	internal long bytesOut; // 0x98
	internal long bytesIn; // 0xA0
	internal int commandBufferSize; // 0xA8
	internal int warningSize; // 0xAC
	internal ICryptoProvider CryptoProvider; // 0xB0
	private readonly Random lagRandomizer; // 0xB8
	internal readonly LinkedList<SimulationItem> NetSimListOutgoing; // 0xC0
	internal readonly LinkedList<SimulationItem> NetSimListIncoming; // 0xC8
	private readonly NetworkSimulationSet networkSimulationSettings; // 0xD0
	internal Queue<CmdLogItem> CommandLog; // 0xD8
	internal Queue<CmdLogItem> InReliableLog; // 0xE0
	internal object CustomInitData; // 0xE8
	internal string AppId; // 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private byte[] <TcpConnectionPrefix>k__BackingField; // 0xF8
	internal int timeBase; // 0x100
	internal int timeInt; // 0x104
	internal int timeoutInt; // 0x108
	internal int timeLastAckReceive; // 0x10C
	internal int timeLastSendAck; // 0x110
	internal int timeLastSendOutgoing; // 0x114
	internal const int ENET_PEER_PACKET_LOSS_SCALE = 65536;
	internal const int ENET_PEER_DEFAULT_ROUND_TRIP_TIME = 300;
	internal const int ENET_PEER_PACKET_THROTTLE_INTERVAL = 5000;
	internal bool ApplicationIsInitialized; // 0x118
	internal bool isEncryptionAvailable; // 0x119
	internal int outgoingCommandsInStream; // 0x11C
	protected StreamBuffer SerializeMemStream; // 0x120

	// Properties
	internal string ClientVersion { get; }
	internal Type SocketImplementation { get; }
	public string ServerAddress { get; set; }
	internal bool TrafficStatsEnabled { get; }
	internal TrafficStats TrafficStatsIncoming { get; }
	internal TrafficStats TrafficStatsOutgoing { get; }
	internal TrafficStatsGameLevel TrafficStatsGameLevel { get; }
	internal bool crcEnabled { get; }
	internal IPhotonPeerListener Listener { get; }
	internal DebugLevel debugOut { get; }
	internal int sentCountAllowance { get; }
	internal int DisconnectTimeout { get; }
	internal int timePingInterval { get; }
	internal byte ChannelCount { get; }
	internal int limitOfUnreliableCommands { get; }
	public byte QuickResendAttempts { get; }
	public NetworkSimulationSet NetworkSimulationSettings { get; }
	internal int CommandLogSize { get; }
	protected internal bool IsIpv6 { get; }
	internal bool IsSendingOnlyAcks { get; }
	internal int mtu { get; }

	// Methods

	// RVA: 0x30F49A4 Offset: 0x30F09A4 VA: 0x30F49A4
	internal string get_ClientVersion() { }

	// RVA: 0x30F3C18 Offset: 0x30EFC18 VA: 0x30F3C18
	internal Type get_SocketImplementation() { }

	[CompilerGenerated]
	// RVA: 0x30F49BC Offset: 0x30F09BC VA: 0x30F49BC
	public string get_ServerAddress() { }

	[CompilerGenerated]
	// RVA: 0x30F49C4 Offset: 0x30F09C4 VA: 0x30F49C4
	internal void set_ServerAddress(string value) { }

	// RVA: 0x30F49CC Offset: 0x30F09CC VA: 0x30F49CC
	internal bool get_TrafficStatsEnabled() { }

	// RVA: 0x30F49E8 Offset: 0x30F09E8 VA: 0x30F49E8
	internal TrafficStats get_TrafficStatsIncoming() { }

	// RVA: 0x30F4A04 Offset: 0x30F0A04 VA: 0x30F4A04
	internal TrafficStats get_TrafficStatsOutgoing() { }

	// RVA: 0x30F4A20 Offset: 0x30F0A20 VA: 0x30F4A20
	internal TrafficStatsGameLevel get_TrafficStatsGameLevel() { }

	// RVA: 0x30F4A3C Offset: 0x30F0A3C VA: 0x30F4A3C
	internal bool get_crcEnabled() { }

	// RVA: 0x30F4A58 Offset: 0x30F0A58 VA: 0x30F4A58
	internal IPhotonPeerListener get_Listener() { }

	// RVA: 0x30F4A74 Offset: 0x30F0A74 VA: 0x30F4A74
	internal DebugLevel get_debugOut() { }

	// RVA: 0x30F4A90 Offset: 0x30F0A90 VA: 0x30F4A90
	internal int get_sentCountAllowance() { }

	// RVA: 0x30F4AAC Offset: 0x30F0AAC VA: 0x30F4AAC
	internal int get_DisconnectTimeout() { }

	// RVA: 0x30F4AC8 Offset: 0x30F0AC8 VA: 0x30F4AC8
	internal int get_timePingInterval() { }

	// RVA: 0x30F4AE4 Offset: 0x30F0AE4 VA: 0x30F4AE4
	internal byte get_ChannelCount() { }

	// RVA: 0x30F4B00 Offset: 0x30F0B00 VA: 0x30F4B00
	internal int get_limitOfUnreliableCommands() { }

	// RVA: 0x30F4B1C Offset: 0x30F0B1C VA: 0x30F4B1C
	public byte get_QuickResendAttempts() { }

	// RVA: 0x30F4B38 Offset: 0x30F0B38 VA: 0x30F4B38
	public NetworkSimulationSet get_NetworkSimulationSettings() { }

	// RVA: 0x30F4B40 Offset: 0x30F0B40 VA: 0x30F4B40
	internal int get_CommandLogSize() { }

	// RVA: 0x30F4B5C Offset: 0x30F0B5C VA: 0x30F4B5C
	internal void CommandLogResize() { }

	// RVA: 0x30F4C6C Offset: 0x30F0C6C VA: 0x30F4C6C
	internal void CommandLogInit() { }

	// RVA: 0x30F4DB0 Offset: 0x30F0DB0 VA: 0x30F4DB0
	internal void InitOnce() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool Connect(string serverAddress, string appID, object customData);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnConnect();

	// RVA: 0x30F4DD0 Offset: 0x30F0DD0 VA: 0x30F4DD0
	private string GetHttpKeyValueString(Dictionary<string, string> dic) { }

	// RVA: 0x30F5004 Offset: 0x30F1004 VA: 0x30F5004
	protected internal bool get_IsIpv6() { }

	// RVA: 0x30F5024 Offset: 0x30F1024 VA: 0x30F5024
	internal byte[] PrepareConnectData(string serverAddress, string appID, object custom) { }

	// RVA: 0x30F5568 Offset: 0x30F1568 VA: 0x30F5568
	internal string PepareWebSocketUrl(string serverAddress, string appId, object customData) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract void Disconnect();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void StopConnection();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void FetchServerTimestamp();

	// RVA: 0x30F48BC Offset: 0x30F08BC VA: 0x30F48BC
	internal bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypted) { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypted, PeerBase.EgMessageType messageType);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool DispatchIncomingCommands();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool SendOutgoingCommands();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract byte[] SerializeOperationToMessage(byte opCode, Dictionary<byte, object> parameters, PeerBase.EgMessageType messageType, bool encrypt);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void ReceiveIncomingCommands(byte[] inBuff, int dataLength);

	// RVA: 0x30F5840 Offset: 0x30F1840 VA: 0x30F5840
	internal void InitCallback() { }

	// RVA: 0x30F591C Offset: 0x30F191C VA: 0x30F591C
	internal bool get_IsSendingOnlyAcks() { }

	// RVA: 0x30F5938 Offset: 0x30F1938 VA: 0x30F5938
	internal int get_mtu() { }

	// RVA: 0x30F4218 Offset: 0x30F0218 VA: 0x30F4218
	internal bool ExchangeKeysForEncryption(object lockObject) { }

	// RVA: 0x30F5954 Offset: 0x30F1954 VA: 0x30F5954
	internal void DeriveSharedKey(OperationResponse operationResponse) { }

	// RVA: 0x30F5C98 Offset: 0x30F1C98 VA: 0x30F5C98
	internal void EnqueueActionForDispatch(PeerBase.MyAction action) { }

	// RVA: 0x30F3C34 Offset: 0x30EFC34 VA: 0x30F3C34
	internal void EnqueueDebugReturn(DebugLevel level, string debugReturn) { }

	// RVA: 0x30F5B1C Offset: 0x30F1B1C VA: 0x30F5B1C
	internal void EnqueueStatusCallback(StatusCode statusValue) { }

	// RVA: 0x30F5E28 Offset: 0x30F1E28 VA: 0x30F5E28 Slot: 14
	internal virtual void InitPeerBase() { }

	// RVA: 0x30F6004 Offset: 0x30F2004 VA: 0x30F6004 Slot: 15
	internal virtual bool DeserializeMessageAndCallback(byte[] inBuff) { }

	// RVA: 0x30F6928 Offset: 0x30F2928 VA: 0x30F6928
	internal void SendNetworkSimulated(PeerBase.MyAction sendAction) { }

	// RVA: 0x30F6CCC Offset: 0x30F2CCC VA: 0x30F6CCC
	internal void ReceiveNetworkSimulated(PeerBase.MyAction receiveAction) { }

	// RVA: 0x30F7070 Offset: 0x30F3070 VA: 0x30F7070
	protected internal void NetworkSimRun() { }

	// RVA: 0x30F73C0 Offset: 0x30F33C0 VA: 0x30F73C0
	internal void UpdateRoundTripTimeAndVariance(int lastRoundtripTime) { }

	// RVA: 0x30F7434 Offset: 0x30F3434 VA: 0x30F7434 Slot: 16
	internal virtual void InitEncryption(byte[] secret) { }

	// RVA: 0x30F74AC Offset: 0x30F34AC VA: 0x30F74AC
	protected void .ctor() { }
}
