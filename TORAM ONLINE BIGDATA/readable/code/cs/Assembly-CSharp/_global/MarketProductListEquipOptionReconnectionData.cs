// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketProductListEquipOptionReconnectionData : IReconnectionSubData // TypeDefIndex: 4928
{
	// Fields
	private MarketType type; // 0x10
	private int itemId; // 0x14
	private ItemType itemType; // 0x18
	private MarketOrderType orderType; // 0x1C
	private MarketProductList.EnumOptionsSlot slot; // 0x20
	private byte color; // 0x21
	private MarketProductList.EnumOptionsParts parts; // 0x22
	private int modelId; // 0x24
	private byte page; // 0x28
	private short capId; // 0x2A
	private short rProperty; // 0x2C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ED098 Offset: 0x25E9098 VA: 0x25ED098 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ED0A0 Offset: 0x25E90A0 VA: 0x25ED0A0 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ED0A8 Offset: 0x25E90A8 VA: 0x25ED0A8
	public void .ctor(MarketType type, int itemId, ItemType itemType, MarketOrderType orderType, MarketProductList.EnumOptionsSlot slot, byte color, MarketProductList.EnumOptionsParts parts, int modelId, short capId, short rProperty, byte page) { }

	// RVA: 0x25ED148 Offset: 0x25E9148 VA: 0x25ED148 Slot: 6
	public void Reconnection(Game engine) { }
}
