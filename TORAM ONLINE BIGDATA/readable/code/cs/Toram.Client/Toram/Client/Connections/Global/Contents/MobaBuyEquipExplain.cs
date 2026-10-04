// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaBuyEquipExplain : OperationRelatedExplainBase // TypeDefIndex: 15061
{
	// Fields
	private readonly byte equipType; // 0x10
	private readonly byte itemType; // 0x11
	private readonly int atk; // 0x14
	private readonly int price; // 0x18
	private readonly bool isUpdate; // 0x1C

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357B0D8 Offset: 0x35770D8 VA: 0x357B0D8
	public void .ctor(byte equipType, byte itemType, int atk, int price, bool isUpdate) { }

	// RVA: 0x357B12C Offset: 0x357712C VA: 0x357B12C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357B134 Offset: 0x3577134 VA: 0x357B134 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357B13C Offset: 0x357713C VA: 0x357B13C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357B1BC Offset: 0x35771BC VA: 0x357B1BC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357B248 Offset: 0x3577248 VA: 0x357B248
	private GameReturnCode ReceiveResponse(short returnCode, MobaBuyEquipResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaBuyEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnConditionsAreNotMet(MobaBuyEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMoneyNotEnough(MobaBuyEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnEquipAlreadyExists(MobaBuyEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnEquipNotFound(MobaBuyEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode, MobaBuyEquipResponse response);
}
