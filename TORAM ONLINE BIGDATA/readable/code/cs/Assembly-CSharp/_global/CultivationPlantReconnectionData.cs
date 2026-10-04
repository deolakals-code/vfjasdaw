// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CultivationPlantReconnectionData : IReconnectionSubData // TypeDefIndex: 4904
{
	// Fields
	private short index; // 0x10
	private int produceId; // 0x14
	private short point; // 0x18
	private byte bonus; // 0x1A

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25ECA54 Offset: 0x25E8A54 VA: 0x25ECA54 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25ECA5C Offset: 0x25E8A5C VA: 0x25ECA5C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25ECA64 Offset: 0x25E8A64 VA: 0x25ECA64
	public void .ctor(short index, int produceId, short point, byte bonus) { }

	// RVA: 0x25ECAAC Offset: 0x25E8AAC VA: 0x25ECAAC Slot: 6
	public void Reconnection(Game engine) { }
}
