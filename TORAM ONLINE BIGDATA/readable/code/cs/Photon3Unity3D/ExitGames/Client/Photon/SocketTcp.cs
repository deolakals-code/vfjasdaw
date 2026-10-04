// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
internal class SocketTcp : IPhotonSocket, IDisposable // TypeDefIndex: 17004
{
	// Fields
	private Socket sock; // 0x40
	private readonly object syncer; // 0x48

	// Methods

	// RVA: 0x310164C Offset: 0x30FD64C VA: 0x310164C
	public void .ctor(PeerBase npeer) { }

	// RVA: 0x310C178 Offset: 0x3108178 VA: 0x310C178 Slot: 7
	public void Dispose() { }

	// RVA: 0x310C274 Offset: 0x3108274 VA: 0x310C274 Slot: 4
	public override bool Connect() { }

	// RVA: 0x310C374 Offset: 0x3108374 VA: 0x310C374 Slot: 5
	public override bool Disconnect() { }

	// RVA: 0x310C568 Offset: 0x3108568 VA: 0x310C568 Slot: 6
	public override PhotonSocketError Send(byte[] data, int length) { }

	// RVA: 0x310C6B8 Offset: 0x31086B8 VA: 0x310C6B8
	public void DnsAndConnect() { }

	// RVA: 0x310CBD8 Offset: 0x3108BD8 VA: 0x310CBD8
	public void ReceiveLoop() { }
}
