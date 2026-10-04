// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetExhabitSaleExplain : OperationRelatedExplainBase // TypeDefIndex: 14983
{
	// Fields
	private byte no; // 0x10
	private int price; // 0x14
	private long petUuid; // 0x18
	private byte exhabitType; // 0x20
	private int password; // 0x24

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356D7A0 Offset: 0x35697A0 VA: 0x356D7A0
	public void .ctor(byte no, int price, long petUuid = 0, byte exhabitType = 0, int password = 0) { }

	// RVA: 0x356D7F8 Offset: 0x35697F8 VA: 0x356D7F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356D800 Offset: 0x3569800 VA: 0x356D800 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356D808 Offset: 0x3569808 VA: 0x356D808 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356D890 Offset: 0x3569890 VA: 0x356D890 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356D9EC Offset: 0x35699EC VA: 0x356D9EC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetExhabitSaleResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetExhabitSaleResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotLoaded();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotStopSale();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoChangePrice();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnExhabitTypeWrong();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnPasswordWrong();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
