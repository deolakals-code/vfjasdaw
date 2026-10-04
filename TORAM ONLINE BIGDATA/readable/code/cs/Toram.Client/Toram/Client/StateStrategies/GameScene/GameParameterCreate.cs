// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameParameterCreate : IGameLogicStrategy // TypeDefIndex: 14896
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355D748 Offset: 0x3559748 VA: 0x355D748 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355D750 Offset: 0x3559750 VA: 0x355D750 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355D988 Offset: 0x3559988 VA: 0x355D988 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355DBE0 Offset: 0x3559BE0 VA: 0x355DBE0 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355DCC4 Offset: 0x3559CC4 VA: 0x355DCC4 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355DCE8 Offset: 0x3559CE8 VA: 0x355DCE8 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355D9CC Offset: 0x35599CC VA: 0x355D9CC
	private void HandleCreateNewParameter(Game game, OperationResponse response) { }

	// RVA: 0x355DAE8 Offset: 0x3559AE8 VA: 0x355DAE8
	private void HandleChangeLoadAvatar(Game game, OperationResponse response) { }

	// RVA: 0x355DD2C Offset: 0x3559D2C VA: 0x355DD2C
	public void .ctor() { }

	// RVA: 0x355DD34 Offset: 0x3559D34 VA: 0x355DD34
	private static void .cctor() { }
}
