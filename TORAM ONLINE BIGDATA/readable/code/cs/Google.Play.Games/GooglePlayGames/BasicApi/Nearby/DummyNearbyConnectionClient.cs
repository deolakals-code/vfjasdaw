// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public class DummyNearbyConnectionClient : INearbyConnectionClient // TypeDefIndex: 16849
{
	// Methods

	// RVA: 0x2E342D8 Offset: 0x2E302D8 VA: 0x2E342D8 Slot: 4
	public int MaxUnreliableMessagePayloadLength() { }

	// RVA: 0x2E342E0 Offset: 0x2E302E0 VA: 0x2E342E0 Slot: 5
	public int MaxReliableMessagePayloadLength() { }

	// RVA: 0x2E342E8 Offset: 0x2E302E8 VA: 0x2E342E8 Slot: 6
	public void SendReliable(List<string> recipientEndpointIds, byte[] payload) { }

	// RVA: 0x2E34350 Offset: 0x2E30350 VA: 0x2E34350 Slot: 7
	public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload) { }

	// RVA: 0x2E343B8 Offset: 0x2E303B8 VA: 0x2E343B8 Slot: 8
	public void StartAdvertising(string name, List<string> appIdentifiers, Nullable<TimeSpan> advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback) { }

	// RVA: 0x2E34438 Offset: 0x2E30438 VA: 0x2E34438 Slot: 9
	public void StopAdvertising() { }

	// RVA: 0x2E344A0 Offset: 0x2E304A0 VA: 0x2E344A0 Slot: 10
	public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener) { }

	// RVA: 0x2E34590 Offset: 0x2E30590 VA: 0x2E34590 Slot: 11
	public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener) { }

	// RVA: 0x2E345F8 Offset: 0x2E305F8 VA: 0x2E345F8 Slot: 12
	public void StartDiscovery(string serviceId, Nullable<TimeSpan> advertisingTimeout, IDiscoveryListener listener) { }

	// RVA: 0x2E34660 Offset: 0x2E30660 VA: 0x2E34660 Slot: 13
	public void StopDiscovery(string serviceId) { }

	// RVA: 0x2E346C8 Offset: 0x2E306C8 VA: 0x2E346C8 Slot: 14
	public void RejectConnectionRequest(string requestingEndpointId) { }

	// RVA: 0x2E34730 Offset: 0x2E30730 VA: 0x2E34730 Slot: 15
	public void DisconnectFromEndpoint(string remoteEndpointId) { }

	// RVA: 0x2E34798 Offset: 0x2E30798 VA: 0x2E34798 Slot: 16
	public void StopAllConnections() { }

	// RVA: 0x2E34800 Offset: 0x2E30800 VA: 0x2E34800
	public string LocalEndpointId() { }

	// RVA: 0x2E34848 Offset: 0x2E30848 VA: 0x2E34848
	public string LocalDeviceId() { }

	// RVA: 0x2E34888 Offset: 0x2E30888 VA: 0x2E34888 Slot: 17
	public string GetAppBundleId() { }

	// RVA: 0x2E348C8 Offset: 0x2E308C8 VA: 0x2E348C8 Slot: 18
	public string GetServiceId() { }

	// RVA: 0x2E34908 Offset: 0x2E30908 VA: 0x2E34908
	public void .ctor() { }
}
