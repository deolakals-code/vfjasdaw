// Assembly: Google.Play.Games.dll
// Namespace: 
private class AndroidNearbyConnectionClient.EndpointDiscoveryCallback : AndroidJavaProxy // TypeDefIndex: 16771
{
	// Fields
	private IDiscoveryListener mListener; // 0x20

	// Methods

	// RVA: 0x2E26E6C Offset: 0x2E22E6C VA: 0x2E26E6C
	public void .ctor(IDiscoveryListener listener) { }

	// RVA: 0x2E29484 Offset: 0x2E25484 VA: 0x2E29484
	public void onEndpointFound(string endpointId, AndroidJavaObject endpointInfo) { }

	// RVA: 0x2E29704 Offset: 0x2E25704 VA: 0x2E29704
	public void onEndpointLost(string endpointId) { }

	// RVA: 0x2E29588 Offset: 0x2E25588 VA: 0x2E29588
	private EndpointDetails CreateEndPointDetails(string endpointId, AndroidJavaObject endpointInfo) { }
}
