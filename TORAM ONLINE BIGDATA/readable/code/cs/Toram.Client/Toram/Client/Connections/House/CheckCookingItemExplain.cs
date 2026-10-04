// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House
[CLSCompliant(False)]
public abstract class CheckCookingItemExplain : OperationRelatedExplainBase // TypeDefIndex: 14975
{
	// Fields
	private readonly List<int> mainCookingItems; // 0x10
	private readonly List<int> subCookingItems; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356BC50 Offset: 0x3567C50 VA: 0x356BC50
	public void .ctor(List<int> mainCookingItems, List<int> subCookingItems) { }

	// RVA: 0x356BC94 Offset: 0x3567C94 VA: 0x356BC94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356BC9C Offset: 0x3567C9C VA: 0x356BC9C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356BCA4 Offset: 0x3567CA4 VA: 0x356BCA4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356BD9C Offset: 0x3567D9C VA: 0x356BD9C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356BE4C Offset: 0x3567E4C VA: 0x356BE4C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HouseCheckCookingItemResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(HouseCheckCookingItemResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
