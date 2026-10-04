// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class TPeer : PeerBase // TypeDefIndex: 16986
{
	// Fields
	private Queue<byte[]> incomingList; // 0x128
	internal List<byte[]> outgoingStream; // 0x130
	private int lastPingResult; // 0x138
	private byte[] pingRequest; // 0x140
	internal static readonly byte[] tcpFramedMessageHead; // 0x0
	internal static readonly byte[] tcpMsgHead; // 0x8
	internal byte[] messageHeader; // 0x148
	protected internal bool DoFraming; // 0x150

	// Methods

	// RVA: 0x3100FEC Offset: 0x30FCFEC VA: 0x3100FEC
	internal void .ctor() { }

	// RVA: 0x3101108 Offset: 0x30FD108 VA: 0x3101108 Slot: 14
	internal override void InitPeerBase() { }

	// RVA: 0x3101194 Offset: 0x30FD194 VA: 0x3101194 Slot: 4
	internal override bool Connect(string serverAddress, string appID, object customData) { }

	// RVA: 0x3101794 Offset: 0x30FD794 VA: 0x3101794 Slot: 5
	public override void OnConnect() { }

	// RVA: 0x31019D0 Offset: 0x30FD9D0 VA: 0x31019D0 Slot: 6
	internal override void Disconnect() { }

	// RVA: 0x3101AE0 Offset: 0x30FDAE0 VA: 0x3101AE0 Slot: 7
	internal override void StopConnection() { }

	// RVA: 0x3101C64 Offset: 0x30FDC64 VA: 0x3101C64 Slot: 8
	internal override void FetchServerTimestamp() { }

	// RVA: 0x31017CC Offset: 0x30FD7CC VA: 0x31017CC
	private void EnqueueInit(byte[] data) { }

	// RVA: 0x310231C Offset: 0x30FE31C VA: 0x310231C Slot: 10
	internal override bool DispatchIncomingCommands() { }

	// RVA: 0x3102558 Offset: 0x30FE558 VA: 0x3102558 Slot: 11
	internal override bool SendOutgoingCommands() { }

	// RVA: 0x3102B4C Offset: 0x30FEB4C VA: 0x3102B4C Slot: 9
	internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypt, PeerBase.EgMessageType messageType) { }

	// RVA: 0x3103184 Offset: 0x30FF184 VA: 0x3103184 Slot: 12
	internal override byte[] SerializeOperationToMessage(byte opc, Dictionary<byte, object> parameters, PeerBase.EgMessageType messageType, bool encrypt) { }

	// RVA: 0x3102068 Offset: 0x30FE068 VA: 0x3102068
	internal bool EnqueueMessageAsPayload(bool sendReliable, byte[] opMessage, byte channelId) { }

	// RVA: 0x3101E24 Offset: 0x30FDE24 VA: 0x3101E24
	internal void SendPing() { }

	// RVA: 0x3102844 Offset: 0x30FE844 VA: 0x3102844
	internal void SendData(byte[] data) { }

	// RVA: 0x3103598 Offset: 0x30FF598 VA: 0x3103598 Slot: 13
	internal override void ReceiveIncomingCommands(byte[] inbuff, int dataLength) { }

	// RVA: 0x31038A4 Offset: 0x30FF8A4 VA: 0x31038A4
	private void ReadPingResult(byte[] inbuff) { }

	// RVA: 0x31039C0 Offset: 0x30FF9C0 VA: 0x31039C0
	protected internal void ReadPingResult(OperationResponse operationResponse) { }

	// RVA: 0x3103B28 Offset: 0x30FFB28 VA: 0x3103B28
	private static void .cctor() { }
}
