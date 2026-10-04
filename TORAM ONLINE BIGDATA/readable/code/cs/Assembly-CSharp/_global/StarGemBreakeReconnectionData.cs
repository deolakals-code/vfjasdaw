// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StarGemBreakeReconnectionData : IReconnectionSubData // TypeDefIndex: 4976
{
	// Fields
	private long gemUuid; // 0x10
	private byte flag; // 0x18

	// Properties
	public byte SubCode { get; }
	public byte Code { get; }

	// Methods

	// RVA: 0x25EDED8 Offset: 0x25E9ED8 VA: 0x25EDED8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDEE0 Offset: 0x25E9EE0 VA: 0x25EDEE0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDEE8 Offset: 0x25E9EE8 VA: 0x25EDEE8
	public void .ctor(long gemUuid, byte flag) { }

	// RVA: 0x25EDF18 Offset: 0x25E9F18 VA: 0x25EDF18 Slot: 6
	public void Reconnection(Game engine) { }
}
