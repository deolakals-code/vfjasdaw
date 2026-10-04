// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSJoinRequestExplain : OperationRelatedExplainBase // TypeDefIndex: 15043
{
	// Fields
	private readonly int guildId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3577CE0 Offset: 0x3573CE0 VA: 0x3577CE0
	public void .ctor(int guildId) { }

	// RVA: 0x3577D08 Offset: 0x3573D08 VA: 0x3577D08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3577D10 Offset: 0x3573D10 VA: 0x3577D10 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3577D18 Offset: 0x3573D18 VA: 0x3577D18 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3577D80 Offset: 0x3573D80 VA: 0x3577D80 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3577E30 Offset: 0x3573E30 VA: 0x3577E30
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSJoinRequestResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSJoinRequestResponse response);

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

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnGuildNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnAlreadyReserved();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnDataNull();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnEquipTypeErr();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnMemberInvited();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnWaitingOver();
}
