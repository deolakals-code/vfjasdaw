// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.ScoreAttack
[CLSCompliant(False)]
public abstract class ScoreAttackGetRankingExplain : OperationRelatedExplainBase // TypeDefIndex: 14927
{
	// Fields
	private byte week; // 0x10
	private byte rotationId; // 0x11
	private byte bossId; // 0x12
	private byte rankingType; // 0x13

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3562D90 Offset: 0x355ED90 VA: 0x3562D90
	public void .ctor(byte week, byte rotationId, byte bossId, byte rankingType) { }

	// RVA: 0x3562DD8 Offset: 0x355EDD8 VA: 0x3562DD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3562DE0 Offset: 0x355EDE0 VA: 0x3562DE0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3562DE8 Offset: 0x355EDE8 VA: 0x3562DE8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3562E68 Offset: 0x355EE68 VA: 0x3562E68 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3562FC4 Offset: 0x355EFC4 VA: 0x3562FC4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ScoreAttackGetRankingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ScoreAttackGetRankingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnCalculatingPeriod();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDifferenceInformation();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
