// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class AllianceGetRaidHeldDataExplain : OperationRelatedExplainBase // TypeDefIndex: 15052
{
	// Fields
	private int guildId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3579530 Offset: 0x3575530 VA: 0x3579530
	public void .ctor(int guildId) { }

	// RVA: 0x3579558 Offset: 0x3575558 VA: 0x3579558 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3579560 Offset: 0x3575560 VA: 0x3579560 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3579568 Offset: 0x3575568 VA: 0x3579568 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35795D0 Offset: 0x35755D0 VA: 0x35795D0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357972C Offset: 0x357572C VA: 0x357972C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildAllianceGetRaidHeldDataResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildAllianceGetRaidHeldDataResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnServerDisconnect();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnUserDisposed();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildNotAccess();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnAllianceNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnInfoNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
