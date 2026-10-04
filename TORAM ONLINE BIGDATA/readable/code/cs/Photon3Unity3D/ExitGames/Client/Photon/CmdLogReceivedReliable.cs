// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class CmdLogReceivedReliable : CmdLogItem // TypeDefIndex: 16976
{
	// Fields
	public int TimeSinceLastSend; // 0x24
	public int TimeSinceLastSendAck; // 0x28

	// Methods

	// RVA: 0x30F7AC4 Offset: 0x30F3AC4 VA: 0x30F7AC4
	public void .ctor(NCommand command, int timeInt, int rtt, int variance, int timeSinceLastSend, int timeSinceLastSendAck) { }

	// RVA: 0x30F7AEC Offset: 0x30F3AEC VA: 0x30F7AEC Slot: 3
	public override string ToString() { }
}
