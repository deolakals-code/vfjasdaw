// Assembly: Google.Play.Games.dll
// Namespace: 
private class AndroidNearbyConnectionClient.OnGameThreadMessageListener : IMessageListener // TypeDefIndex: 16774
{
	// Fields
	private readonly IMessageListener mListener; // 0x10

	// Methods

	// RVA: 0x2E260B0 Offset: 0x2E220B0 VA: 0x2E260B0
	public void .ctor(IMessageListener listener) { }

	// RVA: 0x2E297B0 Offset: 0x2E257B0 VA: 0x2E297B0 Slot: 4
	public void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage) { }

	// RVA: 0x2E298DC Offset: 0x2E258DC VA: 0x2E298DC Slot: 5
	public void OnRemoteEndpointDisconnected(string remoteEndpointId) { }
}
