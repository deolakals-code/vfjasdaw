// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetSkillAddExpExplain : GmOperationExplainBase // TypeDefIndex: 17632
{
	// Fields
	private readonly long petUuid; // 0x10
	private readonly byte skillNo; // 0x18
	private readonly int exp; // 0x1C

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379AAB8 Offset: 0x3796AB8 VA: 0x379AAB8
	public void .ctor(long petUuid, byte skillNo, int exp) { }

	// RVA: 0x379AAF8 Offset: 0x3796AF8 VA: 0x379AAF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379AB00 Offset: 0x3796B00 VA: 0x379AB00 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379AB08 Offset: 0x3796B08 VA: 0x379AB08 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379AB80 Offset: 0x3796B80 VA: 0x379AB80 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379ACA4 Offset: 0x3796CA4 VA: 0x379ACA4 Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(PetData petData);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
