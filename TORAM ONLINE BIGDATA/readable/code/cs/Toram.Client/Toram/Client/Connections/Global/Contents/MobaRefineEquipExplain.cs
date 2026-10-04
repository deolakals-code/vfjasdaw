// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaRefineEquipExplain : OperationRelatedExplainBase // TypeDefIndex: 15085
{
	// Fields
	private readonly byte equipType; // 0x10
	private readonly byte itemType; // 0x11
	private readonly byte refine; // 0x12
	private readonly int price; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D2B8 Offset: 0x35792B8 VA: 0x357D2B8
	public void .ctor(byte equipType, byte itemType, byte refine, int price) { }

	// RVA: 0x357D300 Offset: 0x3579300 VA: 0x357D300 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D308 Offset: 0x3579308 VA: 0x357D308 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D310 Offset: 0x3579310 VA: 0x357D310 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D390 Offset: 0x3579390 VA: 0x357D390 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357D41C Offset: 0x357941C VA: 0x357D41C
	private GameReturnCode ReceiveResponse(short returnCode, MobaRefineEquipResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaRefineEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnConditionsAreNotMet(MobaRefineEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMoneyNotEnough(MobaRefineEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnEquipNotFound(MobaRefineEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnRefineOrverLevel(MobaRefineEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode, MobaRefineEquipResponse response);
}
