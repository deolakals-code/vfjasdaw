// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongChangeMemberSettingExplain : OperationRelatedExplainBase // TypeDefIndex: 15006
{
	// Fields
	private byte psi; // 0x10
	private byte voiceId; // 0x11

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35716D0 Offset: 0x356D6D0 VA: 0x35716D0
	public void .ctor(byte psi, byte voiceId) { }

	// RVA: 0x3571700 Offset: 0x356D700 VA: 0x3571700 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3571708 Offset: 0x356D708 VA: 0x3571708 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3571710 Offset: 0x356D710 VA: 0x3571710 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3571780 Offset: 0x356D780 VA: 0x3571780 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35718DC Offset: 0x356D8DC VA: 0x35718DC
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, MahjongChangeMemberSettingResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(MahjongChangeMemberSettingResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotJoined();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnMemberNotFound();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
