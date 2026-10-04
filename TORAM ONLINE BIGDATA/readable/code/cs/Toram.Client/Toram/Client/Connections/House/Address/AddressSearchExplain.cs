// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Address
[CLSCompliant(False)]
public abstract class AddressSearchExplain : OperationRelatedExplainBase // TypeDefIndex: 15031
{
	// Fields
	private readonly int address; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35752E0 Offset: 0x35712E0 VA: 0x35752E0
	public void .ctor(int address) { }

	// RVA: 0x3575308 Offset: 0x3571308 VA: 0x3575308 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3575310 Offset: 0x3571310 VA: 0x3575310 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3575318 Offset: 0x3571318 VA: 0x3575318 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3575380 Offset: 0x3571380 VA: 0x3575380 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3575430 Offset: 0x3571430 VA: 0x3575430
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, AddressSearchResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(AddressSearchResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNumberWrong();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotFound();
}
