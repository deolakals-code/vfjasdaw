// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaSaveProfileExplain : OperationRelatedExplainBase // TypeDefIndex: 15089
{
	// Fields
	private readonly MobaProfileData profile; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D7A8 Offset: 0x35797A8 VA: 0x357D7A8
	public void .ctor(MobaProfileData profileData) { }

	// RVA: 0x357D7D8 Offset: 0x35797D8 VA: 0x357D7D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D7E0 Offset: 0x35797E0 VA: 0x357D7E0 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D7E8 Offset: 0x35797E8 VA: 0x357D7E8 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D858 Offset: 0x3579858 VA: 0x357D858 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaSaveProfileResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnConditionsAreNotMet();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNameError(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnProfileError(short returnCode);
}
