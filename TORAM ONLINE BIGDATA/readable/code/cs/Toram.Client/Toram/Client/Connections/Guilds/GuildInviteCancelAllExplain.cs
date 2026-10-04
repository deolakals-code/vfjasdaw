// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds
[CLSCompliant(False)]
public abstract class GuildInviteCancelAllExplain : OperationExplainBase // TypeDefIndex: 15047
{
	// Fields
	private readonly int exceptGuildId; // 0x10

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x35788F4 Offset: 0x35748F4 VA: 0x35788F4
	public void .ctor(int exceptGuildId) { }

	// RVA: 0x357891C Offset: 0x357491C VA: 0x357891C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3578924 Offset: 0x3574924 VA: 0x3578924 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x357898C Offset: 0x357498C VA: 0x357898C Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3578A18 Offset: 0x3574A18 VA: 0x3578A18
	private GameReturnCode ReceiveResponse(short returnCode, GuildInviteCancelAllResponse response) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnSuccess(GuildInviteCancelAllResponse response);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnFailure(GuildInviteCancelAllResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnErr_ReserveNotFound(GuildInviteCancelAllResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnErr_ReserveLeft(GuildInviteCancelAllResponse response);
}
