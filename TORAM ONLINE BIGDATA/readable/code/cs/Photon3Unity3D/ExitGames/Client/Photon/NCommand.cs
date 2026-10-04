// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class NCommand : IComparable<NCommand> // TypeDefIndex: 16984
{
	// Fields
	internal byte commandFlags; // 0x10
	internal const int FLAG_RELIABLE = 1;
	internal const int FLAG_UNSEQUENCED = 2;
	internal const byte FV_UNRELIABLE = 0;
	internal const byte FV_RELIABLE = 1;
	internal const byte FV_UNRELIBALE_UNSEQUENCED = 2;
	internal byte commandType; // 0x11
	internal const byte CT_NONE = 0;
	internal const byte CT_ACK = 1;
	internal const byte CT_CONNECT = 2;
	internal const byte CT_VERIFYCONNECT = 3;
	internal const byte CT_DISCONNECT = 4;
	internal const byte CT_PING = 5;
	internal const byte CT_SENDRELIABLE = 6;
	internal const byte CT_SENDUNRELIABLE = 7;
	internal const byte CT_SENDFRAGMENT = 8;
	internal const byte CT_EG_SERVERTIME = 12;
	internal byte commandChannelID; // 0x12
	internal int reliableSequenceNumber; // 0x14
	internal int unreliableSequenceNumber; // 0x18
	internal int unsequencedGroupNumber; // 0x1C
	internal byte reservedByte; // 0x20
	internal int startSequenceNumber; // 0x24
	internal int fragmentCount; // 0x28
	internal int fragmentNumber; // 0x2C
	internal int totalLength; // 0x30
	internal int fragmentOffset; // 0x34
	internal int fragmentsRemaining; // 0x38
	internal int commandSentTime; // 0x3C
	internal byte commandSentCount; // 0x40
	internal int roundTripTimeout; // 0x44
	internal int timeoutTime; // 0x48
	internal int ackReceivedReliableSequenceNumber; // 0x4C
	internal int ackReceivedSentTime; // 0x50
	internal const int HEADER_UDP_PACK_LENGTH = 12;
	internal const int CmdSizeMinimum = 12;
	internal const int CmdSizeAck = 20;
	internal const int CmdSizeConnect = 44;
	internal const int CmdSizeVerifyConnect = 44;
	internal const int CmdSizeDisconnect = 12;
	internal const int CmdSizePing = 12;
	internal const int CmdSizeReliableHeader = 12;
	internal const int CmdSizeUnreliableHeader = 16;
	internal const int CmdSizeFragmentHeader = 32;
	internal const int CmdSizeMaxHeader = 36;
	internal int Size; // 0x54
	private byte[] commandHeader; // 0x58
	internal int SizeOfHeader; // 0x60
	internal byte[] Payload; // 0x68

	// Properties
	protected internal int SizeOfPayload { get; }

	// Methods

	// RVA: 0x3100010 Offset: 0x30FC010 VA: 0x3100010
	protected internal int get_SizeOfPayload() { }

	// RVA: 0x3100028 Offset: 0x30FC028 VA: 0x3100028
	internal void .ctor(EnetPeer peer, byte commandType, byte[] payload, byte channel) { }

	// RVA: 0x310039C Offset: 0x30FC39C VA: 0x310039C
	internal static NCommand CreateAck(EnetPeer peer, NCommand commandToAck, int sentTime) { }

	// RVA: 0x3100544 Offset: 0x30FC544 VA: 0x3100544
	internal void .ctor(EnetPeer peer, byte[] inBuff, ref int readingOffset) { }

	// RVA: 0x3100950 Offset: 0x30FC950 VA: 0x3100950
	internal byte[] SerializeHeader() { }

	// RVA: 0x3100B70 Offset: 0x30FCB70 VA: 0x3100B70
	internal byte[] Serialize() { }

	// RVA: 0x3100B78 Offset: 0x30FCB78 VA: 0x3100B78 Slot: 4
	public int CompareTo(NCommand other) { }

	// RVA: 0x3100BB0 Offset: 0x30FCBB0 VA: 0x3100BB0 Slot: 3
	public override string ToString() { }
}
