// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class SocketUdp : IPhotonSocket, IDisposable // TypeDefIndex: 17003
{
	// Fields
	private Socket sock; // 0x40
	private readonly object syncer; // 0x48

	// Methods

	// RVA: 0x310AE7C Offset: 0x3106E7C VA: 0x310AE7C
	public void .ctor(PeerBase npeer) { }

	// RVA: 0x310AFC0 Offset: 0x3106FC0 VA: 0x310AFC0 Slot: 7
	public void Dispose() { }

	// RVA: 0x310B0BC Offset: 0x31070BC VA: 0x310B0BC Slot: 4
	public override bool Connect() { }

	// RVA: 0x310B260 Offset: 0x3107260 VA: 0x310B260 Slot: 5
	public override bool Disconnect() { }

	// RVA: 0x310B454 Offset: 0x3107454 VA: 0x310B454 Slot: 6
	public override PhotonSocketError Send(byte[] data, int length) { }

	// RVA: 0x310B65C Offset: 0x310765C VA: 0x310B65C
	internal void DnsAndConnect() { }

	// RVA: 0x310BDE4 Offset: 0x3107DE4 VA: 0x310BDE4
	public void ReceiveLoop() { }
}
