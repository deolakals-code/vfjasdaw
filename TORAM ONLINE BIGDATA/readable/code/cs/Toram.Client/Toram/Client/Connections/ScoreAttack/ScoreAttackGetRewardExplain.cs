// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.ScoreAttack
[CLSCompliant(False)]
public abstract class ScoreAttackGetRewardExplain : OperationRelatedExplainBase // TypeDefIndex: 14926
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

	// RVA: 0x35629F4 Offset: 0x355E9F4 VA: 0x35629F4
	public void .ctor(byte week, byte rotationId, byte bossId, byte rankingType) { }

	// RVA: 0x3562A3C Offset: 0x355EA3C VA: 0x3562A3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3562A44 Offset: 0x355EA44 VA: 0x3562A44 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3562A4C Offset: 0x355EA4C VA: 0x3562A4C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3562ACC Offset: 0x355EACC VA: 0x3562ACC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3562C28 Offset: 0x355EC28 VA: 0x3562C28
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ScoreAttackGetRewardResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ScoreAttackGetRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnCalculatingPeriod();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnDifferenceInformation();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
