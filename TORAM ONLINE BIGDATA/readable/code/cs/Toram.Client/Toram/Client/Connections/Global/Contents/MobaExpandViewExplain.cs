// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaExpandViewExplain : OperationRelatedExplainBase // TypeDefIndex: 15071
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C058 Offset: 0x3578058 VA: 0x357C058
	public void .ctor() { }

	// RVA: 0x357C060 Offset: 0x3578060 VA: 0x357C060 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C068 Offset: 0x3578068 VA: 0x357C068 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C070 Offset: 0x3578070 VA: 0x357C070 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C078 Offset: 0x3578078 VA: 0x357C078 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowedPhase();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
