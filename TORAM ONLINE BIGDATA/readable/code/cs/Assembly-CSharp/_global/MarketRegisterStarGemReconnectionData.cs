// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketRegisterStarGemReconnectionData : IReconnectionSubData // TypeDefIndex: 4924
{
	// Fields
	private int slot; // 0x10
	private MarketType type; // 0x14
	private int price; // 0x18
	private int fee; // 0x1C
	private long uuid; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECEB4 Offset: 0x25E8EB4 VA: 0x25ECEB4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECEBC Offset: 0x25E8EBC VA: 0x25ECEBC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECEC4 Offset: 0x25E8EC4 VA: 0x25ECEC4
	public void .ctor(int slotId, MarketType type, long uuid, int price, int fee) { }

	// RVA: 0x25ECF14 Offset: 0x25E8F14 VA: 0x25ECF14 Slot: 6
	public void Reconnection(Game engine) { }
}
