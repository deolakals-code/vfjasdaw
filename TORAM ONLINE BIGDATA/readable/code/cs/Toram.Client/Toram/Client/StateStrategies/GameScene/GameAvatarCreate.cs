// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameAvatarCreate : IGameLogicStrategy // TypeDefIndex: 14888
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3559268 Offset: 0x3555268 VA: 0x3559268 Slot: 4
	public GameState get_State() { }

	// RVA: 0x3559270 Offset: 0x3555270 VA: 0x3559270 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3559540 Offset: 0x3555540 VA: 0x3559540 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x35599D8 Offset: 0x35559D8 VA: 0x35599D8 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x3559ABC Offset: 0x3555ABC VA: 0x3559ABC Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x3559AE0 Offset: 0x3555AE0 VA: 0x3559AE0 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x35595B8 Offset: 0x35555B8 VA: 0x35595B8
	private void HandleCreateAvatarStart(Game game, OperationResponse responseObject) { }

	// RVA: 0x35596B8 Offset: 0x35556B8 VA: 0x35596B8
	private void HandleCreateCheckName(Game game, OperationResponse response) { }

	// RVA: 0x35597CC Offset: 0x35557CC VA: 0x35597CC
	private void HandleCreateNewAvatar(Game game, OperationResponse response) { }

	// RVA: 0x35598E0 Offset: 0x35558E0 VA: 0x35598E0
	private void HandleChangeLoadAvatar(Game game, OperationResponse response) { }

	// RVA: 0x3559B24 Offset: 0x3555B24 VA: 0x3559B24
	public void .ctor() { }

	// RVA: 0x3559B2C Offset: 0x3555B2C VA: 0x3559B2C
	private static void .cctor() { }
}
