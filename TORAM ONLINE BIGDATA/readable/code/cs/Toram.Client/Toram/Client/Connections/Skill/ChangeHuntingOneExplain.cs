// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class ChangeHuntingOneExplain : OperationRelatedExplainBase // TypeDefIndex: 14915
{
	// Fields
	private readonly byte selectNo; // 0x10
	private readonly int color; // 0x14
	private readonly int flag; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3560E80 Offset: 0x355CE80 VA: 0x3560E80
	public void .ctor(byte selectNo, int color, int flag) { }

	// RVA: 0x3560EBC Offset: 0x355CEBC VA: 0x3560EBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3560EC4 Offset: 0x355CEC4 VA: 0x3560EC4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3560ECC Offset: 0x355CECC VA: 0x3560ECC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3560F3C Offset: 0x355CF3C VA: 0x3560F3C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3561090 Offset: 0x355D090 VA: 0x3561090
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ChangeHuntingOneResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ChangeHuntingOneResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnValueWrong(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
