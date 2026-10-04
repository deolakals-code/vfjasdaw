// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Pet
[CLSCompliant(False)]
public abstract class HousePetGetPetSalesExplain : OperationRelatedExplainBase // TypeDefIndex: 14984
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356DBB0 Offset: 0x3569BB0 VA: 0x356DBB0
	public void .ctor() { }

	// RVA: 0x356DBB8 Offset: 0x3569BB8 VA: 0x356DBB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356DBC0 Offset: 0x3569BC0 VA: 0x356DBC0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356DBC8 Offset: 0x3569BC8 VA: 0x356DBC8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356DBD0 Offset: 0x3569BD0 VA: 0x356DBD0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356DD2C Offset: 0x3569D2C VA: 0x356DD2C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetGetSalesResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HousePetGetSalesResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
