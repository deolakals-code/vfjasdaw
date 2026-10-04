// Assembly: Google.Play.Games.dll
// Namespace: 
private class AndroidNearbyConnectionClient.AdvertisingConnectionLifecycleCallbackProxy : AndroidJavaProxy // TypeDefIndex: 16768
{
	// Fields
	private Action<AdvertisingResult> mResultCallback; // 0x20
	private Action<ConnectionRequest> mConnectionRequestCallback; // 0x28
	private AndroidNearbyConnectionClient mClient; // 0x30
	private string mLocalEndpointName; // 0x38

	// Methods

	// RVA: 0x2E2549C Offset: 0x2E2149C VA: 0x2E2549C
	public void .ctor(Action<AdvertisingResult> resultCallback, Action<ConnectionRequest> connectionRequestCallback, AndroidNearbyConnectionClient client) { }

	// RVA: 0x2E284AC Offset: 0x2E244AC VA: 0x2E284AC
	public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo) { }

	// RVA: 0x2E28660 Offset: 0x2E24660 VA: 0x2E28660
	public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution) { }

	// RVA: 0x2E28978 Offset: 0x2E24978 VA: 0x2E28978
	public void onDisconnected(string endpointId) { }
}
