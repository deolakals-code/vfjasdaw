// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameBlank : IGameLogicStrategy // TypeDefIndex: 14890
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355A1E0 Offset: 0x35561E0 VA: 0x355A1E0 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355A1E8 Offset: 0x35561E8 VA: 0x355A1E8 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355A390 Offset: 0x3556390 VA: 0x355A390 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355A554 Offset: 0x3556554 VA: 0x355A554 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355A638 Offset: 0x3556638 VA: 0x355A638 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355A65C Offset: 0x355665C VA: 0x355A65C Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355A4DC Offset: 0x35564DC VA: 0x355A4DC
	private void HandleOperationGlobal(Game game, OperationResponse response) { }

	// RVA: 0x355A6A0 Offset: 0x35566A0 VA: 0x355A6A0
	private static void NoticeOperationFailure(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355A754 Offset: 0x3556754 VA: 0x355A754
	public void .ctor() { }

	// RVA: 0x355A75C Offset: 0x355675C VA: 0x355A75C
	private static void .cctor() { }
}
