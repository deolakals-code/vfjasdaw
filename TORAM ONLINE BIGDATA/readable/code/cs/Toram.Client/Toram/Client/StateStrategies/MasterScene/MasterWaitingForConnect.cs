// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.MasterScene
internal class MasterWaitingForConnect : IGameLogicStrategy // TypeDefIndex: 14886
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3558B20 Offset: 0x3554B20 VA: 0x3558B20 Slot: 4
	public GameState get_State() { }

	// RVA: 0x3558B28 Offset: 0x3554B28 VA: 0x3558B28 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3558B40 Offset: 0x3554B40 VA: 0x3558B40 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x3558B58 Offset: 0x3554B58 VA: 0x3558B58 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x3558D20 Offset: 0x3554D20 VA: 0x3558D20 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x3558D44 Offset: 0x3554D44 VA: 0x3558D44 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x3558DF4 Offset: 0x3554DF4 VA: 0x3558DF4
	public void .ctor() { }

	// RVA: 0x3558DFC Offset: 0x3554DFC VA: 0x3558DFC
	private static void .cctor() { }
}
