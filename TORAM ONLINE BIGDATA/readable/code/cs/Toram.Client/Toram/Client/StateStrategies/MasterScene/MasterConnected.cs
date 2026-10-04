// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.MasterScene
internal class MasterConnected : IGameLogicStrategy // TypeDefIndex: 14884
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3557D0C Offset: 0x3553D0C VA: 0x3557D0C Slot: 4
	public GameState get_State() { }

	// RVA: 0x3557D14 Offset: 0x3553D14 VA: 0x3557D14 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3557D2C Offset: 0x3553D2C VA: 0x3557D2C Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x3558534 Offset: 0x3554534 VA: 0x3558534 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x3558698 Offset: 0x3554698 VA: 0x3558698 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x35586BC Offset: 0x35546BC VA: 0x35586BC Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x3557D70 Offset: 0x3553D70 VA: 0x3557D70
	private void HandleOperationLogin(Game game, OperationResponse response) { }

	// RVA: 0x3558250 Offset: 0x3554250 VA: 0x3558250
	private void HandleOperationReLogin(Game game, OperationResponse response) { }

	// RVA: 0x3558700 Offset: 0x3554700 VA: 0x3558700
	public void .ctor() { }

	// RVA: 0x3558708 Offset: 0x3554708 VA: 0x3558708
	private static void .cctor() { }
}
