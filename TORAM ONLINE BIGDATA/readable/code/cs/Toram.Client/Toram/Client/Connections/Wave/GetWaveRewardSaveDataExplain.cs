// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Wave
[CLSCompliant(False)]
public abstract class GetWaveRewardSaveDataExplain : OperationRelatedExplainBase // TypeDefIndex: 14903
{
	// Fields
	private readonly int fieldId; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x355F874 Offset: 0x355B874 VA: 0x355F874
	public void .ctor(int fieldId) { }

	// RVA: 0x355F89C Offset: 0x355B89C VA: 0x355F89C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x355F8A4 Offset: 0x355B8A4 VA: 0x355F8A4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x355F8AC Offset: 0x355B8AC VA: 0x355F8AC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x355F914 Offset: 0x355B914 VA: 0x355F914 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x355F9C4 Offset: 0x355B9C4 VA: 0x355F9C4
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetWaveRewardSaveDataResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetWaveRewardSaveDataResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();
}
