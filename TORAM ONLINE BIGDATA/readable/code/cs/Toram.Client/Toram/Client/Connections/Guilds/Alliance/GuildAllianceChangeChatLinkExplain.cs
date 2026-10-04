// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceChangeChatLinkExplain : OperationRelatedExplainBase // TypeDefIndex: 15051
{
	// Fields
	private bool isChatLink; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3579130 Offset: 0x3575130 VA: 0x3579130
	public void .ctor(bool isChatLink) { }

	// RVA: 0x3579158 Offset: 0x3575158 VA: 0x3579158 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3579160 Offset: 0x3575160 VA: 0x3579160 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3579168 Offset: 0x3575168 VA: 0x3579168 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35791D0 Offset: 0x35751D0 VA: 0x35791D0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357932C Offset: 0x357532C VA: 0x357932C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildAllianceChangeChatLinkResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildAllianceChangeChatLinkResponse response);

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
	protected abstract void OnGuildDisposed();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnAllianceNotFound();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnFailure(short returnCode);
}
