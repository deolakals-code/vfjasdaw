// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class ArmorRemodelingExplain : OperationRelatedExplainBase // TypeDefIndex: 14947
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private int itemUuid; // 0x20
	private byte custom; // 0x24

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3565870 Offset: 0x3561870 VA: 0x3565870
	public void .ctor(int shopId, short[] position, int customItemUuid, byte customType) { }

	// RVA: 0x35658C4 Offset: 0x35618C4 VA: 0x35658C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35658CC Offset: 0x35618CC VA: 0x35658CC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35658D4 Offset: 0x35618D4 VA: 0x35658D4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356595C Offset: 0x356195C VA: 0x356595C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3565AB8 Offset: 0x3561AB8 VA: 0x3565AB8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ArmorRemodelingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ArmorRemodelingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
