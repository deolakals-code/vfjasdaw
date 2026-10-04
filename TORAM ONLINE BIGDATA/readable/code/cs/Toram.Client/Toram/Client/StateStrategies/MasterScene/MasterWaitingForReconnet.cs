// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.MasterScene
internal class MasterWaitingForReconnet : IGameLogicStrategy // TypeDefIndex: 14887
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3558E64 Offset: 0x3554E64 VA: 0x3558E64 Slot: 4
	public GameState get_State() { }

	// RVA: 0x3558E6C Offset: 0x3554E6C VA: 0x3558E6C Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3558E84 Offset: 0x3554E84 VA: 0x3558E84 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x3558E9C Offset: 0x3554E9C VA: 0x3558E9C Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x3559124 Offset: 0x3555124 VA: 0x3559124 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x3559148 Offset: 0x3555148 VA: 0x3559148 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x35591F8 Offset: 0x35551F8 VA: 0x35591F8
	public void .ctor() { }

	// RVA: 0x3559200 Offset: 0x3555200 VA: 0x3559200
	private static void .cctor() { }
}
