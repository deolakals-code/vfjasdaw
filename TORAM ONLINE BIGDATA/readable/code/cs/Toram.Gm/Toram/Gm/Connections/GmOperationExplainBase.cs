// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Connections
[CLSCompliant(False)]
public abstract class GmOperationExplainBase // TypeDefIndex: 17626
{
	// Properties
	public abstract byte Code { get; }
	public abstract byte SubCode { get; }
	public virtual bool IsNeedChangeField { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Code();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte get_SubCode();

	// RVA: 0x379A258 Offset: 0x3796258 VA: 0x379A258 Slot: 6
	public virtual bool get_IsNeedChangeField() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract OperationRequestBase GetOperationParameter();

	// RVA: 0x379A260 Offset: 0x3796260 VA: 0x379A260
	public GameReturnCode ReceiveResponse(OperationResponse operationResponse) { }

	// RVA: 0x379A30C Offset: 0x379630C VA: 0x379A30C Slot: 8
	protected virtual GameReturnCode ReceiveResponse(short returnCode, GmCommandResponse response) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnSuccessConvert(GmCommandResponse operation);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnFailureConvert(short returnCode, GmCommandResponse response);

	// RVA: 0x379A34C Offset: 0x379634C VA: 0x379A34C
	protected void .ctor() { }
}
