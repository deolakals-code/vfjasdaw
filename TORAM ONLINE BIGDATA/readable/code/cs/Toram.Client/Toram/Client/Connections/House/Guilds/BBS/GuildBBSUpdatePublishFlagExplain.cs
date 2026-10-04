// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSUpdatePublishFlagExplain : OperationRelatedExplainBase // TypeDefIndex: 15038
{
	// Fields
	private readonly byte publishFlag; // 0x10
	private readonly string comment; // 0x18
	private readonly byte joinType; // 0x20
	private readonly byte conditionsType; // 0x21
	private readonly int conditionsValue; // 0x24

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3576AB8 Offset: 0x3572AB8 VA: 0x3576AB8
	public void .ctor(bool publishFlag, GuildBBSSendData data) { }

	// RVA: 0x3576B18 Offset: 0x3572B18 VA: 0x3576B18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3576B20 Offset: 0x3572B20 VA: 0x3576B20 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3576B28 Offset: 0x3572B28 VA: 0x3576B28 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3576BB8 Offset: 0x3572BB8 VA: 0x3576BB8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3576BD0 Offset: 0x3572BD0 VA: 0x3576BD0
	private GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSUpdatePublishFlagResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnDifferenceInformation();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotImplement();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnMemberNotAllowed();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnDataNull();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnNoVacancies();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnWaitingOver();
}
