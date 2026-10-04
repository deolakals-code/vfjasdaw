// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketPurchaseReconnectionData : IReconnectionSubData // TypeDefIndex: 4927
{
	// Fields
	private MarketType type; // 0x10
	private long marketId; // 0x18
	private int itemId; // 0x20
	private byte rate; // 0x24
	private ItemType itemType; // 0x26
	private MarketOrderType orderType; // 0x28
	private int autoLockFlag; // 0x2C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECFE0 Offset: 0x25E8FE0 VA: 0x25ECFE0 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECFE8 Offset: 0x25E8FE8 VA: 0x25ECFE8 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECFF0 Offset: 0x25E8FF0 VA: 0x25ECFF0
	public void .ctor(MarketType marketType, long marketId, int itemId, byte tariffRate, ItemType itemType, MarketOrderType orderType, int autoLockFlag) { }

	// RVA: 0x25ED05C Offset: 0x25E905C VA: 0x25ED05C Slot: 6
	public void Reconnection(Game engine) { }
}
