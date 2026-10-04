// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetBuyExplain : OperationRelatedExplainBase // TypeDefIndex: 14981
{
	// Fields
	private byte no; // 0x10
	private int password; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356D048 Offset: 0x3569048 VA: 0x356D048
	public void .ctor(byte no, int password = 0) { }

	// RVA: 0x356D078 Offset: 0x3569078 VA: 0x356D078 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356D080 Offset: 0x3569080 VA: 0x356D080 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356D088 Offset: 0x3569088 VA: 0x356D088 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356D0F8 Offset: 0x35690F8 VA: 0x356D0F8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356D254 Offset: 0x3569254 VA: 0x356D254
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetBuyResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetBuyResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotSale();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnPetNotFound();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnPetStorageNoVacancies();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotMatch();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnPasswordWrong();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
