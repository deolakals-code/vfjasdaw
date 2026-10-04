// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CultivationWateringReconnectionData : IReconnectionSubData // TypeDefIndex: 4907
{
	// Fields
	private short index; // 0x10
	private int produceId; // 0x14

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECB7C Offset: 0x25E8B7C VA: 0x25ECB7C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECB84 Offset: 0x25E8B84 VA: 0x25ECB84 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECB8C Offset: 0x25E8B8C VA: 0x25ECB8C
	public void .ctor(short index, int produceId) { }

	// RVA: 0x25ECBBC Offset: 0x25E8BBC VA: 0x25ECBBC Slot: 6
	public void Reconnection(Game engine) { }
}
