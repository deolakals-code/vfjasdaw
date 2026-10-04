// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Address
[CLSCompliant(False)]
public abstract class AddressDeleteExplain : OperationRelatedExplainBase // TypeDefIndex: 15032
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35755D0 Offset: 0x35715D0 VA: 0x35755D0
	public void .ctor() { }

	// RVA: 0x35755D8 Offset: 0x35715D8 VA: 0x35755D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35755E0 Offset: 0x35715E0 VA: 0x35755E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35755E8 Offset: 0x35715E8 VA: 0x35755E8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357563C Offset: 0x357163C VA: 0x357563C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35756EC Offset: 0x35716EC VA: 0x35756EC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, AddressDeleteResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(AddressDeleteResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNoSetup();
}
