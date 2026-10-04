// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies
internal interface IGameLogicStrategy // TypeDefIndex: 14881
{
	// Properties
	public abstract GameState State { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameState get_State();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEventReceive(Game game, EventData eventData);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnOperationReturn(Game game, OperationResponse operationResponse);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPeerStatusCallback(Game game, StatusCode returnCode);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnUpdate(Game game);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt);
}
