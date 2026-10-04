// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSRejectRequestExplain : OperationRelatedExplainBase // TypeDefIndex: 15035
{
	// Fields
	public int targetId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35760B4 Offset: 0x35720B4 VA: 0x35760B4
	public void .ctor(int targetId) { }

	// RVA: 0x35760DC Offset: 0x35720DC VA: 0x35760DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35760E4 Offset: 0x35720E4 VA: 0x35760E4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35760EC Offset: 0x35720EC VA: 0x35760EC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3576154 Offset: 0x3572154 VA: 0x3576154 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3576204 Offset: 0x3572204 VA: 0x3576204
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSRejectRequestResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSRejectRequestResponse response);

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
	protected abstract void OnMemberNotAllowed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnNotFound();
}
