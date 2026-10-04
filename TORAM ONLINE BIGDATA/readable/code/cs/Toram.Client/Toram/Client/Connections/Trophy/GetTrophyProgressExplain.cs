// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Trophy
[CLSCompliant(False)]
public abstract class GetTrophyProgressExplain : OperationRelatedExplainBase // TypeDefIndex: 14905
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x355FDCC Offset: 0x355BDCC VA: 0x355FDCC
	public void .ctor() { }

	// RVA: 0x355FDD4 Offset: 0x355BDD4 VA: 0x355FDD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x355FDDC Offset: 0x355BDDC VA: 0x355FDDC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x355FDE4 Offset: 0x355BDE4 VA: 0x355FDE4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x355FDEC Offset: 0x355BDEC VA: 0x355FDEC Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x355FF48 Offset: 0x355BF48 VA: 0x355FF48
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetTrophyProgressResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetTrophyProgressResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnFailure(short returnCode);
}
