// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceInventorySlotPriceReconnectionData : IReconnectionSubData // TypeDefIndex: 4967
{
	// Fields
	private byte dataType; // 0x10

	// Properties
	public byte SubCode { get; }
	public byte Code { get; }

	// Methods

	// RVA: 0x25EDCA0 Offset: 0x25E9CA0 VA: 0x25EDCA0
	public void .ctor(byte dataType) { }

	// RVA: 0x25EDCC8 Offset: 0x25E9CC8 VA: 0x25EDCC8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDCD0 Offset: 0x25E9CD0 VA: 0x25EDCD0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDCD8 Offset: 0x25E9CD8 VA: 0x25EDCD8 Slot: 6
	public void Reconnection(Game engine) { }
}
