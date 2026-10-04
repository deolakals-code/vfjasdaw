// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.HighRaid
[CLSCompliant(False)]
public abstract class GetHighRaidTrophysExplain : OperationRelatedExplainBase // TypeDefIndex: 14974
{
	// Fields
	private readonly byte highRaidNo; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356B738 Offset: 0x3567738 VA: 0x356B738
	public void .ctor(byte highRaidNo) { }

	// RVA: 0x356B760 Offset: 0x3567760 VA: 0x356B760 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356B768 Offset: 0x3567768 VA: 0x356B768 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356B770 Offset: 0x3567770 VA: 0x356B770 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356B7D8 Offset: 0x35677D8 VA: 0x356B7D8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356B934 Offset: 0x3567934 VA: 0x356B934
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetHighRaidTrophysResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(byte highRaidNo, Dictionary<byte, byte> trophys);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnInvalidOperationParameter();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnDataNull();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotBeHeld();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnSqlError();
}
