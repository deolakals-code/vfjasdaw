// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaChestCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15067
{
	// Fields
	private readonly int chestUniqueId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B9B0 Offset: 0x35779B0 VA: 0x357B9B0
	public void .ctor(int chestUniqueId) { }

	// RVA: 0x357B9D8 Offset: 0x35779D8 VA: 0x357B9D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B9E0 Offset: 0x35779E0 VA: 0x357B9E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B9E8 Offset: 0x35779E8 VA: 0x357B9E8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357BA50 Offset: 0x3577A50 VA: 0x357BA50 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357BADC Offset: 0x3577ADC VA: 0x357BADC
	private GameReturnCode ReceiveResponse(short returnCode, MobaChestCancelResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaChestCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode, MobaChestCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotFound(MobaChestCancelResponse response);
}
