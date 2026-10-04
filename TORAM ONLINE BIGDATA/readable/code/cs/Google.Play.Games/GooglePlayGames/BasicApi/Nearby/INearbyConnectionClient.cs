// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public interface INearbyConnectionClient // TypeDefIndex: 16851
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int MaxUnreliableMessagePayloadLength();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int MaxReliableMessagePayloadLength();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendReliable(List<string> recipientEndpointIds, byte[] payload);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SendUnreliable(List<string> recipientEndpointIds, byte[] payload);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void StartAdvertising(string name, List<string> appIdentifiers, Nullable<TimeSpan> advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void StopAdvertising();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void StartDiscovery(string serviceId, Nullable<TimeSpan> advertisingTimeout, IDiscoveryListener listener);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void StopDiscovery(string serviceId);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RejectConnectionRequest(string requestingEndpointId);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DisconnectFromEndpoint(string remoteEndpointId);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void StopAllConnections();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string GetAppBundleId();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract string GetServiceId();
}
