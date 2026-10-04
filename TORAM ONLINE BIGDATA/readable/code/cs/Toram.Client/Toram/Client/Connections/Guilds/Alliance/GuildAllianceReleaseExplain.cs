// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceReleaseExplain : OperationRelatedExplainBase // TypeDefIndex: 15054
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3579CB0 Offset: 0x3575CB0 VA: 0x3579CB0
	public void .ctor() { }

	// RVA: 0x3579CB8 Offset: 0x3575CB8 VA: 0x3579CB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3579CC0 Offset: 0x3575CC0 VA: 0x3579CC0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3579CC8 Offset: 0x3575CC8 VA: 0x3579CC8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3579CD0 Offset: 0x3575CD0 VA: 0x3579CD0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3579CE8 Offset: 0x3575CE8 VA: 0x3579CE8
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
	protected abstract void OnFailure(short returnCode);
}
