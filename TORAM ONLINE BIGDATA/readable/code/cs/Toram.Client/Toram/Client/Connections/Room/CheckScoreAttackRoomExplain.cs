// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Room
[CLSCompliant(False)]
public abstract class CheckScoreAttackRoomExplain : OperationRelatedExplainBase // TypeDefIndex: 14929
{
	// Fields
	private bool isSolo; // 0x10
	private byte bossId; // 0x11
	private bool isIgnoreRotation; // 0x12

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35633E8 Offset: 0x355F3E8 VA: 0x35633E8
	public void .ctor(bool isSolo, byte bossId, bool isIgnoreRotation) { }

	// RVA: 0x3563428 Offset: 0x355F428 VA: 0x3563428 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3563430 Offset: 0x355F430 VA: 0x3563430 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3563438 Offset: 0x355F438 VA: 0x3563438 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35634B0 Offset: 0x355F4B0 VA: 0x35634B0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356360C Offset: 0x355F60C VA: 0x356360C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CheckScoreAttackRoomResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CheckScoreAttackRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotEnoughAccountProgress();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnMercenaryNotAllowed();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnBossNotHeld();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnNotHeld();

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnFailure(short returnCode);
}
