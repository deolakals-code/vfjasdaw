// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.House.Mahjong.Game
[CLSCompliant(False)]
[Obsolete("rm24855適応後削除予定")]
public abstract class MahjongRoundResultEndExplain : OperationRelatedExplainBase // TypeDefIndex: 15021
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3573ECC Offset: 0x356FECC VA: 0x3573ECC
	public void .ctor() { }

	// RVA: 0x3573ED4 Offset: 0x356FED4 VA: 0x3573ED4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3573EDC Offset: 0x356FEDC VA: 0x3573EDC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x3573EE4 Offset: 0x356FEE4 VA: 0x3573EE4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3573EEC Offset: 0x356FEEC VA: 0x3573EEC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x3573F04 Offset: 0x356FF04 VA: 0x3573F04
	private GameReturnCode ReceiveResponse(Game engine, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
