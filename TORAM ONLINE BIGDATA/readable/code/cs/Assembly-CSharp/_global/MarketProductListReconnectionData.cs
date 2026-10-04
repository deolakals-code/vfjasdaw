// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketProductListReconnectionData : IReconnectionSubData // TypeDefIndex: 4921
{
	// Fields
	private MarketType type; // 0x10
	private int itemId; // 0x14
	private ItemType itemType; // 0x18
	private MarketOrderType orderType; // 0x1C
	private byte page; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECD84 Offset: 0x25E8D84 VA: 0x25ECD84 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECD8C Offset: 0x25E8D8C VA: 0x25ECD8C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECD94 Offset: 0x25E8D94 VA: 0x25ECD94
	public void .ctor(MarketType type, int itemId, ItemType itemType, MarketOrderType orderType, byte page) { }

	// RVA: 0x25ECDE8 Offset: 0x25E8DE8 VA: 0x25ECDE8 Slot: 6
	public void Reconnection(Game engine) { }
}
