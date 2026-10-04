// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Wave
[CLSCompliant(False)]
public abstract class GetWaveRewardExplain : OperationRelatedExplainBase // TypeDefIndex: 14904
{
	// Fields
	private readonly int fieldId; // 0x10
	private readonly byte waveNo; // 0x14
	private readonly byte index; // 0x15

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x355FB0C Offset: 0x355BB0C VA: 0x355FB0C
	public void .ctor(int fieldId, byte waveNo, byte index) { }

	// RVA: 0x355FB4C Offset: 0x355BB4C VA: 0x355FB4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x355FB54 Offset: 0x355BB54 VA: 0x355FB54 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x355FB5C Offset: 0x355BB5C VA: 0x355FB5C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x355FBD4 Offset: 0x355BBD4 VA: 0x355FBD4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x355FC84 Offset: 0x355BC84 VA: 0x355FC84
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetWaveRewardResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetWaveRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();
}
