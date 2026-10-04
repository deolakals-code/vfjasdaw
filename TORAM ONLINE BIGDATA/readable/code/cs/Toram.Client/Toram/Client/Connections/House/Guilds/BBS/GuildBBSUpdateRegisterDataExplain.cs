// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Guilds.BBS
[CLSCompliant(False)]
public abstract class GuildBBSUpdateRegisterDataExplain : OperationRelatedExplainBase // TypeDefIndex: 15039
{
	// Fields
	private readonly string comment; // 0x10
	private readonly byte joinType; // 0x18
	private readonly byte conditionsType; // 0x19
	private readonly int conditionsValue; // 0x1C
	private readonly string oldComment; // 0x20
	private readonly byte oldJoinType; // 0x28
	private readonly byte oldConditionsType; // 0x29
	private readonly int oldConditionsValue; // 0x2C
	private readonly byte oldFlag; // 0x30
	private readonly byte firstRegister; // 0x31

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3576E9C Offset: 0x3572E9C VA: 0x3576E9C
	public void .ctor(string comment, byte joinType, byte conditionsType, int conditionsValue, GuildBBSSendData oldData) { }

	// RVA: 0x3576F90 Offset: 0x3572F90 VA: 0x3576F90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3576F98 Offset: 0x3572F98 VA: 0x3576F98 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3576FA0 Offset: 0x3572FA0 VA: 0x3576FA0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3577068 Offset: 0x3573068 VA: 0x3577068 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3577080 Offset: 0x3573080 VA: 0x3577080
	private GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildBBSUpdateRegisterDataResponse response);

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
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnUserDisposed();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnGuildNotAccess();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnDifferenceInformation();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnNoVacancies();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnWaitingOver();
}
