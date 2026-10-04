// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.PaletteStorage
[CLSCompliant(False)]
public abstract class GetPaletteExplain : OperationRelatedExplainBase // TypeDefIndex: 14967
{
	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x356A098 Offset: 0x3566098 VA: 0x356A098
	public void .ctor() { }

	// RVA: 0x356A0A0 Offset: 0x35660A0 VA: 0x356A0A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356A0A8 Offset: 0x35660A8 VA: 0x356A0A8 Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x356A0B0 Offset: 0x35660B0 VA: 0x356A0B0 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x356A0B8 Offset: 0x35660B8 VA: 0x356A0B8 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356A214 Offset: 0x3566214 VA: 0x356A214
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, GetPaletteResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(GetPaletteResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnItemTypeNotAllowed();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnPaletteDataNull();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnFailure(short returnCode);
}
