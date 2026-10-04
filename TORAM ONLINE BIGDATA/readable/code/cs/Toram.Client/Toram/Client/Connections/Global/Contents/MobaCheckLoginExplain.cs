// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaCheckLoginExplain : OperationRelatedExplainBase // TypeDefIndex: 15064
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B580 Offset: 0x3577580 VA: 0x357B580
	public void .ctor() { }

	// RVA: 0x357B588 Offset: 0x3577588 VA: 0x357B588 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B590 Offset: 0x3577590 VA: 0x357B590 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B598 Offset: 0x3577598 VA: 0x357B598 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357B5A0 Offset: 0x35775A0 VA: 0x357B5A0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357B62C Offset: 0x357762C VA: 0x357B62C
	private GameReturnCode ReceiveResponse(short returnCode, MobaCheckLoginResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaCheckLoginResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNeedToLeave(short returnCode, MobaCheckLoginResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnUnsuccessfulNeedToLeave(short returnCode, MobaCheckLoginResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode, MobaCheckLoginResponse response);
}
