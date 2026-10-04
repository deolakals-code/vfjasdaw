// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameAvatarNaming : IGameLogicStrategy // TypeDefIndex: 14889
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3559B94 Offset: 0x3555B94 VA: 0x3559B94 Slot: 4
	public GameState get_State() { }

	// RVA: 0x3559B9C Offset: 0x3555B9C VA: 0x3559B9C Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3559DD4 Offset: 0x3555DD4 VA: 0x3559DD4 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355A024 Offset: 0x3556024 VA: 0x355A024 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355A108 Offset: 0x3556108 VA: 0x355A108 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355A12C Offset: 0x355612C VA: 0x355A12C Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x3559E18 Offset: 0x3555E18 VA: 0x3559E18
	private void HandleCreateAvatarNaming(Game game, OperationResponse response) { }

	// RVA: 0x3559F2C Offset: 0x3555F2C VA: 0x3559F2C
	private void HandleChangeLoadAvatar(Game game, OperationResponse response) { }

	// RVA: 0x355A170 Offset: 0x3556170 VA: 0x355A170
	public void .ctor() { }

	// RVA: 0x355A178 Offset: 0x3556178 VA: 0x355A178
	private static void .cctor() { }
}
