// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketRegisterCancelReconnectionData : IReconnectionSubData // TypeDefIndex: 4925
{
	// Fields
	private int slot; // 0x10
	private long marketId; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECF30 Offset: 0x25E8F30 VA: 0x25ECF30 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECF38 Offset: 0x25E8F38 VA: 0x25ECF38 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECF40 Offset: 0x25E8F40 VA: 0x25ECF40
	public void .ctor(int slotId, long marketId) { }

	// RVA: 0x25ECF70 Offset: 0x25E8F70 VA: 0x25ECF70 Slot: 6
	public void Reconnection(Game engine) { }
}
