// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaRespawnExplain : OperationRelatedExplainBase // TypeDefIndex: 15086
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D4C4 Offset: 0x35794C4 VA: 0x357D4C4
	public void .ctor() { }

	// RVA: 0x357D4CC Offset: 0x35794CC VA: 0x357D4CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D4D4 Offset: 0x35794D4 VA: 0x357D4D4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D4DC Offset: 0x35794DC VA: 0x357D4DC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D4E4 Offset: 0x35794E4 VA: 0x357D4E4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357D570 Offset: 0x3579570 VA: 0x357D570
	private GameReturnCode ReceiveResponse(short returnCode, MobaRespawnResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAvatarNotDeath(MobaRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnTimeIsNotOver(MobaRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNotGhostState(MobaRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnCompletedAlready(MobaRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode, MobaRespawnResponse response);
}
