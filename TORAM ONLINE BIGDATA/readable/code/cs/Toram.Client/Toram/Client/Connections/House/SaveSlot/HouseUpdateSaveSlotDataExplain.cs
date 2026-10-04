// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.SaveSlot
[CLSCompliant(False)]
public abstract class HouseUpdateSaveSlotDataExplain : OperationRelatedExplainBase // TypeDefIndex: 14978
{
	// Fields
	private readonly byte slotNo; // 0x10
	private readonly string memo; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356C698 Offset: 0x3568698 VA: 0x356C698
	public void .ctor(byte slotNo, string memo) { }

	// RVA: 0x356C6D0 Offset: 0x35686D0 VA: 0x356C6D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356C6D8 Offset: 0x35686D8 VA: 0x356C6D8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356C6E0 Offset: 0x35686E0 VA: 0x356C6E0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356C758 Offset: 0x3568758 VA: 0x356C758 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356C808 Offset: 0x3568808 VA: 0x356C808
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HouseUpdateSaveSlotDataResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HouseUpdateSaveSlotDataResponse response);

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
	protected abstract void OnStrLengthOver();
}
