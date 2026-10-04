// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceConsentExplain : OperationRelatedExplainBase // TypeDefIndex: 15056
{
	// Fields
	private int allianceId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357A100 Offset: 0x3576100 VA: 0x357A100
	public void .ctor(int allianceId) { }

	// RVA: 0x357A128 Offset: 0x3576128 VA: 0x357A128 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357A130 Offset: 0x3576130 VA: 0x357A130 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357A138 Offset: 0x3576138 VA: 0x357A138 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357A1A0 Offset: 0x35761A0 VA: 0x357A1A0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357A2FC Offset: 0x35762FC VA: 0x357A2FC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildAllianceConsentResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildAllianceConsentResponse response);

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
	protected abstract void OnInfoNotFound();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnInviteNotFound();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnFailure(short returnCode);
}
