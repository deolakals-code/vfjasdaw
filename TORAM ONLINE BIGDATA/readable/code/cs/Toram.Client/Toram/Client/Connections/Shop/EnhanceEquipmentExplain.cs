// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class EnhanceEquipmentExplain : OperationRelatedExplainBase // TypeDefIndex: 14949
{
	// Fields
	private int itemUuid; // 0x10
	private short[] itemPropertyS; // 0x18
	private short[] itemPropertyValue; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3565F70 Offset: 0x3561F70 VA: 0x3565F70
	public void .ctor(int itemUuid, short[] property, short[] propertyValue) { }

	// RVA: 0x3565FC4 Offset: 0x3561FC4 VA: 0x3565FC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3565FCC Offset: 0x3561FCC VA: 0x3565FCC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3565FD4 Offset: 0x3561FD4 VA: 0x3565FD4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356605C Offset: 0x356205C VA: 0x356605C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35661B8 Offset: 0x35621B8 VA: 0x35661B8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, EnhanceEquipmentResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(EnhanceEquipmentResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
