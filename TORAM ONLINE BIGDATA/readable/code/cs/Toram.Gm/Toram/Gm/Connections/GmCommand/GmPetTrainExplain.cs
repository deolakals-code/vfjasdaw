// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetTrainExplain : GmOperationExplainBase // TypeDefIndex: 17636
{
	// Fields
	private readonly long PetUuid; // 0x10
	private readonly short Train; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379B290 Offset: 0x3797290 VA: 0x379B290
	public void .ctor(long petUuid, short train) { }

	// RVA: 0x379B2C0 Offset: 0x37972C0 VA: 0x379B2C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379B2C8 Offset: 0x37972C8 VA: 0x379B2C8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379B2D0 Offset: 0x37972D0 VA: 0x379B2D0 Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379B340 Offset: 0x3797340 VA: 0x379B340 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379B344 Offset: 0x3797344 VA: 0x379B344 Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short errorCode);
}
