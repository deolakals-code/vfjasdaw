// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaChestStartExplain : OperationRelatedExplainBase // TypeDefIndex: 15069
{
	// Fields
	private readonly int chestUniqueId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357BD40 Offset: 0x3577D40 VA: 0x357BD40
	public void .ctor(int chestUniqueId) { }

	// RVA: 0x357BD68 Offset: 0x3577D68 VA: 0x357BD68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357BD70 Offset: 0x3577D70 VA: 0x357BD70 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357BD78 Offset: 0x3577D78 VA: 0x357BD78 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357BDE0 Offset: 0x3577DE0 VA: 0x357BDE0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357BE6C Offset: 0x3577E6C VA: 0x357BE6C
	private GameReturnCode ReceiveResponse(short returnCode, MobaChestStartResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaChestStartResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaChestStartResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDead(MobaChestStartResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotFound(MobaChestStartResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnAlreadyOpened(MobaChestStartResponse response);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnRangeOutSideScope(MobaChestStartResponse response);
}
