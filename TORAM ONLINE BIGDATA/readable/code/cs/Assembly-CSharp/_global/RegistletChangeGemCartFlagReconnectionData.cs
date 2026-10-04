// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegistletChangeGemCartFlagReconnectionData : IReconnectionSubData // TypeDefIndex: 5064
{
	// Fields
	private long uuid; // 0x10
	private byte flag; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFA8C Offset: 0x25EBA8C VA: 0x25EFA8C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFA94 Offset: 0x25EBA94 VA: 0x25EFA94 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFA9C Offset: 0x25EBA9C VA: 0x25EFA9C
	public void .ctor(long uuid, byte flag) { }

	// RVA: 0x25EFACC Offset: 0x25EBACC VA: 0x25EFACC Slot: 6
	public void Reconnection(Game engine) { }
}
