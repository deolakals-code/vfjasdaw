// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSGetRegisterDataExplain : OperationRelatedExplainBase // TypeDefIndex: 15040
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357734C Offset: 0x357334C VA: 0x357734C
	public void .ctor() { }

	// RVA: 0x3577354 Offset: 0x3573354 VA: 0x3577354 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357735C Offset: 0x357335C VA: 0x357735C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3577364 Offset: 0x3573364 VA: 0x3577364 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35773B8 Offset: 0x35733B8 VA: 0x35773B8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3577468 Offset: 0x3573468 VA: 0x3577468
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSGetRegisterDataResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSGetRegisterDataResponse response);

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
	protected abstract void OnDataNull();
}
