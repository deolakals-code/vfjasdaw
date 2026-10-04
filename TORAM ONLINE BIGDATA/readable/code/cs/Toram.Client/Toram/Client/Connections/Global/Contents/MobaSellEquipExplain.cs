// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaSellEquipExplain : OperationRelatedExplainBase // TypeDefIndex: 15091
{
	// Fields
	private readonly byte equipType; // 0x10
	private readonly byte itemType; // 0x11
	private readonly int price; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357DB08 Offset: 0x3579B08 VA: 0x357DB08
	public void .ctor(byte equipType, byte itemType, int price) { }

	// RVA: 0x357DB48 Offset: 0x3579B48 VA: 0x357DB48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357DB50 Offset: 0x3579B50 VA: 0x357DB50 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357DB58 Offset: 0x3579B58 VA: 0x357DB58 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357DBD0 Offset: 0x3579BD0 VA: 0x357DBD0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357DC5C Offset: 0x3579C5C VA: 0x357DC5C
	private GameReturnCode ReceiveResponse(short returnCode, MobaSellEquipResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaSellEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnConditionsAreNotMet(MobaSellEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMoneyNotEnough(MobaSellEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnEquipNotFound(MobaSellEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode, MobaSellEquipResponse response);
}
