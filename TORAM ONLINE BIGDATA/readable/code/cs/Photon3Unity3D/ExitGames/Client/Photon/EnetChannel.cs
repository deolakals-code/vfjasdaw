// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class EnetChannel // TypeDefIndex: 16983
{
	// Fields
	internal byte ChannelNumber; // 0x10
	internal Dictionary<int, NCommand> incomingReliableCommandsList; // 0x18
	internal Dictionary<int, NCommand> incomingUnreliableCommandsList; // 0x20
	internal Queue<NCommand> outgoingReliableCommandsList; // 0x28
	internal Queue<NCommand> outgoingUnreliableCommandsList; // 0x30
	internal int incomingReliableSequenceNumber; // 0x38
	internal int incomingUnreliableSequenceNumber; // 0x3C
	internal int outgoingReliableSequenceNumber; // 0x40
	internal int outgoingUnreliableSequenceNumber; // 0x44

	// Methods

	// RVA: 0x30FFC8C Offset: 0x30FBC8C VA: 0x30FFC8C
	public void .ctor(byte channelNumber, int commandBufferSize) { }

	// RVA: 0x30FFDD4 Offset: 0x30FBDD4 VA: 0x30FFDD4
	public bool ContainsUnreliableSequenceNumber(int unreliableSequenceNumber) { }

	// RVA: 0x30FFE2C Offset: 0x30FBE2C VA: 0x30FFE2C
	public bool ContainsReliableSequenceNumber(int reliableSequenceNumber) { }

	// RVA: 0x30FFE84 Offset: 0x30FBE84 VA: 0x30FFE84
	public NCommand FetchReliableSequenceNumber(int reliableSequenceNumber) { }

	// RVA: 0x30FFEDC Offset: 0x30FBEDC VA: 0x30FFEDC
	public void clearAll() { }
}
