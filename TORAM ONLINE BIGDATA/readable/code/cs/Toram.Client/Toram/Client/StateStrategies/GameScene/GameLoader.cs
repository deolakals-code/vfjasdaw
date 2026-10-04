// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameLoader : IGameLogicStrategy // TypeDefIndex: 14894
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355C2E8 Offset: 0x35582E8 VA: 0x355C2E8 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355C2F0 Offset: 0x35582F0 VA: 0x355C2F0 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355CEE0 Offset: 0x3558EE0 VA: 0x355CEE0 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355D58C Offset: 0x355958C VA: 0x355D58C Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355D670 Offset: 0x3559670 VA: 0x355D670 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355D694 Offset: 0x3559694 VA: 0x355D694 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355D030 Offset: 0x3559030 VA: 0x355D030
	private void HandleOperationLoginField(Game game, OperationResponse response) { }

	// RVA: 0x355D178 Offset: 0x3559178 VA: 0x355D178
	private void HandleOperationEnterField(Game game, OperationResponse response) { }

	// RVA: 0x355D3A4 Offset: 0x35593A4 VA: 0x355D3A4
	private void HandleOperationReturnEmergency(Game game, OperationResponse response) { }

	// RVA: 0x355D514 Offset: 0x3559514 VA: 0x355D514
	private void HandleOperationLoaderBlankChange(Game game, OperationResponse response) { }

	// RVA: 0x355CDF8 Offset: 0x3558DF8 VA: 0x355CDF8
	private void HandleEventEnterDungeonField(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x355D6D8 Offset: 0x35596D8 VA: 0x355D6D8
	public void .ctor() { }

	// RVA: 0x355D6E0 Offset: 0x35596E0 VA: 0x355D6E0
	private static void .cctor() { }
}
