// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class UnlockHuntingOneExplain : OperationRelatedExplainBase // TypeDefIndex: 14920
{
	// Fields
	private readonly byte unlockNo; // 0x10
	private readonly int useOrb; // 0x14
	private readonly int orbNum; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3561968 Offset: 0x355D968 VA: 0x3561968
	public void .ctor(byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x35619A4 Offset: 0x355D9A4 VA: 0x35619A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35619AC Offset: 0x355D9AC VA: 0x35619AC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35619B4 Offset: 0x355D9B4 VA: 0x35619B4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3561A24 Offset: 0x355DA24 VA: 0x3561A24 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3561B78 Offset: 0x355DB78 VA: 0x3561B78
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, UnlockHuntingOneResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(UnlockHuntingOneResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnValueWrong(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadyExists(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
