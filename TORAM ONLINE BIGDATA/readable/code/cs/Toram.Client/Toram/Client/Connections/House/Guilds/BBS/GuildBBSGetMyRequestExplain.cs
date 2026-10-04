// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSGetMyRequestExplain : OperationRelatedExplainBase // TypeDefIndex: 15045
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35783F8 Offset: 0x35743F8 VA: 0x35783F8
	public void .ctor() { }

	// RVA: 0x3578400 Offset: 0x3574400 VA: 0x3578400 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3578408 Offset: 0x3574408 VA: 0x3578408 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3578410 Offset: 0x3574410 VA: 0x3578410 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3578464 Offset: 0x3574464 VA: 0x3578464 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3578514 Offset: 0x3574514 VA: 0x3578514
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSGetMyRequestResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSGetMyRequestResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotImplement();
}
