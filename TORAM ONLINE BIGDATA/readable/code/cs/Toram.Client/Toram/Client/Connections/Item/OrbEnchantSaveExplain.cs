// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Item
[CLSCompliant(False)]
public abstract class OrbEnchantSaveExplain : OperationRelatedExplainBase // TypeDefIndex: 14931
{
	// Fields
	private readonly int targetItemUuid; // 0x10
	private readonly byte targetType; // 0x14
	private readonly byte index; // 0x15

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3563954 Offset: 0x355F954 VA: 0x3563954
	public void .ctor(int targetItemUuid, byte targetType, byte index) { }

	// RVA: 0x3563994 Offset: 0x355F994 VA: 0x3563994 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356399C Offset: 0x355F99C VA: 0x356399C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35639A4 Offset: 0x355F9A4 VA: 0x35639A4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3563A1C Offset: 0x355FA1C VA: 0x3563A1C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3563B70 Offset: 0x355FB70 VA: 0x3563B70
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OrbEnchantSaveResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OrbEnchantSaveResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnWrong();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
