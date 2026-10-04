// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.ScoreAttack
[CLSCompliant(False)]
public abstract class EnterScoreAttackHallExplain : OperationRelatedExplainBase // TypeDefIndex: 14924
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35625F0 Offset: 0x355E5F0 VA: 0x35625F0
	public void .ctor() { }

	// RVA: 0x35625F8 Offset: 0x355E5F8 VA: 0x35625F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3562600 Offset: 0x355E600 VA: 0x3562600 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3562608 Offset: 0x355E608 VA: 0x3562608 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3562610 Offset: 0x355E610 VA: 0x3562610 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3562628 Offset: 0x355E628 VA: 0x3562628
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotEnoughAccountProgress();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
