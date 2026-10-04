// Assembly: Google.Play.Games.dll
// Namespace: 
private class AndroidNearbyConnectionClient.DiscoveringConnectionLifecycleCallback : AndroidJavaProxy // TypeDefIndex: 16770
{
	// Fields
	private Action<ConnectionResponse> mResponseCallback; // 0x20
	private IMessageListener mListener; // 0x28
	private AndroidJavaObject mClient; // 0x30

	// Methods

	// RVA: 0x2E26120 Offset: 0x2E22120 VA: 0x2E26120
	public void .ctor(Action<ConnectionResponse> responseCallback, IMessageListener listener, AndroidJavaObject client) { }

	// RVA: 0x2E28C38 Offset: 0x2E24C38 VA: 0x2E28C38
	public void onConnectionInitiated(string endpointId, AndroidJavaObject connectionInfo) { }

	// RVA: 0x2E28FD4 Offset: 0x2E24FD4 VA: 0x2E28FD4
	public void onConnectionResult(string endpointId, AndroidJavaObject connectionResolution) { }

	// RVA: 0x2E293D8 Offset: 0x2E253D8 VA: 0x2E293D8
	public void onDisconnected(string endpointId) { }
}
