// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class CreateFishingRodExplain : OperationRelatedExplainBase // TypeDefIndex: 15105
{
	// Fields
	private byte index; // 0x10
	private MaterialData[] materialList; // 0x18
	private bool isSuccession; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357FF9C Offset: 0x357BF9C VA: 0x357FF9C
	public void .ctor(byte index, MaterialData[] materialList, bool isSuccession) { }

	// RVA: 0x357FFE8 Offset: 0x357BFE8 VA: 0x357FFE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357FFF0 Offset: 0x357BFF0 VA: 0x357FFF0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357FFF8 Offset: 0x357BFF8 VA: 0x357FFF8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3580078 Offset: 0x357C078 VA: 0x3580078 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35801D4 Offset: 0x357C1D4 VA: 0x35801D4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CreateFishingRodResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CreateFishingRodResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnIndexOutOfRange();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMaterialWrong();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMaterialNotEnough();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
