// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.SaveSlot
[CLSCompliant(False)]
public abstract class HouseChangeSaveSlotExplain : OperationRelatedExplainBase // TypeDefIndex: 14979
{
	// Fields
	private readonly byte slotNo; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356CA10 Offset: 0x3568A10 VA: 0x356CA10
	public void .ctor(byte slotNo) { }

	// RVA: 0x356CA38 Offset: 0x3568A38 VA: 0x356CA38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356CA40 Offset: 0x3568A40 VA: 0x356CA40 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356CA48 Offset: 0x3568A48 VA: 0x356CA48 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356CAB0 Offset: 0x3568AB0 VA: 0x356CAB0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356CB60 Offset: 0x3568B60 VA: 0x356CB60
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HouseChangeSaveSlotResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HouseChangeSaveSlotResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnHouseDisposed();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnHouseNotReading();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnHouseNotEdit();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnNotReadyToRun();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnHouseNotBuild();
}
