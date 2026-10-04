// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Address
[CLSCompliant(False)]
public abstract class AddressUpdateExplain : OperationRelatedExplainBase // TypeDefIndex: 15034
{
	// Fields
	private readonly int address; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3575D38 Offset: 0x3571D38 VA: 0x3575D38
	public void .ctor(int address) { }

	// RVA: 0x3575D60 Offset: 0x3571D60 VA: 0x3575D60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3575D68 Offset: 0x3571D68 VA: 0x3575D68 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3575D70 Offset: 0x3571D70 VA: 0x3575D70 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3575DD8 Offset: 0x3571DD8 VA: 0x3575DD8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3575E88 Offset: 0x3571E88 VA: 0x3575E88
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, AddressUpdateResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(AddressUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNumberWrong();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnNotReadyToRun();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnDoNotNeed();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnAlreadyExists();
}
