// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class TransferRPExplain : OperationRelatedExplainBase // TypeDefIndex: 14957
{
	// Fields
	private int shopId; // 0x10
	private int targetItemUuid; // 0x14
	private int materialItemUuid; // 0x18
	private short[] useSupportList; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3567C30 Offset: 0x3563C30 VA: 0x3567C30
	public void .ctor(int shopId, int targetItemUuid, int materialItemUuid, short useMagicHammer, short useSuperMagicHammer, short useHyperMagicHammer, short useOrbMagicHammer) { }

	// RVA: 0x3567D14 Offset: 0x3563D14 VA: 0x3567D14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3567D1C Offset: 0x3563D1C VA: 0x3567D1C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3567D24 Offset: 0x3563D24 VA: 0x3567D24 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3567DA4 Offset: 0x3563DA4 VA: 0x3567DA4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3567F00 Offset: 0x3563F00 VA: 0x3567F00
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, TransferRandomPropertyResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(TransferRandomPropertyResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnRangeOutSideScope();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnShopNotSupport();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnItemNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnEquipAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnTypeWrong();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnMoneyNotEnough();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnUpperLimitValue();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnSupportItemNotAllowed();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnItemDbNotFound();

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void OnItemNotEnough();

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract void OnFailure(short returnCode);
}
