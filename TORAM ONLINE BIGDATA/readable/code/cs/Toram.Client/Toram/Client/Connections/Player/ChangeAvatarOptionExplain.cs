// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Player
[CLSCompliant(False)]
public abstract class ChangeAvatarOptionExplain : OperationExplainBase // TypeDefIndex: 14934
{
	// Fields
	private readonly AvatarOptionDataBase[] optionList; // 0x10

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x3564068 Offset: 0x3560068 VA: 0x3564068
	public void .ctor(AvatarOptionDataBase[] list) { }

	// RVA: 0x3564098 Offset: 0x3560098 VA: 0x3564098 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35640A0 Offset: 0x35600A0 VA: 0x35640A0 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x3564110 Offset: 0x3560110 VA: 0x3564110 Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x35641B0 Offset: 0x35601B0 VA: 0x35641B0
	private GameReturnCode ReceiveResponse(short returnCode, ChangeAvatarOptionResponse response) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnSuccess(ChangeAvatarOptionResponse response);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnFailure();
}
