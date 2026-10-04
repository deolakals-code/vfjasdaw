// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds
[CLSCompliant(False)]
public abstract class RoomEscapeVoteExplain : OperationRelatedExplainBase // TypeDefIndex: 15049
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3578E04 Offset: 0x3574E04 VA: 0x3578E04
	public void .ctor() { }

	// RVA: 0x3578E0C Offset: 0x3574E0C VA: 0x3578E0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3578E14 Offset: 0x3574E14 VA: 0x3578E14 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3578E1C Offset: 0x3574E1C VA: 0x3578E1C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3578E70 Offset: 0x3574E70 VA: 0x3578E70 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnErr_AlreadyExists();
}
