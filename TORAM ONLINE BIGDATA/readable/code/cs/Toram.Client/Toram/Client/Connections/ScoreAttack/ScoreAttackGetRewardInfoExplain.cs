// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.ScoreAttack
[CLSCompliant(False)]
public abstract class ScoreAttackGetRewardInfoExplain : OperationRelatedExplainBase // TypeDefIndex: 14925
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3562760 Offset: 0x355E760 VA: 0x3562760
	public void .ctor() { }

	// RVA: 0x3562768 Offset: 0x355E768 VA: 0x3562768 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3562770 Offset: 0x355E770 VA: 0x3562770 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3562778 Offset: 0x355E778 VA: 0x3562778 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3562780 Offset: 0x355E780 VA: 0x3562780 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35628DC Offset: 0x355E8DC VA: 0x35628DC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ScoreAttackGetRewardInfoResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ScoreAttackGetRewardInfoResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
