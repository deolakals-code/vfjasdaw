// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies
internal class Disconnected : IGameLogicStrategy // TypeDefIndex: 14882
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3557784 Offset: 0x3553784 VA: 0x3557784 Slot: 4
	public GameState get_State() { }

	// RVA: 0x355778C Offset: 0x355378C VA: 0x355778C Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x35577A4 Offset: 0x35537A4 VA: 0x35577A4 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x35577BC Offset: 0x35537BC VA: 0x35577BC Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x3557844 Offset: 0x3553844 VA: 0x3557844 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x3557898 Offset: 0x3553898 VA: 0x3557898 Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x3557948 Offset: 0x3553948 VA: 0x3557948
	public void .ctor() { }

	// RVA: 0x3557950 Offset: 0x3553950 VA: 0x3557950
	private static void .cctor() { }
}
