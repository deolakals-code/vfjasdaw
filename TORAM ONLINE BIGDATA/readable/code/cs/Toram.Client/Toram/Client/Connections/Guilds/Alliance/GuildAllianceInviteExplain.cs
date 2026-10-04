// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceInviteExplain : OperationRelatedExplainBase // TypeDefIndex: 15058
{
	// Fields
	private int targetArchetypeId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357A8EC Offset: 0x35768EC VA: 0x357A8EC
	public void .ctor(int targetArchetypeId) { }

	// RVA: 0x357A914 Offset: 0x3576914 VA: 0x357A914 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357A91C Offset: 0x357691C VA: 0x357A91C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357A924 Offset: 0x3576924 VA: 0x357A924 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357A98C Offset: 0x357698C VA: 0x357A98C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357AAE8 Offset: 0x3576AE8 VA: 0x357AAE8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildAllianceInviteResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildAllianceInviteResponse response);

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
	protected abstract void OnTargetUserNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnTargetUserDisposed();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnTargetUserNoAuthority();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnWrongTarget();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnGuildDisposed();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnTargetNotAllowed();

	// RVA: -1 Offset: -1 Slot: 23
	protected abstract void OnAllianceAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract void OnCoolDown();

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract void OnGuildNotFound();

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract void OnTargetAllianceAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract void OnTargetCoolDown();

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void OnInvitationAlreadyExists();

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void OnAllianceNotFound();

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void OnInvitationLimit();

	// RVA: -1 Offset: -1 Slot: 31
	protected abstract void OnFailure(short returnCode);
}
