// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralUIPanelReconectionData : IReconnectionData // TypeDefIndex: 4870
{
	// Fields
	private readonly Action invokeMethod; // 0x10
	public readonly UIBasePanel ReceiveUIManager; // 0x18
	[CompilerGenerated]
	private byte <Code>k__BackingField; // 0x20

	// Properties
	public byte Code { get; set; }

	// Methods

	// RVA: 0x25EBE9C Offset: 0x25E7E9C VA: 0x25EBE9C
	public void .ctor(UIBasePanel receiveUIPanel, OperationCode type, Action invokeMethod) { }

	[CompilerGenerated]
	// RVA: 0x25EBEF0 Offset: 0x25E7EF0 VA: 0x25EBEF0 Slot: 4
	public byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x25EBEF8 Offset: 0x25E7EF8 VA: 0x25EBEF8
	private void set_Code(byte value) { }

	// RVA: 0x25EBF00 Offset: 0x25E7F00 VA: 0x25EBF00 Slot: 5
	public void Reconnection(Game engine) { }
}
