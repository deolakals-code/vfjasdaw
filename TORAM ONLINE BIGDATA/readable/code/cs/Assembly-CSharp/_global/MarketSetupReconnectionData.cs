// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MarketSetupReconnectionData : IReconnectionSubData // TypeDefIndex: 4920
{
	// Fields
	private int shopId; // 0x10
	private int autoLockFlag; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECD34 Offset: 0x25E8D34 VA: 0x25ECD34 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECD3C Offset: 0x25E8D3C VA: 0x25ECD3C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECD44 Offset: 0x25E8D44 VA: 0x25ECD44
	public void .ctor(int shopid, int autoLockFlag) { }

	// RVA: 0x25ECD70 Offset: 0x25E8D70 VA: 0x25ECD70 Slot: 6
	public void Reconnection(Game engine) { }
}
