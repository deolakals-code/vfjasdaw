// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections
[CLSCompliant(False)]
public abstract class GmOperationExplain : OperationRelatedExplainBase // TypeDefIndex: 14900
{
	// Fields
	public readonly GmOperationExplainBase Operation; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x355EFA4 Offset: 0x355AFA4 VA: 0x355EFA4
	public void .ctor(GmOperationExplainBase operation) { }

	// RVA: 0x355EFDC Offset: 0x355AFDC VA: 0x355EFDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x355EFFC Offset: 0x355AFFC VA: 0x355EFFC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x355F01C Offset: 0x355B01C VA: 0x355F01C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x355F03C Offset: 0x355B03C VA: 0x355F03C Slot: 7
	public override void SendOperation(Game engine) { }

	// RVA: 0x355F1EC Offset: 0x355B1EC VA: 0x355F1EC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }
}
