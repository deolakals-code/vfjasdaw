// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.CraneGame
[Obsolete("rm24855適応後削除予定")]
[CLSCompliant(False)]
public abstract class CraneGameAddPlayCountExplain : OperationRelatedExplainBase // TypeDefIndex: 15023
{
	// Fields
	private byte addPlayCount; // 0x10

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3574260 Offset: 0x3570260 VA: 0x3574260
	public void .ctor(byte addPlayCount) { }

	// RVA: 0x3574288 Offset: 0x3570288 VA: 0x3574288 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3574290 Offset: 0x3570290 VA: 0x3574290 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3574298 Offset: 0x3570298 VA: 0x3574298 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3574300 Offset: 0x3570300 VA: 0x3574300 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x357445C Offset: 0x357045C VA: 0x357445C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, CraneGameAddPlayCountResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(CraneGameAddPlayCountResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnAlreadyPlaying();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnUpperLimitPlayCount();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMoneyNotEnough();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
