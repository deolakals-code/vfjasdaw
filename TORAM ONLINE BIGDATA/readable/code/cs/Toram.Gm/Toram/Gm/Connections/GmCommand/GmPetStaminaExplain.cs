// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetStaminaExplain : GmOperationExplainBase // TypeDefIndex: 17635
{
	// Fields
	private readonly long petUuid; // 0x10
	private readonly short stamina; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379B0B0 Offset: 0x37970B0 VA: 0x379B0B0
	public void .ctor(long petUuid, short stamina) { }

	// RVA: 0x379B0E0 Offset: 0x37970E0 VA: 0x379B0E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379B0E8 Offset: 0x37970E8 VA: 0x379B0E8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379B0F0 Offset: 0x37970F0 VA: 0x379B0F0 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379B160 Offset: 0x3797160 VA: 0x379B160 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379B284 Offset: 0x3797284 VA: 0x379B284 Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(PetData petData);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
