// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.HighRaid
[CLSCompliant(False)]
public abstract class GetHighRaidTrophyRewardExplain : OperationRelatedExplainBase // TypeDefIndex: 14973
{
	// Fields
	private readonly byte highRaidNo; // 0x10
	private readonly byte trophyId; // 0x11

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356B0B0 Offset: 0x35670B0 VA: 0x356B0B0
	public void .ctor(byte highRaidNo, byte trophyId) { }

	// RVA: 0x356B0E0 Offset: 0x35670E0 VA: 0x356B0E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356B0E8 Offset: 0x35670E8 VA: 0x356B0E8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356B0F0 Offset: 0x35670F0 VA: 0x356B0F0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356B160 Offset: 0x3567160 VA: 0x356B160 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356B2D0 Offset: 0x35672D0 VA: 0x356B2D0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetHighRaidTrophyRewardResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(byte highRaidNo, byte trophyId, RewardResponseDatav2 reward);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnBagNotFreeLocation();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBagItemIsFull();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnValueOver();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnNotReadyToRun();

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnBagCapacityOver();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void OnInvalidOperationParameter();

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void OnDataNull();

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void OnNotBeHeld();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void OnSqlError();

	// RVA: -1 Offset: -1 Slot: 21
	protected abstract void OnFatal();

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract void OnFailureReloadTrophyData(short returnCode, Dictionary<byte, byte> trophys);
}
