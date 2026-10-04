// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class DiscardFishingRodExplain : OperationRelatedExplainBase // TypeDefIndex: 15095
{
	// Fields
	private byte index; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357E1C8 Offset: 0x357A1C8 VA: 0x357E1C8
	public void .ctor(byte index) { }

	// RVA: 0x357E1F0 Offset: 0x357A1F0 VA: 0x357E1F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357E1F8 Offset: 0x357A1F8 VA: 0x357E1F8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357E200 Offset: 0x357A200 VA: 0x357E200 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357E268 Offset: 0x357A268 VA: 0x357E268 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357E3C4 Offset: 0x357A3C4 VA: 0x357E3C4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, DiscardFishingRodResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(DiscardFishingRodResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnIndexOutOfRange();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnRodNotFound();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
