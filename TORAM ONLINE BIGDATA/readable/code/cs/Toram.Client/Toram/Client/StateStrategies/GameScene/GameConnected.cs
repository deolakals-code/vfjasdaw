// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameConnected : IGameLogicStrategy // TypeDefIndex: 14891
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355A7C4 Offset: 0x35567C4 VA: 0x355A7C4 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355A7CC Offset: 0x35567CC VA: 0x355A7CC Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355A974 Offset: 0x3556974 VA: 0x355A974 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355B3B4 Offset: 0x35573B4 VA: 0x355B3B4 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355B498 Offset: 0x3557498 VA: 0x355B498 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355B4BC Offset: 0x35574BC VA: 0x355B4BC Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355A9B8 Offset: 0x35569B8 VA: 0x355A9B8
	private void HandleOperationGameJoin(Game game, OperationResponse response) { }

	// RVA: 0x355AE98 Offset: 0x3556E98 VA: 0x355AE98
	private void HandleOperationGameReJoin(Game game, OperationResponse response) { }

	// RVA: 0x355B500 Offset: 0x3557500 VA: 0x355B500
	public void .ctor() { }

	// RVA: 0x355B508 Offset: 0x3557508 VA: 0x355B508
	private static void .cctor() { }
}
