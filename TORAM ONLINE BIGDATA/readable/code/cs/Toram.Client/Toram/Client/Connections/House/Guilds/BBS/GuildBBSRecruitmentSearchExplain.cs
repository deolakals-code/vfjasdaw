// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSRecruitmentSearchExplain : OperationRelatedExplainBase // TypeDefIndex: 15044
{
	// Fields
	private readonly byte joinType; // 0x10
	private readonly byte conditionsType; // 0x11
	private readonly byte stringSearchType; // 0x12
	private readonly string searchString; // 0x18
	private readonly byte page; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357808C Offset: 0x357408C VA: 0x357808C
	public void .ctor(byte joinType, byte conditionsType, byte stringSearchType, string searchString, byte page) { }

	// RVA: 0x35780F0 Offset: 0x35740F0 VA: 0x35780F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35780F8 Offset: 0x35740F8 VA: 0x35780F8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3578100 Offset: 0x3574100 VA: 0x3578100 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3578190 Offset: 0x3574190 VA: 0x3578190 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3578240 Offset: 0x3574240 VA: 0x3578240
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildBBSRecruitmentSearchResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSRecruitmentSearchResponse response);

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
	protected abstract void OnValueWrong();
}
