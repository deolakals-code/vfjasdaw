// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class StartFishingMiniGameExplain : OperationRelatedExplainBase // TypeDefIndex: 15101
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357F3CC Offset: 0x357B3CC VA: 0x357F3CC
	public void .ctor() { }

	// RVA: 0x357F3D4 Offset: 0x357B3D4 VA: 0x357F3D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357F3DC Offset: 0x357B3DC VA: 0x357F3DC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357F3E4 Offset: 0x357B3E4 VA: 0x357F3E4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357F3EC Offset: 0x357B3EC VA: 0x357F3EC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357F548 Offset: 0x357B548 VA: 0x357F548
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, StartFishingMiniGameResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(StartFishingMiniGameResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnDoNotFishing();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotHit();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
