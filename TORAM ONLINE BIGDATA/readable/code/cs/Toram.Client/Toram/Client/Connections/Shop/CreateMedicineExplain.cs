// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class CreateMedicineExplain : OperationRelatedExplainBase // TypeDefIndex: 14948
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private short skillId; // 0x20
	private int recipeId; // 0x24
	private short itemNum; // 0x28

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3565BD0 Offset: 0x3561BD0 VA: 0x3565BD0
	public void .ctor(int shopId, short[] position, int recipeId, short createNum) { }

	// RVA: 0x3565C24 Offset: 0x3561C24 VA: 0x3565C24
	public void .ctor(int recipeId, short createNum) { }

	// RVA: 0x3565C5C Offset: 0x3561C5C VA: 0x3565C5C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3565C64 Offset: 0x3561C64 VA: 0x3565C64 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3565C6C Offset: 0x3561C6C VA: 0x3565C6C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3565CFC Offset: 0x3561CFC VA: 0x3565CFC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3565E58 Offset: 0x3561E58 VA: 0x3565E58
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CreateMedicineResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CreateMedicineResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
