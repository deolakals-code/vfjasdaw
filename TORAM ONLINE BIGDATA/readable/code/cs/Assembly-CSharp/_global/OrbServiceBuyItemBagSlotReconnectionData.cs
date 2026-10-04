// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbServiceBuyItemBagSlotReconnectionData : IReconnectionSubData // TypeDefIndex: 4960
{
	// Fields
	private int orbNum; // 0x10
	private int useOrb; // 0x14
	private byte dataType; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EDA3C Offset: 0x25E9A3C VA: 0x25EDA3C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EDA44 Offset: 0x25E9A44 VA: 0x25EDA44 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EDA4C Offset: 0x25E9A4C VA: 0x25EDA4C
	public void .ctor(byte dataType, int orbNum, int useOrb) { }

	// RVA: 0x25EDA88 Offset: 0x25E9A88 VA: 0x25EDA88 Slot: 6
	public void Reconnection(Game engine) { }
}
