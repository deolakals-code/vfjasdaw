// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Item
[CLSCompliant(False)]
public abstract class OrbReEnchantExplain : OperationRelatedExplainBase // TypeDefIndex: 14932
{
	// Fields
	private readonly int targetItemUuid; // 0x10
	private readonly byte targetType; // 0x14
	private readonly byte enchantIndex; // 0x15

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3563C00 Offset: 0x355FC00 VA: 0x3563C00
	public void .ctor(int targetItemUuid, byte targetType, byte enchantIndex) { }

	// RVA: 0x3563C40 Offset: 0x355FC40 VA: 0x3563C40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3563C48 Offset: 0x355FC48 VA: 0x3563C48 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3563C50 Offset: 0x355FC50 VA: 0x3563C50 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3563CC8 Offset: 0x355FCC8 VA: 0x3563CC8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3563E1C Offset: 0x355FE1C VA: 0x3563E1C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, OrbReEnchantResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OrbReEnchantResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnWrong();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
