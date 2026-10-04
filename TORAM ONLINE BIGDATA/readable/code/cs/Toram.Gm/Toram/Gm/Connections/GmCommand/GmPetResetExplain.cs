// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetResetExplain : GmOperationExplainBase // TypeDefIndex: 17631
{
	// Fields
	private readonly long petUuid; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379A8F8 Offset: 0x37968F8 VA: 0x379A8F8
	public void .ctor(long petUuid) { }

	// RVA: 0x379A920 Offset: 0x3796920 VA: 0x379A920 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379A928 Offset: 0x3796928 VA: 0x379A928 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379A930 Offset: 0x3796930 VA: 0x379A930 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379A998 Offset: 0x3796998 VA: 0x379A998 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379AAAC Offset: 0x3796AAC VA: 0x379AAAC Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(PetInfoData petInfoData);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
