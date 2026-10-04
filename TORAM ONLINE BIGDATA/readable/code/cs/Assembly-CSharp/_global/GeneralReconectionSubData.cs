// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GeneralReconectionSubData : IReconnectionSubData // TypeDefIndex: 4871
{
	// Fields
	private readonly Action invokeMethod; // 0x10
	[CompilerGenerated]
	private byte <SubCode>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <Code>k__BackingField; // 0x19

	// Properties
	public byte SubCode { get; set; }
	public byte Code { get; set; }

	// Methods

	// RVA: 0x25EBF1C Offset: 0x25E7F1C VA: 0x25EBF1C
	public void .ctor(OperationCode type, byte subCode, Action invokeMethod) { }

	[CompilerGenerated]
	// RVA: 0x25EBF64 Offset: 0x25E7F64 VA: 0x25EBF64 Slot: 5
	public byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x25EBF6C Offset: 0x25E7F6C VA: 0x25EBF6C
	private void set_SubCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x25EBF74 Offset: 0x25E7F74 VA: 0x25EBF74 Slot: 4
	public byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x25EBF7C Offset: 0x25E7F7C VA: 0x25EBF7C
	private void set_Code(byte value) { }

	// RVA: 0x25EBF84 Offset: 0x25E7F84 VA: 0x25EBF84 Slot: 6
	public void Reconnection(Game engine) { }
}
