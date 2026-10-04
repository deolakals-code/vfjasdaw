// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class UnlockSummonDemonicExplain : OperationRelatedExplainBase // TypeDefIndex: 14919
{
	// Fields
	private readonly byte unlockNo; // 0x10
	private readonly int useOrb; // 0x14
	private readonly int orbNum; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35616D0 Offset: 0x355D6D0 VA: 0x35616D0
	public void .ctor(byte unlockNo, int useOrb, int orbNum) { }

	// RVA: 0x356170C Offset: 0x355D70C VA: 0x356170C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3561714 Offset: 0x355D714 VA: 0x3561714 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356171C Offset: 0x355D71C VA: 0x356171C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356178C Offset: 0x355D78C VA: 0x356178C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35618E0 Offset: 0x355D8E0 VA: 0x35618E0
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, UnlockSummonDemonicResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(UnlockSummonDemonicResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnValueWrong(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadyExists(short returnCode);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
