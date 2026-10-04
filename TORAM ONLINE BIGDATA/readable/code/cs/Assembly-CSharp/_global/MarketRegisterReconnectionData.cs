// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketRegisterReconnectionData : IReconnectionSubData // TypeDefIndex: 4923
{
	// Fields
	private int slot; // 0x10
	private MarketType type; // 0x14
	private int price; // 0x18
	private int fee; // 0x1C
	private ItemSelectData data; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECE2C Offset: 0x25E8E2C VA: 0x25ECE2C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECE34 Offset: 0x25E8E34 VA: 0x25ECE34 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECE3C Offset: 0x25E8E3C VA: 0x25ECE3C
	public void .ctor(int slotId, MarketType type, ItemSelectData data, int price, int fee) { }

	// RVA: 0x25ECE98 Offset: 0x25E8E98 VA: 0x25ECE98 Slot: 6
	public void Reconnection(Game engine) { }
}
