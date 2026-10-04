// Assembly: Photon3Unity3D.dll
// Namespace: 
public enum PeerBase.ConnectionStateValue // TypeDefIndex: 16970
{
	// Fields
	public byte value__; // 0x0
	public const PeerBase.ConnectionStateValue Disconnected = 0;
	public const PeerBase.ConnectionStateValue Connecting = 1;
	public const PeerBase.ConnectionStateValue Connected = 3;
	public const PeerBase.ConnectionStateValue Disconnecting = 4;
	public const PeerBase.ConnectionStateValue AcknowledgingDisconnect = 5;
	public const PeerBase.ConnectionStateValue Zombie = 6;
}
