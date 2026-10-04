// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaBuyAbilityExplain : OperationRelatedExplainBase // TypeDefIndex: 15060
{
	// Fields
	private readonly int abilityId; // 0x10
	private readonly int price; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357AF14 Offset: 0x3576F14 VA: 0x357AF14
	public void .ctor(int abilityId, int price) { }

	// RVA: 0x357AF40 Offset: 0x3576F40 VA: 0x357AF40 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357AF48 Offset: 0x3576F48 VA: 0x357AF48 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357AF50 Offset: 0x3576F50 VA: 0x357AF50 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357AFB8 Offset: 0x3576FB8 VA: 0x357AFB8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357B044 Offset: 0x3577044 VA: 0x357B044
	private GameReturnCode ReceiveResponse(short returnCode, MobaBuyAbilityResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaBuyAbilityResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnCanNotBuy(short returnCode, MobaBuyAbilityResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadyExists(MobaBuyAbilityResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode, MobaBuyAbilityResponse response);
}
