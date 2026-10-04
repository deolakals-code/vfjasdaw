// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class EnetPeer : PeerBase // TypeDefIndex: 16982
{
	// Fields
	private static readonly int HMAC_SIZE; // 0x0
	private static readonly int BLOCK_SIZE; // 0x4
	private static readonly int IV_SIZE; // 0x8
	private Dictionary<byte, EnetChannel> channels; // 0x128
	private List<NCommand> sentReliableCommands; // 0x130
	private Queue<NCommand> outgoingAcknowledgementsList; // 0x138
	internal readonly int windowSize; // 0x140
	private byte udpCommandCount; // 0x144
	private byte[] udpBuffer; // 0x148
	private int udpBufferIndex; // 0x150
	private int udpBufferLength; // 0x154
	private byte[] bufferForEncryption; // 0x158
	internal int challenge; // 0x160
	internal int reliableCommandsRepeated; // 0x164
	internal int reliableCommandsSent; // 0x168
	internal int serverSentTime; // 0x16C
	internal static readonly byte[] udpHeader0xF3; // 0x10
	internal static readonly byte[] messageHeader; // 0x18
	protected bool datagramEncryptedConnection; // 0x170
	private EnetChannel[] channelArray; // 0x178
	private Queue<int> commandsToRemove; // 0x180

	// Properties
	private Encryptor encryptor { get; }
	private Decryptor decryptor { get; }

	// Methods

	// RVA: 0x30F82CC Offset: 0x30F42CC VA: 0x30F82CC
	private Encryptor get_encryptor() { }

	// RVA: 0x30F82E8 Offset: 0x30F42E8 VA: 0x30F82E8
	private Decryptor get_decryptor() { }

	// RVA: 0x30F3DC0 Offset: 0x30EFDC0 VA: 0x30F3DC0
	internal void .ctor() { }

	// RVA: 0x30F8304 Offset: 0x30F4304 VA: 0x30F8304 Slot: 14
	internal override void InitPeerBase() { }

	// RVA: 0x30F89DC Offset: 0x30F49DC VA: 0x30F89DC Slot: 4
	internal override bool Connect(string ipport, string appID, object custom) { }

	// RVA: 0x30F8CC8 Offset: 0x30F4CC8 VA: 0x30F8CC8 Slot: 5
	public override void OnConnect() { }

	// RVA: 0x30F8F34 Offset: 0x30F4F34 VA: 0x30F8F34 Slot: 6
	internal override void Disconnect() { }

	// RVA: 0x30F9420 Offset: 0x30F5420 VA: 0x30F9420 Slot: 7
	internal override void StopConnection() { }

	// RVA: 0x30F94F4 Offset: 0x30F54F4 VA: 0x30F94F4 Slot: 8
	internal override void FetchServerTimestamp() { }

	// RVA: 0x30F9890 Offset: 0x30F5890 VA: 0x30F9890 Slot: 10
	internal override bool DispatchIncomingCommands() { }

	// RVA: 0x30FA264 Offset: 0x30F6264 VA: 0x30FA264
	private int GetFragmentLength() { }

	// RVA: 0x30FA300 Offset: 0x30F6300 VA: 0x30FA300
	private int CalculateBufferLen() { }

	// RVA: 0x30FA3A8 Offset: 0x30F63A8 VA: 0x30FA3A8
	private int CalculateInitialOffset() { }

	// RVA: 0x30FA3E4 Offset: 0x30F63E4 VA: 0x30FA3E4 Slot: 11
	internal override bool SendOutgoingCommands() { }

	// RVA: 0x30FB8A0 Offset: 0x30F78A0 VA: 0x30FB8A0
	private bool AreReliableCommandsInTransit() { }

	// RVA: 0x30FBE24 Offset: 0x30F7E24 VA: 0x30FBE24 Slot: 9
	internal override bool EnqueueOperation(Dictionary<byte, object> parameters, byte opCode, bool sendReliable, byte channelId, bool encrypt, PeerBase.EgMessageType messageType) { }

	// RVA: 0x30F95E4 Offset: 0x30F55E4 VA: 0x30F95E4
	internal bool CreateAndEnqueueCommand(byte commandType, byte[] payload, byte channelNumber) { }

	// RVA: 0x30FC594 Offset: 0x30F8594 VA: 0x30FC594 Slot: 12
	internal override byte[] SerializeOperationToMessage(byte opc, Dictionary<byte, object> parameters, PeerBase.EgMessageType messageType, bool encrypt) { }

	// RVA: 0x30FB44C Offset: 0x30F744C VA: 0x30FB44C
	internal int SerializeToBuffer(Queue<NCommand> commandList) { }

	// RVA: 0x30FBAEC Offset: 0x30F7AEC VA: 0x30FBAEC
	internal void SendData(byte[] data, int length) { }

	// RVA: 0x30FCE40 Offset: 0x30F8E40 VA: 0x30FCE40
	private void SendToSocket(byte[] data, int length) { }

	// RVA: 0x30FCC28 Offset: 0x30F8C28 VA: 0x30FCC28
	private void SendDataEncrypted(byte[] data, int length) { }

	// RVA: 0x30FC998 Offset: 0x30F8998 VA: 0x30FC998
	internal void QueueSentCommand(NCommand command) { }

	// RVA: 0x30F8D34 Offset: 0x30F4D34 VA: 0x30F8D34
	internal void QueueOutgoingReliableCommand(NCommand command) { }

	// RVA: 0x30FC424 Offset: 0x30F8424 VA: 0x30FC424
	internal void QueueOutgoingUnreliableCommand(NCommand command) { }

	// RVA: 0x30FCFE8 Offset: 0x30F8FE8 VA: 0x30FCFE8
	internal void QueueOutgoingAcknowledgement(NCommand command) { }

	// RVA: 0x30FD1A4 Offset: 0x30F91A4 VA: 0x30FD1A4 Slot: 13
	internal override void ReceiveIncomingCommands(byte[] inBuff, int dataLength) { }

	// RVA: 0x30FDFB8 Offset: 0x30F9FB8 VA: 0x30FDFB8
	internal bool ExecuteCommand(NCommand command) { }

	// RVA: 0x30FEE00 Offset: 0x30FAE00 VA: 0x30FEE00
	internal bool QueueIncomingCommand(NCommand command) { }

	// RVA: 0x30FEA8C Offset: 0x30FAA8C VA: 0x30FEA8C
	internal NCommand RemoveSentReliableCommand(int ackReceivedReliableSequenceNumber, int ackReceivedChannel) { }

	// RVA: 0x30FFB2C Offset: 0x30FBB2C VA: 0x30FFB2C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x30FFBF4 Offset: 0x30FBBF4 VA: 0x30FFBF4
	private void <ExecuteCommand>b__58_0() { }
}
