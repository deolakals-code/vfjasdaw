// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public struct ConnectionRequest // TypeDefIndex: 16846
{
	// Fields
	private readonly EndpointDetails mRemoteEndpoint; // 0x0
	private readonly byte[] mPayload; // 0x18

	// Properties
	public EndpointDetails RemoteEndpoint { get; }
	public byte[] Payload { get; }

	// Methods

	// RVA: 0x2E33D10 Offset: 0x2E2FD10 VA: 0x2E33D10
	public void .ctor(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload) { }

	// RVA: 0x2E33EBC Offset: 0x2E2FEBC VA: 0x2E33EBC
	public EndpointDetails get_RemoteEndpoint() { }

	// RVA: 0x2E33ED0 Offset: 0x2E2FED0 VA: 0x2E33ED0
	public byte[] get_Payload() { }
}
