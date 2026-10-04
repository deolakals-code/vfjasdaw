// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public struct ConnectionResponse // TypeDefIndex: 16848
{
	// Fields
	private static readonly byte[] EmptyPayload; // 0x0
	private readonly long mLocalClientId; // 0x0
	private readonly string mRemoteEndpointId; // 0x8
	private readonly ConnectionResponse.Status mResponseStatus; // 0x10
	private readonly byte[] mPayload; // 0x18

	// Properties
	public long LocalClientId { get; }
	public string RemoteEndpointId { get; }
	public ConnectionResponse.Status ResponseStatus { get; }
	public byte[] Payload { get; }

	// Methods

	// RVA: 0x2E33ED8 Offset: 0x2E2FED8 VA: 0x2E33ED8
	private void .ctor(long localClientId, string remoteEndpointId, ConnectionResponse.Status code, byte[] payload) { }

	// RVA: 0x2E33F90 Offset: 0x2E2FF90 VA: 0x2E33F90
	public long get_LocalClientId() { }

	// RVA: 0x2E33F98 Offset: 0x2E2FF98 VA: 0x2E33F98
	public string get_RemoteEndpointId() { }

	// RVA: 0x2E33FA0 Offset: 0x2E2FFA0 VA: 0x2E33FA0
	public ConnectionResponse.Status get_ResponseStatus() { }

	// RVA: 0x2E33FA8 Offset: 0x2E2FFA8 VA: 0x2E33FA8
	public byte[] get_Payload() { }

	// RVA: 0x2E33FB0 Offset: 0x2E2FFB0 VA: 0x2E33FB0
	public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x2E34034 Offset: 0x2E30034 VA: 0x2E34034
	public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x2E340B8 Offset: 0x2E300B8 VA: 0x2E340B8
	public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId) { }

	// RVA: 0x2E3413C Offset: 0x2E3013C VA: 0x2E3413C
	public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x2E341C0 Offset: 0x2E301C0 VA: 0x2E341C0
	public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload) { }

	// RVA: 0x2E341E0 Offset: 0x2E301E0 VA: 0x2E341E0
	public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId) { }

	// RVA: 0x2E34264 Offset: 0x2E30264 VA: 0x2E34264
	private static void .cctor() { }
}
