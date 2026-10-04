// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.PaletteStorage
[CLSCompliant(False)]
public abstract class CreateColoringEquipExplain : OperationRelatedExplainBase // TypeDefIndex: 14965
{
	// Fields
	private short itemType; // 0x10
	private byte[] color; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35698E4 Offset: 0x35658E4 VA: 0x35698E4
	public void .ctor(short itemType, byte[] color) { }

	// RVA: 0x356991C Offset: 0x356591C VA: 0x356991C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3569924 Offset: 0x3565924 VA: 0x3569924 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356992C Offset: 0x356592C VA: 0x356992C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35699A4 Offset: 0x35659A4 VA: 0x35699A4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3569B00 Offset: 0x3565B00 VA: 0x3569B00
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CreateColoringEquipResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CreateColoringEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnBagItemIsFull();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnItemTypeNotAllowed();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnPaletteDataNull();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNoColor();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnSynthesizeEquipOver();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnItemDbNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnColorNotEnough();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnFailure(short returnCode);
}
