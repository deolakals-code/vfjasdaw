// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaItemPickupExplain : OperationRelatedExplainBase // TypeDefIndex: 15076
{
	// Fields
	private readonly byte equipNo; // 0x10
	private readonly int itemUniqueId; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357C638 Offset: 0x3578638 VA: 0x357C638
	public void .ctor(byte equipNo, int itemUniqueId) { }

	// RVA: 0x357C668 Offset: 0x3578668 VA: 0x357C668 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357C670 Offset: 0x3578670 VA: 0x357C670 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357C678 Offset: 0x3578678 VA: 0x357C678 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357C6E8 Offset: 0x35786E8 VA: 0x357C6E8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357C774 Offset: 0x3578774 VA: 0x357C774
	private GameReturnCode ReceiveResponse(short returnCode, MobaItemPickupResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaItemPickupResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaItemPickupResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDead(MobaItemPickupResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnDropNotFound(MobaItemPickupResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnRangeOutSideScope(MobaItemPickupResponse response);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnWrongTarget(MobaItemPickupResponse response);
}
