// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaLimitedSkillExplain : OperationRelatedExplainBase // TypeDefIndex: 15079
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C98C Offset: 0x357898C VA: 0x357C98C
	public void .ctor() { }

	// RVA: 0x357C994 Offset: 0x3578994 VA: 0x357C994 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C99C Offset: 0x357899C VA: 0x357C99C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C9A4 Offset: 0x35789A4 VA: 0x357C9A4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C9AC Offset: 0x35789AC VA: 0x357C9AC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaLimitedSkillResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
