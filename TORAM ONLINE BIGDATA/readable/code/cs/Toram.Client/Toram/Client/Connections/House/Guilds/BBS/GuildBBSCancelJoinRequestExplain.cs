// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSCancelJoinRequestExplain : OperationRelatedExplainBase // TypeDefIndex: 15041
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3577640 Offset: 0x3573640 VA: 0x3577640
	public void .ctor() { }

	// RVA: 0x3577648 Offset: 0x3573648 VA: 0x3577648 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3577650 Offset: 0x3573650 VA: 0x3577650 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3577658 Offset: 0x3573658 VA: 0x3577658 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35776AC Offset: 0x35736AC VA: 0x35776AC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357775C Offset: 0x357375C VA: 0x357775C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSCancelJoinRequestResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSCancelJoinRequestResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnReserveNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotImplement();
}
