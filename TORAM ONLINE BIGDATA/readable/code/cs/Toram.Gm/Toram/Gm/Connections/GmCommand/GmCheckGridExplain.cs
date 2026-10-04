// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections.GmCommand
[CLSCompliant(False)]
public abstract class GmCheckGridExplain : GmOperationExplainBase // TypeDefIndex: 17627
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379A354 Offset: 0x3796354 VA: 0x379A354
	public void .ctor() { }

	// RVA: 0x379A35C Offset: 0x379635C VA: 0x379A35C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379A364 Offset: 0x3796364 VA: 0x379A364 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x379A36C Offset: 0x379636C VA: 0x379A36C Slot: 7
	public override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x379A374 Offset: 0x3796374 VA: 0x379A374 Slot: 9
	public override void OnSuccessConvert(GmCommandResponse response) { }

	// RVA: 0x379A4A8 Offset: 0x37964A8 VA: 0x379A4A8 Slot: 10
	public override void OnFailureConvert(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSuccess(string strRegion);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short errorCode);
}
