// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public enum StatusCode // TypeDefIndex: 16961
{
	// Fields
	public int value__; // 0x0
	public const StatusCode Connect = 1024;
	public const StatusCode Disconnect = 1025;
	public const StatusCode Exception = 1026;
	public const StatusCode ExceptionOnConnect = 1023;
	public const StatusCode SecurityExceptionOnConnect = 1022;
	public const StatusCode QueueOutgoingReliableWarning = 1027;
	public const StatusCode QueueOutgoingUnreliableWarning = 1029;
	public const StatusCode SendError = 1030;
	public const StatusCode QueueOutgoingAcksWarning = 1031;
	public const StatusCode QueueIncomingReliableWarning = 1033;
	public const StatusCode QueueIncomingUnreliableWarning = 1035;
	public const StatusCode QueueSentWarning = 1037;
	public const StatusCode ExceptionOnReceive = 1039;
	[Obsolete("Replaced by ExceptionOnReceive")]
	public const StatusCode InternalReceiveException = 1039;
	public const StatusCode TimeoutDisconnect = 1040;
	public const StatusCode DisconnectByServer = 1041;
	public const StatusCode DisconnectByServerUserLimit = 1042;
	public const StatusCode DisconnectByServerLogic = 1043;
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const StatusCode TcpRouterResponseOk = 1044;
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const StatusCode TcpRouterResponseNodeIdUnknown = 1045;
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const StatusCode TcpRouterResponseEndpointUnknown = 1046;
	[Obsolete("TCP routing was removed after becoming obsolete.")]
	public const StatusCode TcpRouterResponseNodeNotReady = 1047;
	public const StatusCode EncryptionEstablished = 1048;
	public const StatusCode EncryptionFailedToEstablish = 1049;
}
