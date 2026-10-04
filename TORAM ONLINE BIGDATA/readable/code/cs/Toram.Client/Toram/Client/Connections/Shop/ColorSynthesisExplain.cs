// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Shop
[CLSCompliant(False)]
public abstract class ColorSynthesisExplain : OperationRelatedExplainBase // TypeDefIndex: 14946
{
	// Fields
	private readonly int mainGemId; // 0x10
	private readonly int[] subGemIds; // 0x18
	private readonly short[] useSupportList; // 0x20
	private readonly ColorSynthesisType synthesisType; // 0x28
	private readonly short equipType; // 0x2A
	private readonly bool specifyColorPosition; // 0x2C
	private readonly byte colorPosition; // 0x2D
	private readonly int metalPoint; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3565398 Offset: 0x3561398 VA: 0x3565398
	private void .ctor(ColorSynthesisType synthesisType, short equipType, int mainGemId, int[] subGemIds, short useMagicHammer, short useSuperMagicHammer, short useHyperMagicHammer, bool specifyColorPosition, byte colorPosition) { }

	// RVA: 0x356549C Offset: 0x356149C VA: 0x356549C
	public void .ctor(ColorSynthesisType synthesisType, int mainGemId, int[] subGemIds, short useMagicHammer, short useSuperMagicHammer, short useHyperMagicHammer, bool specifyColorPosition, byte colorPosition) { }

	// RVA: 0x35654E0 Offset: 0x35614E0 VA: 0x35654E0
	public void .ctor(short equipType, int mainGemId, int[] subGemIds, short useMagicHammer, short useSuperMagicHammer, short useHyperMagicHammer, bool specifyColorPosition, byte colorPosition) { }

	// RVA: 0x3565528 Offset: 0x3561528 VA: 0x3565528
	public void .ctor(int metalPoint) { }

	// RVA: 0x35655C4 Offset: 0x35615C4 VA: 0x35655C4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35655CC Offset: 0x35615CC VA: 0x35655CC Slot: 5
	public override byte get_SubCode() { }

	// RVA: 0x35655D4 Offset: 0x35615D4 VA: 0x35655D4 Slot: 6
	protected override OperationRequestBase GetOperationParameter() { }

	// RVA: 0x3565684 Offset: 0x3561684 VA: 0x3565684 Slot: 9
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35657D8 Offset: 0x35617D8 VA: 0x35657D8
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ColorSynthesisResponse response) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnSuccess(ColorSynthesisResponse response);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnValueWrong();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnTypeWrong();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnGoldLimit();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract void OnFailure(short returnCode);
}
