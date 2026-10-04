// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetCancelExhabitSaleExplain : OperationRelatedExplainBase // TypeDefIndex: 14982
{
	// Fields
	private byte no; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356D418 Offset: 0x3569418 VA: 0x356D418
	public void .ctor(byte no) { }

	// RVA: 0x356D440 Offset: 0x3569440 VA: 0x356D440 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356D448 Offset: 0x3569448 VA: 0x356D448 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356D450 Offset: 0x3569450 VA: 0x356D450 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356D4B8 Offset: 0x35694B8 VA: 0x356D4B8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356D614 Offset: 0x3569614 VA: 0x356D614
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetCancelExhabitSaleResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetCancelExhabitSaleResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotLoaded();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotStopSale();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnPetStorageNoVacancies();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
