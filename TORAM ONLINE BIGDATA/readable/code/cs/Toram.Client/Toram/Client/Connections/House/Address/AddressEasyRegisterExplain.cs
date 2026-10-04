// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Address
[CLSCompliant(False)]
public abstract class AddressEasyRegisterExplain : OperationRelatedExplainBase // TypeDefIndex: 15033
{
	// Fields
	private readonly byte town; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3575874 Offset: 0x3571874 VA: 0x3575874
	public void .ctor(byte town) { }

	// RVA: 0x357589C Offset: 0x357189C VA: 0x357589C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35758A4 Offset: 0x35718A4 VA: 0x35758A4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35758AC Offset: 0x35718AC VA: 0x35758AC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3575914 Offset: 0x3571914 VA: 0x3575914 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35759C4 Offset: 0x35719C4 VA: 0x35759C4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, AddressEasyRegisterResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(AddressEasyRegisterResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnServerDisconnect();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnNumberWrong();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnDoNotNeed();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnNotReadyToRun();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnUserNotFound();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnDataNull();

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void OnFloorNotFound();

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract void OnAlreadyExists();
}
