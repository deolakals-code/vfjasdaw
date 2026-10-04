// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetLevelUpExplain : GmOperationExplainBase // TypeDefIndex: 17630
{
	// Fields
	private readonly long petUuid; // 0x10
	private readonly short level; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379A718 Offset: 0x3796718 VA: 0x379A718
	public void .ctor(long petUuid, short level) { }

	// RVA: 0x379A748 Offset: 0x3796748 VA: 0x379A748 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379A750 Offset: 0x3796750 VA: 0x379A750 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379A758 Offset: 0x3796758 VA: 0x379A758 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379A7C8 Offset: 0x37967C8 VA: 0x379A7C8 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379A8EC Offset: 0x37968EC VA: 0x379A8EC Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(PetData petData);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
