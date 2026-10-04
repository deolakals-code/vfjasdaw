// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameLoadAvatar : IGameLogicStrategy // TypeDefIndex: 14893
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355B854 Offset: 0x3557854 VA: 0x355B854 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355B85C Offset: 0x355785C VA: 0x355B85C Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355BBBC Offset: 0x3557BBC VA: 0x355BBBC Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355C12C Offset: 0x355812C VA: 0x355C12C Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355C210 Offset: 0x3558210 VA: 0x355C210 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355C234 Offset: 0x3558234 VA: 0x355C234 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355BC10 Offset: 0x3557C10 VA: 0x355BC10
	public void HandleOperationLoadAvatarData(Game game, OperationResponse response) { }

	// RVA: 0x355BD6C Offset: 0x3557D6C VA: 0x355BD6C
	public void HandleLoadAvatarEntry(Game game, OperationResponse response) { }

	// RVA: 0x355BEFC Offset: 0x3557EFC VA: 0x355BEFC
	public void HandleLoadAvatarCheck(Game game, OperationResponse response) { }

	// RVA: 0x355C278 Offset: 0x3558278 VA: 0x355C278
	public void .ctor() { }

	// RVA: 0x355C280 Offset: 0x3558280 VA: 0x355C280
	private static void .cctor() { }
}
