// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public interface IPhotonPeerListener // TypeDefIndex: 16962
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DebugReturn(DebugLevel level, string message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnOperationResponse(OperationResponse operationResponse);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStatusChanged(StatusCode statusCode);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEvent(EventData eventData);
}
