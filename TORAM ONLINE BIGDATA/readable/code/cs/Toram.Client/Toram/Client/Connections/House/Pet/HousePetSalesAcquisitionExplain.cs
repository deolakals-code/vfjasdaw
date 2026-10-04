// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetSalesAcquisitionExplain : OperationRelatedExplainBase // TypeDefIndex: 14985
{
	// Fields
	private int gold; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356DE44 Offset: 0x3569E44 VA: 0x356DE44
	public void .ctor(int gold) { }

	// RVA: 0x356DE6C Offset: 0x3569E6C VA: 0x356DE6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356DE74 Offset: 0x3569E74 VA: 0x356DE74 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356DE7C Offset: 0x3569E7C VA: 0x356DE7C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356DEE4 Offset: 0x3569EE4 VA: 0x356DEE4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356E040 Offset: 0x356A040 VA: 0x356E040
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetSalesAcquisitionResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetSalesAcquisitionResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotLoaded();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotStopSale();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMoneyLimit();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnSalesNotEnough();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
