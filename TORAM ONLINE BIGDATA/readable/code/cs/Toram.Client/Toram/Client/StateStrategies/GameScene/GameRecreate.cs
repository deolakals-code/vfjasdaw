// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameRecreate : IGameLogicStrategy // TypeDefIndex: 14897
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355DD9C Offset: 0x3559D9C VA: 0x355DD9C Slot: 4
	public GameState get_State() { }

	// RVA: 0x355DDA4 Offset: 0x3559DA4 VA: 0x355DDA4 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355DFDC Offset: 0x3559FDC VA: 0x355DFDC Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355E280 Offset: 0x355A280 VA: 0x355E280 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355E364 Offset: 0x355A364 VA: 0x355E364 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355E388 Offset: 0x355A388 VA: 0x355E388 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355E020 Offset: 0x355A020 VA: 0x355E020
	private void HandleChangeLoadAvatar(Game game, OperationResponse response) { }

	// RVA: 0x355E118 Offset: 0x355A118 VA: 0x355E118
	private void HandleChangeRecreateStyle(Game game, OperationResponse response) { }

	// RVA: 0x355E3CC Offset: 0x355A3CC VA: 0x355E3CC
	public void .ctor() { }

	// RVA: 0x355E3D4 Offset: 0x355A3D4 VA: 0x355E3D4
	private static void .cctor() { }
}
