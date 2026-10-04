// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.Nearby
public interface IMessageListener // TypeDefIndex: 16852
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnRemoteEndpointDisconnected(string remoteEndpointId);
}
