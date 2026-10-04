// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Guilds
[CLSCompliant(False)]
public abstract class GuildOpenBgmExplain : OperationRelatedExplainBase // TypeDefIndex: 15048
{
	// Fields
	private short recipeId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3578A7C Offset: 0x3574A7C VA: 0x3578A7C
	public void .ctor(short recipeId) { }

	// RVA: 0x3578AA4 Offset: 0x3574AA4 VA: 0x3578AA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3578AAC Offset: 0x3574AAC VA: 0x3578AAC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3578AB4 Offset: 0x3574AB4 VA: 0x3578AB4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3578B1C Offset: 0x3574B1C VA: 0x3578B1C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3578C78 Offset: 0x3574C78 VA: 0x3578C78
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GuildOpenBgmResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GuildOpenBgmResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadyOpened();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNoAuthority();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGuildNotJoined();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnMaterialNotEnough();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
