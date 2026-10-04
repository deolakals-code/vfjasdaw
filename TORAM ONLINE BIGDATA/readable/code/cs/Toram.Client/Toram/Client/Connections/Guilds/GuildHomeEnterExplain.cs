// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds
[CLSCompliant(False)]
public abstract class GuildHomeEnterExplain : OperationExplainBase // TypeDefIndex: 15046
{
	// Fields
	private int enterGuildId; // 0x10

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x35786B4 Offset: 0x35746B4 VA: 0x35786B4
	public void .ctor(int enterGuildId = 0) { }

	// RVA: 0x35786DC Offset: 0x35746DC VA: 0x35786DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35786E4 Offset: 0x35746E4 VA: 0x35786E4 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x357874C Offset: 0x357474C VA: 0x357874C Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3578764 Offset: 0x3574764 VA: 0x3578764
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
	protected abstract void OnFailure(short returnCode);
}
