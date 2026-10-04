// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSGetRequestersListExplain : OperationRelatedExplainBase // TypeDefIndex: 15037
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35767C4 Offset: 0x35727C4 VA: 0x35767C4
	public void .ctor() { }

	// RVA: 0x35767CC Offset: 0x35727CC VA: 0x35767CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35767D4 Offset: 0x35727D4 VA: 0x35767D4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35767DC Offset: 0x35727DC VA: 0x35767DC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3576830 Offset: 0x3572830 VA: 0x3576830 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35768E0 Offset: 0x35728E0 VA: 0x35768E0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSGetRequestersListResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSGetRequestersListResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotImplement();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnMemberNotAllowed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnDataNull();
}
