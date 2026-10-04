// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class GetHuntingOneExplain : OperationRelatedExplainBase // TypeDefIndex: 14916
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35610EC Offset: 0x355D0EC VA: 0x35610EC
	public void .ctor() { }

	// RVA: 0x35610F4 Offset: 0x355D0F4 VA: 0x35610F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35610FC Offset: 0x355D0FC VA: 0x35610FC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3561104 Offset: 0x355D104 VA: 0x3561104 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356110C Offset: 0x355D10C VA: 0x356110C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356126C Offset: 0x355D26C VA: 0x356126C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetHuntingOneResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetHuntingOneResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
