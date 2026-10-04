// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Fishing
[CLSCompliant(False)]
public abstract class ResultFishingMiniGameExplain : OperationRelatedExplainBase // TypeDefIndex: 15099
{
	// Fields
	private bool isSuccess; // 0x10
	private int[] hitLogs; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357ED90 Offset: 0x357AD90 VA: 0x357ED90
	public void .ctor(bool isSuccess, int[] hitLogs) { }

	// RVA: 0x357EDC8 Offset: 0x357ADC8 VA: 0x357EDC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357EDD0 Offset: 0x357ADD0 VA: 0x357EDD0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357EDD8 Offset: 0x357ADD8 VA: 0x357EDD8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357EE50 Offset: 0x357AE50 VA: 0x357EE50 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357EFAC Offset: 0x357AFAC VA: 0x357EFAC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ResultFishingMiniGameResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ResultFishingMiniGameResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotHit();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotStartMiniGame();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBagIsFull();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFishNotFound();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
