// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetStartSaleExplain : OperationRelatedExplainBase // TypeDefIndex: 14986
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356E1CC Offset: 0x356A1CC VA: 0x356E1CC
	public void .ctor() { }

	// RVA: 0x356E1D4 Offset: 0x356A1D4 VA: 0x356E1D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356E1DC Offset: 0x356A1DC VA: 0x356E1DC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356E1E4 Offset: 0x356A1E4 VA: 0x356E1E4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356E1EC Offset: 0x356A1EC VA: 0x356E1EC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356E348 Offset: 0x356A348 VA: 0x356E348
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetStartSaleResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetStartSaleResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotLoaded();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadySale();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
