// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseSaveEntryReconnectionData : IReconnectionSubData // TypeDefIndex: 4899
{
	// Fields
	private byte saveEdit; // 0x10

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC8F0 Offset: 0x25E88F0 VA: 0x25EC8F0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC8F8 Offset: 0x25E88F8 VA: 0x25EC8F8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC900 Offset: 0x25E8900 VA: 0x25EC900
	public void .ctor(byte saveEdit) { }

	// RVA: 0x25EC928 Offset: 0x25E8928 VA: 0x25EC928 Slot: 6
	public void Reconnection(Game engine) { }
}
