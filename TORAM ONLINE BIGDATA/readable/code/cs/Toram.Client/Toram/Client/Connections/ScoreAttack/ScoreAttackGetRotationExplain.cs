// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.ScoreAttack
[CLSCompliant(False)]
public abstract class ScoreAttackGetRotationExplain : OperationRelatedExplainBase // TypeDefIndex: 14928
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356312C Offset: 0x355F12C VA: 0x356312C
	public void .ctor() { }

	// RVA: 0x3563134 Offset: 0x355F134 VA: 0x3563134 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356313C Offset: 0x355F13C VA: 0x356313C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3563144 Offset: 0x355F144 VA: 0x3563144 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356314C Offset: 0x355F14C VA: 0x356314C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35632A8 Offset: 0x355F2A8 VA: 0x35632A8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ScoreAttackGetRotationResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ScoreAttackGetRotationResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotEnoughAccountProgress();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
