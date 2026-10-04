// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class ChangeSummonDemonicExplain : OperationRelatedExplainBase // TypeDefIndex: 14917
{
	// Fields
	private readonly byte selectNo; // 0x10
	private readonly int color; // 0x14
	private readonly int flag; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35612A8 Offset: 0x355D2A8 VA: 0x35612A8
	public void .ctor(byte selectNo, int color, int flag) { }

	// RVA: 0x35612E4 Offset: 0x355D2E4 VA: 0x35612E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35612EC Offset: 0x355D2EC VA: 0x35612EC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35612F4 Offset: 0x355D2F4 VA: 0x35612F4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3561364 Offset: 0x355D364 VA: 0x3561364 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35614B8 Offset: 0x355D4B8 VA: 0x35614B8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ChangeSummonDemonicResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ChangeSummonDemonicResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnValueWrong(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
