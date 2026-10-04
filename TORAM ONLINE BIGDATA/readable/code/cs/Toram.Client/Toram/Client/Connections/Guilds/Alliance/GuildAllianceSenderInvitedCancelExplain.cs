// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceSenderInvitedCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15055
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3579EC0 Offset: 0x3575EC0 VA: 0x3579EC0
	public void .ctor() { }

	// RVA: 0x3579EC8 Offset: 0x3575EC8 VA: 0x3579EC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3579ED0 Offset: 0x3575ED0 VA: 0x3579ED0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3579ED8 Offset: 0x3575ED8 VA: 0x3579ED8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3579EE0 Offset: 0x3575EE0 VA: 0x3579EE0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3579EF8 Offset: 0x3575EF8 VA: 0x3579EF8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnServerDisconnect();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoAuthority();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnUserDisposed();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnGuildNotAccess();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnAllianceNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnAllianceDisposed();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnAllianceAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnAllianceInstanceNotMatch();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnFailure(short returnCode);
}
