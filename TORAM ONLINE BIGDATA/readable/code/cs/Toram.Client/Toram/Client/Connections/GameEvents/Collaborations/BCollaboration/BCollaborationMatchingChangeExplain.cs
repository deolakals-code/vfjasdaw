// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.GameEvents.Collaborations.BCollaboration
[CLSCompliant(False)]
public abstract class BCollaborationMatchingChangeExplain : OperationRelatedExplainBase // TypeDefIndex: 15112
{
	// Fields
	private readonly bool partyLinkFlag; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3581434 Offset: 0x357D434 VA: 0x3581434
	public void .ctor(bool partyLinkFlag) { }

	// RVA: 0x358145C Offset: 0x357D45C VA: 0x358145C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3581464 Offset: 0x357D464 VA: 0x3581464 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x358146C Offset: 0x357D46C VA: 0x358146C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35814D4 Offset: 0x357D4D4 VA: 0x35814D4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3581584 Offset: 0x357D584 VA: 0x3581584
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, BCollaborationMatchingChangeResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(BCollaborationMatchingChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
