// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Main.Item
[CLSCompliant(False)]
public abstract class ContinuousCristaAttachExplain : OperationExplainBase // TypeDefIndex: 14971
{
	// Fields
	private int targetEquipUuid; // 0x10
	private byte targetSlot; // 0x14
	private int attachCristaUuid; // 0x18
	private List<ReinforceCristaData> reinforceDatas; // 0x20

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x356AA00 Offset: 0x3566A00 VA: 0x356AA00
	public void .ctor(int targetEquipUuid, byte targetSlot, CristaAttach ca, Dictionary<byte, ReinforceCristaAttach> rcaList) { }

	// RVA: 0x356ACFC Offset: 0x3566CFC VA: 0x356ACFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356AD04 Offset: 0x3566D04 VA: 0x356AD04 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x356AD8C Offset: 0x3566D8C VA: 0x356AD8C Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356AE3C Offset: 0x3566E3C VA: 0x356AE3C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ContinuousCristaAttachResponse response) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnSuccess(ContinuousCristaAttachResponse response);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
