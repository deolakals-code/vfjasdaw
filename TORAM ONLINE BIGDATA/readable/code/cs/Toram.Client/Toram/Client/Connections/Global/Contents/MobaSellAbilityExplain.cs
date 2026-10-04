// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaSellAbilityExplain : OperationRelatedExplainBase // TypeDefIndex: 15090
{
	// Fields
	private readonly int abilityId; // 0x10
	private readonly int price; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D968 Offset: 0x3579968 VA: 0x357D968
	public void .ctor(int abilityId, int price) { }

	// RVA: 0x357D994 Offset: 0x3579994 VA: 0x357D994 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D99C Offset: 0x357999C VA: 0x357D99C Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D9A4 Offset: 0x35799A4 VA: 0x357D9A4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357DA0C Offset: 0x3579A0C VA: 0x357DA0C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357DA98 Offset: 0x3579A98 VA: 0x357DA98
	private GameReturnCode ReceiveResponse(short returnCode, MobaSellAbilityResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaSellAbilityResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnCantSell(short returnCode, MobaSellAbilityResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode, MobaSellAbilityResponse response);
}
