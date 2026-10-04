// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralUIPanelReconectionSubData : IReconnectionSubData // TypeDefIndex: 4872
{
	// Fields
	private readonly Action invokeMethod; // 0x10
	public readonly UIBasePanel ReceiveUIManager; // 0x18
	[CompilerGenerated]
	private byte <SubCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Code>k__BackingField; // 0x21

	// Properties
	public byte SubCode { get; set; }
	public byte Code { get; set; }

	// Methods

	// RVA: 0x25EBFA0 Offset: 0x25E7FA0 VA: 0x25EBFA0
	public void .ctor(UIBasePanel receiveUIPanel, OperationCode type, byte subCode, Action invokeMethod) { }

	[CompilerGenerated]
	// RVA: 0x25EBFFC Offset: 0x25E7FFC VA: 0x25EBFFC Slot: 5
	public byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x25EC004 Offset: 0x25E8004 VA: 0x25EC004
	private void set_SubCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x25EC00C Offset: 0x25E800C VA: 0x25EC00C Slot: 4
	public byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x25EC014 Offset: 0x25E8014 VA: 0x25EC014
	private void set_Code(byte value) { }

	// RVA: 0x25EC01C Offset: 0x25E801C VA: 0x25EC01C Slot: 6
	public void Reconnection(Game engine) { }
}
