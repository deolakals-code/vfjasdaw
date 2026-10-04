// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetSkillInitLevelExplain : GmOperationExplainBase // TypeDefIndex: 17633
{
	// Fields
	private readonly long petUuid; // 0x10
	private readonly byte skillNo; // 0x18
	private readonly byte initLevel; // 0x19

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379ACB0 Offset: 0x3796CB0 VA: 0x379ACB0
	public void .ctor(long petUuid, byte skillNo, byte initLevel) { }

	// RVA: 0x379ACF0 Offset: 0x3796CF0 VA: 0x379ACF0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379ACF8 Offset: 0x3796CF8 VA: 0x379ACF8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379AD00 Offset: 0x3796D00 VA: 0x379AD00 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379AD78 Offset: 0x3796D78 VA: 0x379AD78 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379AE9C Offset: 0x3796E9C VA: 0x379AE9C Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(PetData petData);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
