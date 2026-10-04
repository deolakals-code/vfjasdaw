// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketCollectReconnectionData : IReconnectionSubData // TypeDefIndex: 4926
{
	// Fields
	private int slot; // 0x10
	private long marketId; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECF88 Offset: 0x25E8F88 VA: 0x25ECF88 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECF90 Offset: 0x25E8F90 VA: 0x25ECF90 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECF98 Offset: 0x25E8F98 VA: 0x25ECF98
	public void .ctor(int slotId, long marketId) { }

	// RVA: 0x25ECFC8 Offset: 0x25E8FC8 VA: 0x25ECFC8 Slot: 6
	public void Reconnection(Game engine) { }
}
