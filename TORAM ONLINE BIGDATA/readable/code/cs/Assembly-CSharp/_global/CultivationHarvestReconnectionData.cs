// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CultivationHarvestReconnectionData : IReconnectionSubData // TypeDefIndex: 4906
{
	// Fields
	private short index; // 0x10
	private int produceId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECB24 Offset: 0x25E8B24 VA: 0x25ECB24 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECB2C Offset: 0x25E8B2C VA: 0x25ECB2C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECB34 Offset: 0x25E8B34 VA: 0x25ECB34
	public void .ctor(short index, int produceId) { }

	// RVA: 0x25ECB64 Offset: 0x25E8B64 VA: 0x25ECB64 Slot: 6
	public void Reconnection(Game engine) { }
}
