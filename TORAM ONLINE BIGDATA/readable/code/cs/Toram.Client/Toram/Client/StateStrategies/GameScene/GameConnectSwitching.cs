// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameConnectSwitching : IGameLogicStrategy // TypeDefIndex: 14892
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355B570 Offset: 0x3557570 VA: 0x355B570 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355B578 Offset: 0x3557578 VA: 0x355B578 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355B590 Offset: 0x3557590 VA: 0x355B590 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355B5A8 Offset: 0x35575A8 VA: 0x355B5A8 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355B710 Offset: 0x3557710 VA: 0x355B710 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355B734 Offset: 0x3557734 VA: 0x355B734 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355B7E4 Offset: 0x35577E4 VA: 0x355B7E4
	public void .ctor() { }

	// RVA: 0x355B7EC Offset: 0x35577EC VA: 0x355B7EC
	private static void .cctor() { }
}
