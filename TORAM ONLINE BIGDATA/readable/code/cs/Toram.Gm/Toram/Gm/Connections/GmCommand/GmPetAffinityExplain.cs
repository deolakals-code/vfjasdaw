// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetAffinityExplain : GmOperationExplainBase // TypeDefIndex: 17628
{
	// Fields
	private readonly long petUuid; // 0x10
	private readonly short affinity; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379A4B4 Offset: 0x37964B4 VA: 0x379A4B4
	public void .ctor(long petUuid, short affinity) { }

	// RVA: 0x379A4E4 Offset: 0x37964E4 VA: 0x379A4E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379A4EC Offset: 0x37964EC VA: 0x379A4EC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379A4F4 Offset: 0x37964F4 VA: 0x379A4F4 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379A564 Offset: 0x3796564 VA: 0x379A564 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379A688 Offset: 0x3796688 VA: 0x379A688 Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(PetData petData);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
