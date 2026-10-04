// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.PetRace
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class PetRaceSettingChangeExplain : OperationRelatedExplainBase // TypeDefIndex: 14992
{
	// Fields
	private readonly int courseId; // 0x10
	private readonly short settingBitFlag; // 0x14

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356F2DC Offset: 0x356B2DC VA: 0x356F2DC
	public void .ctor(int courseId, short bitFlag) { }

	// RVA: 0x356F30C Offset: 0x356B30C VA: 0x356F30C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356F314 Offset: 0x356B314 VA: 0x356F314 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356F31C Offset: 0x356B31C VA: 0x356F31C Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356F38C Offset: 0x356B38C VA: 0x356F38C Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356F43C Offset: 0x356B43C VA: 0x356F43C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, PetRaceSettingChangeResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(PetRaceSettingChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnUnableJoin(short returnCode);

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnWrongStateOrPhase(short returnCode);
}
