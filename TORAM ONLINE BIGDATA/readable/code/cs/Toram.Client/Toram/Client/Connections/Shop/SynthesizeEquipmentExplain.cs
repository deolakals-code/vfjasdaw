// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class SynthesizeEquipmentExplain : OperationRelatedExplainBase // TypeDefIndex: 14956
{
	// Fields
	private int shopId; // 0x10
	private short[] position; // 0x18
	private short skillId; // 0x20
	private int[] itemUuid; // 0x28
	private int[] useItemUuid; // 0x30
	private int supportItemId; // 0x38
	private int useOrb; // 0x3C
	private int orb; // 0x40

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356781C Offset: 0x356381C VA: 0x356781C
	public void .ctor(int shopId, short[] position, int[] itemUuid, int[] useItemUuid, int supportItemId, int orb, int useOrb) { }

	// RVA: 0x35678AC Offset: 0x35638AC VA: 0x35678AC
	public void .ctor(int[] itemUuid, int[] useItemUuid, int supportItemId) { }

	// RVA: 0x356790C Offset: 0x356390C VA: 0x356790C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3567914 Offset: 0x3563914 VA: 0x3567914 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356791C Offset: 0x356391C VA: 0x356791C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x35679BC Offset: 0x35639BC VA: 0x35679BC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3567B18 Offset: 0x3563B18 VA: 0x3567B18
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, SynthesizeEquipmentResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(SynthesizeEquipmentResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
