// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Scenario.Mission
[CLSCompliant(False)]
public abstract class MissionSkipExplain : OperationRelatedExplainBase // TypeDefIndex: 14922
{
	// Fields
	private int avatarUuid; // 0x10
	private int missionId; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3561F90 Offset: 0x355DF90 VA: 0x3561F90
	public void .ctor(int avatarUuid, int missionId) { }

	// RVA: 0x3561FBC Offset: 0x355DFBC VA: 0x3561FBC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3561FC4 Offset: 0x355DFC4 VA: 0x3561FC4 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3561FCC Offset: 0x355DFCC VA: 0x3561FCC Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3561FD4 Offset: 0x355DFD4 VA: 0x3561FD4 Slot: 7
	public override void SendOperation(Game engine) { }

	// RVA: 0x35620E8 Offset: 0x355E0E8 VA: 0x35620E8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3562244 Offset: 0x355E244 VA: 0x3562244
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MissionSkipResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MissionSkipResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
