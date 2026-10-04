// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop.SignBoard.Bazaar
[CLSCompliant(False)]
public abstract class ExpansionBazaarSlotExplain : OperationRelatedExplainBase // TypeDefIndex: 14962
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356903C Offset: 0x356503C VA: 0x356903C
	public void .ctor() { }

	// RVA: 0x3569044 Offset: 0x3565044 VA: 0x3569044 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356904C Offset: 0x356504C VA: 0x356904C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3569054 Offset: 0x3565054 VA: 0x3569054 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356905C Offset: 0x356505C VA: 0x356905C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35691B8 Offset: 0x35651B8 VA: 0x35691B8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ExpansionBazaarSlotResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ExpansionBazaarSlotResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBazaarSlotLimit();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMoneyNotEnough();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnPutupSignboard();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
