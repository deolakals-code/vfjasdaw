// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaStatusExplain : OperationRelatedExplainBase // TypeDefIndex: 15093
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357DEA8 Offset: 0x3579EA8 VA: 0x357DEA8
	public void .ctor() { }

	// RVA: 0x357DEB0 Offset: 0x3579EB0 VA: 0x357DEB0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357DEB8 Offset: 0x3579EB8 VA: 0x357DEB8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357DEC0 Offset: 0x3579EC0 VA: 0x357DEC0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357DEC8 Offset: 0x3579EC8 VA: 0x357DEC8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357DF54 Offset: 0x3579F54 VA: 0x357DF54
	private GameReturnCode ReceiveResponse(short returnCode, MobaStatusResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnProfileNotRegistered();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnCancelRequested(short returnCode, MobaStatusResponse response);
}
