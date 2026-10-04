// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HouseConstructionReconnectionData : IReconnectionSubData // TypeDefIndex: 4894
{
	// Fields
	private byte floorHeight; // 0x10
	private int[] itemList; // 0x18

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EC69C Offset: 0x25E869C VA: 0x25EC69C Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EC6A4 Offset: 0x25E86A4 VA: 0x25EC6A4 Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EC6AC Offset: 0x25E86AC VA: 0x25EC6AC
	public void .ctor(byte floorHeight, int[] itemList) { }

	// RVA: 0x25EC6E4 Offset: 0x25E86E4 VA: 0x25EC6E4 Slot: 6
	public void Reconnection(Game engine) { }
}
