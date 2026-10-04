// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class EquipmentProductionExplain : OperationRelatedExplainBase // TypeDefIndex: 14950
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private short skillId; // 0x20
	private int recipeId; // 0x24

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35662D0 Offset: 0x35622D0 VA: 0x35662D0
	public void .ctor(int shopId, short[] position, int recipeId) { }

	// RVA: 0x356631C Offset: 0x356231C VA: 0x356631C
	public void .ctor(int recipeId) { }

	// RVA: 0x356634C Offset: 0x356234C VA: 0x356634C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3566354 Offset: 0x3562354 VA: 0x3566354 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356635C Offset: 0x356235C VA: 0x356635C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35663E4 Offset: 0x35623E4 VA: 0x35663E4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3566540 Offset: 0x3562540 VA: 0x3566540
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, EquipmentProductionResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(EquipmentProductionResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
