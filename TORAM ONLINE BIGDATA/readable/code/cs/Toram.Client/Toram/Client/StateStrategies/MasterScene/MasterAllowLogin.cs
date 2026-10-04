// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.MasterScene
internal class MasterAllowLogin : IGameLogicStrategy // TypeDefIndex: 14885
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3558770 Offset: 0x3554770 VA: 0x3558770 Slot: 4
	public GameState get_State() { }

	// RVA: 0x3558778 Offset: 0x3554778 VA: 0x3558778 Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3558790 Offset: 0x3554790 VA: 0x3558790 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x35587A8 Offset: 0x35547A8 VA: 0x35587A8 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x35589DC Offset: 0x35549DC VA: 0x35589DC Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x3558A00 Offset: 0x3554A00 VA: 0x3558A00 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x3558AB0 Offset: 0x3554AB0 VA: 0x3558AB0
	public void .ctor() { }

	// RVA: 0x3558AB8 Offset: 0x3554AB8 VA: 0x3558AB8
	private static void .cctor() { }
}
