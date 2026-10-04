// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetStopSaleExplain : OperationRelatedExplainBase // TypeDefIndex: 14987
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356E4B0 Offset: 0x356A4B0 VA: 0x356E4B0
	public void .ctor() { }

	// RVA: 0x356E4B8 Offset: 0x356A4B8 VA: 0x356E4B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356E4C0 Offset: 0x356A4C0 VA: 0x356E4C0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356E4C8 Offset: 0x356A4C8 VA: 0x356E4C8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356E4D0 Offset: 0x356A4D0 VA: 0x356E4D0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356E62C Offset: 0x356A62C VA: 0x356E62C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetStopSaleResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetStopSaleResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
