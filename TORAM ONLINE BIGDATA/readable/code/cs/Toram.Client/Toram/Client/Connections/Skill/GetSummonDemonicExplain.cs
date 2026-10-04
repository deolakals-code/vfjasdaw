// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class GetSummonDemonicExplain : OperationRelatedExplainBase // TypeDefIndex: 14918
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3561514 Offset: 0x355D514 VA: 0x3561514
	public void .ctor() { }

	// RVA: 0x356151C Offset: 0x355D51C VA: 0x356151C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3561524 Offset: 0x355D524 VA: 0x3561524 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356152C Offset: 0x355D52C VA: 0x356152C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3561534 Offset: 0x355D534 VA: 0x3561534 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3561694 Offset: 0x355D694 VA: 0x3561694
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetSummonDemonicResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetSummonDemonicResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
