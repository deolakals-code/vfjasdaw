// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House
[CLSCompliant(False)]
public abstract class HousePetColoringExplain : OperationRelatedExplainBase // TypeDefIndex: 14976
{
	// Fields
	private long[] choiceUuids; // 0x10
	private int useOrb; // 0x18
	private int orb; // 0x1C

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356BF94 Offset: 0x3567F94 VA: 0x356BF94
	public void .ctor(long baseUuid, long c1Uuid, long c2Uuid, long c3Uuid, int useOrb, int orb) { }

	// RVA: 0x356C06C Offset: 0x356806C VA: 0x356C06C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356C074 Offset: 0x3568074 VA: 0x356C074 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356C07C Offset: 0x356807C VA: 0x356C07C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356C0F4 Offset: 0x35680F4 VA: 0x356C0F4 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356C250 Offset: 0x3568250 VA: 0x356C250
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, HousePetColoringResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(OperationResponseBase response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnNotFound();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnFailure(short returnCode);
}
