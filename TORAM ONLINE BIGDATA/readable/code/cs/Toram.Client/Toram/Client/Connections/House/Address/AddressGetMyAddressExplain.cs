// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Address
[CLSCompliant(False)]
public abstract class AddressGetMyAddressExplain : OperationRelatedExplainBase // TypeDefIndex: 15030
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3575060 Offset: 0x3571060 VA: 0x3575060
	public void .ctor() { }

	// RVA: 0x3575068 Offset: 0x3571068 VA: 0x3575068 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3575070 Offset: 0x3571070 VA: 0x3575070 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3575078 Offset: 0x3571078 VA: 0x3575078 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35750CC Offset: 0x35710CC VA: 0x35750CC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357517C Offset: 0x357117C VA: 0x357517C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, AddressGetMyAddressResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(AddressGetMyAddressResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();
}
