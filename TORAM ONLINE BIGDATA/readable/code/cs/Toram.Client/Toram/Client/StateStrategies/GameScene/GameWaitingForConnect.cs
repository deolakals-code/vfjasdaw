// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameWaitingForConnect : IGameLogicStrategy // TypeDefIndex: 14899
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x355ECD4 Offset: 0x355ACD4 VA: 0x355ECD4 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355ECDC Offset: 0x355ACDC VA: 0x355ECDC Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x355ECF4 Offset: 0x355ACF4 VA: 0x355ECF4 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x355ED0C Offset: 0x355AD0C VA: 0x355ED0C Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x355EE60 Offset: 0x355AE60 VA: 0x355EE60 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x355EE84 Offset: 0x355AE84 VA: 0x355EE84 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x355EF34 Offset: 0x355AF34 VA: 0x355EF34
	public void .ctor() { }

	// RVA: 0x355EF3C Offset: 0x355AF3C VA: 0x355EF3C
	private static void .cctor() { }
}
