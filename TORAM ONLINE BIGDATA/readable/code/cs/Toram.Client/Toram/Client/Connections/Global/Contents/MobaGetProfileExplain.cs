// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaGetProfileExplain : OperationRelatedExplainBase // TypeDefIndex: 15073
{
	// Fields
	private readonly int appliId; // 0x10
	private readonly string appNumber; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C1D8 Offset: 0x35781D8 VA: 0x357C1D8
	public void .ctor(int appliId, string appNumber) { }

	// RVA: 0x357C210 Offset: 0x3578210 VA: 0x357C210 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C218 Offset: 0x3578218 VA: 0x357C218 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C220 Offset: 0x3578220 VA: 0x357C220 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C298 Offset: 0x3578298 VA: 0x357C298 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaGetProfileResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnVersionDifference();
}
