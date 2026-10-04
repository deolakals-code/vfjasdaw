// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds.Alliance
[CLSCompliant(False)]
public abstract class GuildAllianceGetStaffDataExplain : OperationRelatedExplainBase // TypeDefIndex: 15053
{
	// Fields
	private int guildId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35798F0 Offset: 0x35758F0 VA: 0x35798F0
	public void .ctor(int guildId) { }

	// RVA: 0x3579918 Offset: 0x3575918 VA: 0x3579918 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3579920 Offset: 0x3575920 VA: 0x3579920 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3579928 Offset: 0x3575928 VA: 0x3579928 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3579990 Offset: 0x3575990 VA: 0x3579990 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3579AEC Offset: 0x3575AEC VA: 0x3579AEC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildAllianceGetStaffDataResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildAllianceGetStaffDataResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnServerDisconnect();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnUserDisposed();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnGuildNotAccess();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnAllianceNotFound();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnInfoNotFound();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnFailure(short returnCode);
}
