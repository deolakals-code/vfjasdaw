// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Skill
[CLSCompliant(False)]
public abstract class UpdateExSkillConfigExplain : OperationRelatedExplainBase // TypeDefIndex: 14921
{
	// Fields
	private short skillId; // 0x10
	private byte[] binary; // 0x18

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3561C00 Offset: 0x355DC00 VA: 0x3561C00
	public void .ctor(short skillId, byte[] binary) { }

	// RVA: 0x3561C38 Offset: 0x355DC38 VA: 0x3561C38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3561C40 Offset: 0x355DC40 VA: 0x3561C40 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3561C48 Offset: 0x355DC48 VA: 0x3561C48 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3561CC0 Offset: 0x355DCC0 VA: 0x3561CC0 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3561E1C Offset: 0x355DE1C VA: 0x3561E1C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, UpdateExSkillConfigResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(UpdateExSkillConfigResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSkillNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNoChange();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
