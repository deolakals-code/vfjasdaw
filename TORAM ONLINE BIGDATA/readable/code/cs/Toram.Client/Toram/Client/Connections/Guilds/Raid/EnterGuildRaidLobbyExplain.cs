// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Raid
[CLSCompliant(False)]
public abstract class EnterGuildRaidLobbyExplain : OperationExplainBase // TypeDefIndex: 15050
{
	// Fields
	private int enterGuildId; // 0x10
	private byte element; // 0x14

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x3578EC0 Offset: 0x3574EC0 VA: 0x3578EC0
	public void .ctor(int enterGuildId = 0, byte element = 0) { }

	// RVA: 0x3578EF0 Offset: 0x3574EF0 VA: 0x3578EF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3578EF8 Offset: 0x3574EF8 VA: 0x3578EF8 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x3578F68 Offset: 0x3574F68 VA: 0x3578F68 Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3578F80 Offset: 0x3574F80 VA: 0x3578F80
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemUnavailable();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGuildNotAccess();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildAllianceNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnGuildRaidElementNotMatch();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnFailure(short returnCode);
}
