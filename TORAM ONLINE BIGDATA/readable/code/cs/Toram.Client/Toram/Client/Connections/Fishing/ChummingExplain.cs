// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class ChummingExplain : OperationRelatedExplainBase // TypeDefIndex: 15097
{
	// Fields
	private int fieldId; // 0x10
	private byte chummingCount; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357E8B4 Offset: 0x357A8B4 VA: 0x357E8B4
	public void .ctor(int fieldId, byte chummingCount) { }

	// RVA: 0x357E8E4 Offset: 0x357A8E4 VA: 0x357E8E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357E8EC Offset: 0x357A8EC VA: 0x357E8EC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357E8F4 Offset: 0x357A8F4 VA: 0x357E8F4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357E964 Offset: 0x357A964 VA: 0x357E964 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357EAC0 Offset: 0x357AAC0 VA: 0x357EAC0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ChummingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ChummingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadyHit();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMoneyNotEnough();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
