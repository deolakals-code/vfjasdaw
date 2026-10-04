// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmPetIgnoringSatietyExplain : GmOperationExplainBase // TypeDefIndex: 17629
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379A694 Offset: 0x3796694 VA: 0x379A694
	public void .ctor() { }

	// RVA: 0x379A69C Offset: 0x379669C VA: 0x379A69C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379A6A4 Offset: 0x37966A4 VA: 0x379A6A4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379A6AC Offset: 0x37966AC VA: 0x379A6AC Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379A700 Offset: 0x3796700 VA: 0x379A700 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379A70C Offset: 0x379670C VA: 0x379A70C Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
