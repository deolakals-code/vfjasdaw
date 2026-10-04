// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class RefiningEquipmentExplain : OperationRelatedExplainBase // TypeDefIndex: 14952
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private short skillId; // 0x20
	private int itemUuid; // 0x24
	private int itemId; // 0x28
	private int supportItemId; // 0x2C
	private bool isDirectSupport; // 0x30
	private int orb; // 0x34

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3566A18 Offset: 0x3562A18 VA: 0x3566A18
	public void .ctor(int shopId, short[] position, int refineItemUuid, int oreItemId, int supportItemId, bool isDirect, int orb) { }

	// RVA: 0x3566A90 Offset: 0x3562A90 VA: 0x3566A90
	public void .ctor(int refineItemUuid, int oreItemId, int supportItemId, bool isDirect, int orb) { }

	// RVA: 0x3566AEC Offset: 0x3562AEC VA: 0x3566AEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3566AF4 Offset: 0x3562AF4 VA: 0x3566AF4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3566AFC Offset: 0x3562AFC VA: 0x3566AFC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3566B9C Offset: 0x3562B9C VA: 0x3566B9C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3566CF8 Offset: 0x3562CF8 VA: 0x3566CF8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, RefiningEquipmentResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(RefiningEquipmentResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
