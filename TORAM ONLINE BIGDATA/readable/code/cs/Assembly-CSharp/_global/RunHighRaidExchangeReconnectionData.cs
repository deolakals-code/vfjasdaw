// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RunHighRaidExchangeReconnectionData : IReconnectionSubData // TypeDefIndex: 5073
{
	// Fields
	private byte highRaidNo; // 0x10
	private int rewardCost; // 0x14
	private int nowPoint; // 0x18
	private byte rewardNo; // 0x1C

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EFD60 Offset: 0x25EBD60 VA: 0x25EFD60 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EFD68 Offset: 0x25EBD68 VA: 0x25EFD68 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EFD70 Offset: 0x25EBD70 VA: 0x25EFD70
	public void .ctor(byte highRaidNo, int rewardCost, int nowPoint, byte rewardNo) { }

	// RVA: 0x25EFDB4 Offset: 0x25EBDB4 VA: 0x25EFDB4 Slot: 6
	public void Reconnection(Game engine) { }
}
