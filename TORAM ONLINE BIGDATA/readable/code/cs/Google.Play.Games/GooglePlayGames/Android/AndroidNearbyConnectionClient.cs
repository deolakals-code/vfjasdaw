// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
public class AndroidNearbyConnectionClient : INearbyConnectionClient // TypeDefIndex: 16784
{
	// Fields
	private AndroidJavaObject mClient; // 0x10
	private static readonly long NearbyClientId; // 0x0
	private static readonly int ApplicationInfoFlags; // 0x8
	private static readonly string ServiceId; // 0x10
	protected IMessageListener mAdvertisingMessageListener; // 0x18

	// Methods

	// RVA: 0x2E0FB14 Offset: 0x2E0BB14 VA: 0x2E0FB14
	public void .ctor() { }

	// RVA: 0x2E246D4 Offset: 0x2E206D4 VA: 0x2E246D4 Slot: 4
	public int MaxUnreliableMessagePayloadLength() { }

	// RVA: 0x2E246DC Offset: 0x2E206DC VA: 0x2E246DC Slot: 5
	public int MaxReliableMessagePayloadLength() { }

	// RVA: 0x2E246E4 Offset: 0x2E206E4 VA: 0x2E246E4 Slot: 6
	public void SendReliable(List<string> recipientEndpointIds, byte[] payload) { }

	// RVA: 0x2E24C0C Offset: 0x2E20C0C VA: 0x2E24C0C Slot: 7
	public void SendUnreliable(List<string> recipientEndpointIds, byte[] payload) { }

	// RVA: 0x2E246E8 Offset: 0x2E206E8 VA: 0x2E246E8
	private void InternalSend(List<string> recipientEndpointIds, byte[] payload) { }

	// RVA: 0x2E24C10 Offset: 0x2E20C10 VA: 0x2E24C10 Slot: 8
	public void StartAdvertising(string name, List<string> appIdentifiers, Nullable<TimeSpan> advertisingDuration, Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback) { }

	// RVA: 0x2E25558 Offset: 0x2E21558 VA: 0x2E25558
	private AndroidJavaObject CreateAdvertisingOptions() { }

	// RVA: 0x2E25B78 Offset: 0x2E21B78 VA: 0x2E25B78 Slot: 9
	public void StopAdvertising() { }

	// RVA: 0x2E25C48 Offset: 0x2E21C48 VA: 0x2E25C48 Slot: 10
	public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, Action<ConnectionResponse> responseCallback, IMessageListener listener) { }

	// RVA: 0x2E261DC Offset: 0x2E221DC VA: 0x2E261DC Slot: 11
	public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, IMessageListener listener) { }

	// RVA: 0x2E2667C Offset: 0x2E2267C VA: 0x2E2667C Slot: 12
	public void StartDiscovery(string serviceId, Nullable<TimeSpan> advertisingDuration, IDiscoveryListener listener) { }

	// RVA: 0x2E26EF8 Offset: 0x2E22EF8 VA: 0x2E26EF8
	private AndroidJavaObject CreateDiscoveryOptions() { }

	// RVA: 0x2E27518 Offset: 0x2E23518 VA: 0x2E27518 Slot: 13
	public void StopDiscovery(string serviceId) { }

	// RVA: 0x2E275D8 Offset: 0x2E235D8 VA: 0x2E275D8 Slot: 14
	public void RejectConnectionRequest(string requestingEndpointId) { }

	// RVA: 0x2E27788 Offset: 0x2E23788 VA: 0x2E27788 Slot: 15
	public void DisconnectFromEndpoint(string remoteEndpointId) { }

	// RVA: 0x2E2785C Offset: 0x2E2385C VA: 0x2E2785C Slot: 16
	public void StopAllConnections() { }

	// RVA: 0x2E2792C Offset: 0x2E2392C VA: 0x2E2792C Slot: 17
	public string GetAppBundleId() { }

	// RVA: 0x2E27B38 Offset: 0x2E23B38 VA: 0x2E27B38 Slot: 18
	public string GetServiceId() { }

	// RVA: 0x2E27B90 Offset: 0x2E23B90 VA: 0x2E27B90
	private static string ReadServiceId() { }

	// RVA: -1 Offset: -1
	private static Action<T> ToOnGameThread<T>(Action<T> toConvert) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A64A8 Offset: 0x26A24A8 VA: 0x26A64A8
	|-AndroidNearbyConnectionClient.ToOnGameThread<AdvertisingResult>
	|
	|-RVA: 0x26A6544 Offset: 0x26A2544 VA: 0x26A6544
	|-AndroidNearbyConnectionClient.ToOnGameThread<ConnectionRequest>
	|
	|-RVA: 0x26A65E0 Offset: 0x26A25E0 VA: 0x26A65E0
	|-AndroidNearbyConnectionClient.ToOnGameThread<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A6684 Offset: 0x26A2684 VA: 0x26A6684
	|-AndroidNearbyConnectionClient.ToOnGameThread<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E28444 Offset: 0x2E24444 VA: 0x2E28444
	private static void .cctor() { }
}
