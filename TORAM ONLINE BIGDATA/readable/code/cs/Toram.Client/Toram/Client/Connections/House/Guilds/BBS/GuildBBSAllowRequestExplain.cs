// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSAllowRequestExplain : OperationRelatedExplainBase // TypeDefIndex: 15036
{
	// Fields
	public int targetId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35763DC Offset: 0x35723DC VA: 0x35763DC
	public void .ctor(int targetId) { }

	// RVA: 0x3576404 Offset: 0x3572404 VA: 0x3576404 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357640C Offset: 0x357240C VA: 0x357640C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3576414 Offset: 0x3572414 VA: 0x3576414 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357647C Offset: 0x357247C VA: 0x357647C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357652C Offset: 0x357252C VA: 0x357652C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSAllowRequestResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSAllowRequestResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotImplement();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnUserDisposed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnGuildNotAccess();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnMemberNotAllowed();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnMemberInvited();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnGuildAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnNoVacancies();

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void OnUserNotFound();

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract void OnReserveNotFound();
}
