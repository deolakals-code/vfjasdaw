// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceInviteCancelExplain : OperationRelatedExplainBase // TypeDefIndex: 15057
{
	// Fields
	private int allianceId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357A52C Offset: 0x357652C VA: 0x357A52C
	public void .ctor(int allianceId) { }

	// RVA: 0x357A554 Offset: 0x3576554 VA: 0x357A554 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357A55C Offset: 0x357655C VA: 0x357A55C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357A564 Offset: 0x3576564 VA: 0x357A564 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357A5CC Offset: 0x35765CC VA: 0x357A5CC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357A728 Offset: 0x3576728 VA: 0x357A728
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildAllianceInviteCancelResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildAllianceInviteCancelResponse response);

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
	protected abstract void OnInviteNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
