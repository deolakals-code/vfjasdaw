// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Global.Contents
[CLSCompliant(False)]
public abstract class MobaRespawnGhostExplain : OperationRelatedExplainBase // TypeDefIndex: 15087
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x357D618 Offset: 0x3579618 VA: 0x357D618
	public void .ctor() { }

	// RVA: 0x357D620 Offset: 0x3579620 VA: 0x357D620 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x357D628 Offset: 0x3579628 VA: 0x357D628 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x357D630 Offset: 0x3579630 VA: 0x357D630 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x357D638 Offset: 0x3579638 VA: 0x357D638 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357D6C4 Offset: 0x35796C4 VA: 0x357D6C4
	private GameReturnCode ReceiveResponse(short returnCode, MobaRespawnGhostResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MobaRespawnGhostResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAvatarNotDeath(MobaRespawnGhostResponse response);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnAlreadyExistsGhost(MobaRespawnGhostResponse response);

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode, MobaRespawnGhostResponse response);
}
