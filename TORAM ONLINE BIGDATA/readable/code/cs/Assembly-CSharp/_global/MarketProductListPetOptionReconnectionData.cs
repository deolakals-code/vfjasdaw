// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketProductListPetOptionReconnectionData : IReconnectionSubData // TypeDefIndex: 4929
{
	// Fields
	private MarketType type; // 0x10
	private int itemId; // 0x14
	private ItemType itemType; // 0x18
	private MarketOrderType orderType; // 0x1C
	private byte page; // 0x20
	private int petId; // 0x24

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED1A4 Offset: 0x25E91A4 VA: 0x25ED1A4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED1AC Offset: 0x25E91AC VA: 0x25ED1AC Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED1B4 Offset: 0x25E91B4 VA: 0x25ED1B4
	public void .ctor(MarketType type, int itemId, ItemType itemType, MarketOrderType orderType, int petId, byte page) { }

	// RVA: 0x25ED210 Offset: 0x25E9210 VA: 0x25ED210 Slot: 6
	public void Reconnection(Game engine) { }
}
