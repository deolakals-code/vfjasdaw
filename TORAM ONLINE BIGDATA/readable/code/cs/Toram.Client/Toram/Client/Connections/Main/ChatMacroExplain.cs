// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Main
[CLSCompliant(False)]
public abstract class ChatMacroExplain : OperationExplainBase // TypeDefIndex: 14968
{
	// Fields
	private readonly byte macroType; // 0x10
	private readonly byte channelType; // 0x11
	private readonly int targetId; // 0x14
	private readonly DiceMacroElement[] diceMacroElements; // 0x18

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x356A37C Offset: 0x356637C VA: 0x356A37C
	public void .ctor(byte channelType, int targetId, DiceMacroElement[] diceMacroElements) { }

	// RVA: 0x356A3CC Offset: 0x35663CC VA: 0x356A3CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356A3D4 Offset: 0x35663D4 VA: 0x356A3D4 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x356A45C Offset: 0x356645C VA: 0x356A45C Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: 0x356A50C Offset: 0x356650C VA: 0x356A50C
	private GameReturnCode ReceiveResponse(Game engine, short returnCode, ChatMacroResponse response) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnSuccess(ChatMacroResponse response);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnFailure(short returnCode);

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void OnSystemLock();

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract void OnNotAllowed();

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract void OnNumberWrong();
}
