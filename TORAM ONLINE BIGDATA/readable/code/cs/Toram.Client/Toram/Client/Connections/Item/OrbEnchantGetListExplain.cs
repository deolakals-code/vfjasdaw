// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Item
[CLSCompliant(False)]
public abstract class OrbEnchantGetListExplain : OperationRelatedExplainBase // TypeDefIndex: 14930
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3563798 Offset: 0x355F798 VA: 0x3563798
	public void .ctor() { }

	// RVA: 0x35637A0 Offset: 0x355F7A0 VA: 0x35637A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35637A8 Offset: 0x355F7A8 VA: 0x35637A8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35637B0 Offset: 0x355F7B0 VA: 0x35637B0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35637B8 Offset: 0x355F7B8 VA: 0x35637B8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3563918 Offset: 0x355F918 VA: 0x3563918
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OrbEnchantGetListResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OrbEnchantGetListResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
