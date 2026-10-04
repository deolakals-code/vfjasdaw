// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaItemDropExplain : OperationRelatedExplainBase // TypeDefIndex: 15075
{
	// Fields
	private readonly byte equipNo; // 0x10
	private readonly short itemId; // 0x12

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C48C Offset: 0x357848C VA: 0x357C48C
	public void .ctor(byte equipNo, short itemId) { }

	// RVA: 0x357C4BC Offset: 0x35784BC VA: 0x357C4BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C4C4 Offset: 0x35784C4 VA: 0x357C4C4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C4CC Offset: 0x35784CC VA: 0x357C4CC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C53C Offset: 0x357853C VA: 0x357C53C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357C5C8 Offset: 0x35785C8 VA: 0x357C5C8
	private GameReturnCode ReceiveResponse(short returnCode, MobaItemDropResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaItemDropResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaItemDropResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDead(MobaItemDropResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnWrongTarget(MobaItemDropResponse response);
}
