// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Player
[CLSCompliant(False)]
public abstract class SpecificCristaRemoveExplain : OperationRelatedExplainBase // TypeDefIndex: 14933
{
	// Fields
	private readonly int targetItemUuid; // 0x10
	private readonly byte slotNo; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3563EAC Offset: 0x355FEAC VA: 0x3563EAC
	public void .ctor(int targetItemUuid, byte slotNo) { }

	// RVA: 0x3563EDC Offset: 0x355FEDC VA: 0x3563EDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3563EE4 Offset: 0x355FEE4 VA: 0x3563EE4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3563EEC Offset: 0x355FEEC VA: 0x3563EEC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3563F5C Offset: 0x355FF5C VA: 0x3563F5C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(SpecificCristaRemoveResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnWrong(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBagFull(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
