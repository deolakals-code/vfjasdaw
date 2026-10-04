// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaChestOpenExplain : OperationRelatedExplainBase // TypeDefIndex: 15068
{
	// Fields
	private readonly int chestUniqueId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357BB34 Offset: 0x3577B34 VA: 0x357BB34
	public void .ctor(int chestUniqueId) { }

	// RVA: 0x357BB5C Offset: 0x3577B5C VA: 0x357BB5C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357BB64 Offset: 0x3577B64 VA: 0x357BB64 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357BB6C Offset: 0x3577B6C VA: 0x357BB6C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357BBD4 Offset: 0x3577BD4 VA: 0x357BBD4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357BC60 Offset: 0x3577C60 VA: 0x357BC60
	private GameReturnCode ReceiveResponse(short returnCode, MobaChestOpenResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDead(MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotFound(MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnAlreadyOpened(MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnRangeOutSideScope(MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotTryingOpen(MobaChestOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnTimeIsNotOver(MobaChestOpenResponse response);
}
