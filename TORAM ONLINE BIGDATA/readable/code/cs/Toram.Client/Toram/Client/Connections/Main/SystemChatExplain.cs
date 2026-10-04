// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Connections.Main
[CLSCompliant(False)]
public abstract class SystemChatExplain : OperationExplainBase // TypeDefIndex: 14969
{
	// Fields
	private readonly byte channelType; // 0x10
	private readonly short systemMessageId; // 0x12

	// Properties
	public override byte Code { get; }

	// Methods

	// RVA: 0x356A690 Offset: 0x3566690 VA: 0x356A690
	public void .ctor(byte channelType, short systemMessageId) { }

	// RVA: 0x356A6C0 Offset: 0x35666C0 VA: 0x356A6C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x356A6C8 Offset: 0x35666C8 VA: 0x356A6C8 Slot: 5
	protected override PacketBase GetOperationParameter() { }

	// RVA: 0x356A738 Offset: 0x3566738 VA: 0x356A738 Slot: 8
	public override GameReturnCode ReceiveResponse(Game engine, OperationResponse operationResponse) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OnSuccess();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void OnFailure(short returnCode);
}
