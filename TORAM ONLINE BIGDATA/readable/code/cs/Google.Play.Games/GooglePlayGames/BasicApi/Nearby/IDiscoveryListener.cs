// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public interface IDiscoveryListener // TypeDefIndex: 16853
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndpointFound(EndpointDetails discoveredEndpoint);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndpointLost(string lostEndpointId);
}
