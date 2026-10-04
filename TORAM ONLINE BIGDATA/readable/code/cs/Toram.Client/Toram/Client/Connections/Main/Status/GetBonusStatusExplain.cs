// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Main.Status
[CLSCompliant(False)]
public abstract class GetBonusStatusExplain : OperationRelatedExplainBase // TypeDefIndex: 14970
{
	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x356A774 Offset: 0x3566774 VA: 0x356A774
	public void .ctor() { }

	// RVA: 0x356A77C Offset: 0x356677C VA: 0x356A77C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356A784 Offset: 0x3566784 VA: 0x356A784 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356A78C Offset: 0x356678C VA: 0x356A78C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356A8E8 Offset: 0x35668E8 VA: 0x356A8E8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetBonusStatusResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetBonusStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
