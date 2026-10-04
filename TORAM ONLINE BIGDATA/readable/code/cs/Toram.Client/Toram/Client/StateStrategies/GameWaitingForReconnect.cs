// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies
internal class GameWaitingForReconnect : IGameLogicStrategy // TypeDefIndex: 14883
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x35579B8 Offset: 0x35539B8 VA: 0x35579B8 Slot: 4
	public GameState get_State() { }

	// RVA: 0x35579C0 Offset: 0x35539C0 VA: 0x35579C0 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x35579D8 Offset: 0x35539D8 VA: 0x35579D8 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x35579F0 Offset: 0x35539F0 VA: 0x35579F0 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x3557BC8 Offset: 0x3553BC8 VA: 0x3557BC8 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x3557BEC Offset: 0x3553BEC VA: 0x3557BEC Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x3557C9C Offset: 0x3553C9C VA: 0x3557C9C
	public void .ctor() { }

	// RVA: 0x3557CA4 Offset: 0x3553CA4 VA: 0x3557CA4
	private static void .cctor() { }
}
