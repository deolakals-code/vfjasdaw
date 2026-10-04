// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameRename : IGameLogicStrategy // TypeDefIndex: 14898
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355E43C Offset: 0x355A43C VA: 0x355E43C Slot: 4
	public GameState get_State() { }

	// RVA: 0x355E444 Offset: 0x355A444 VA: 0x355E444 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355E714 Offset: 0x355A714 VA: 0x355E714 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355EB18 Offset: 0x355AB18 VA: 0x355EB18 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355EBFC Offset: 0x355ABFC VA: 0x355EBFC Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355EC20 Offset: 0x355AC20 VA: 0x355EC20 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355E768 Offset: 0x355A768 VA: 0x355E768
	private void HandleChangeLoadAvatar(Game game, OperationResponse response) { }

	// RVA: 0x355E860 Offset: 0x355A860 VA: 0x355E860
	private void HandleOperationOrb(Game game, OperationResponse response) { }

	// RVA: 0x355E9D0 Offset: 0x355A9D0 VA: 0x355E9D0
	private void HandleRename(Game game, OperationResponse response) { }

	// RVA: 0x355EC64 Offset: 0x355AC64 VA: 0x355EC64
	public void .ctor() { }

	// RVA: 0x355EC6C Offset: 0x355AC6C VA: 0x355EC6C
	private static void .cctor() { }
}
