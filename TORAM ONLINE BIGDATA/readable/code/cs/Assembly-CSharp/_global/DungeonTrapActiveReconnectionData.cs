// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonTrapActiveReconnectionData : IReconnectionData // TypeDefIndex: 5020
{
	// Fields
	private byte trapId; // 0x10
	private int[] mobList; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EEBB4 Offset: 0x25EABB4 VA: 0x25EEBB4 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EEBBC Offset: 0x25EABBC VA: 0x25EEBBC
	public void .ctor(byte trapId, int[] mobList) { }

	// RVA: 0x25EEBF4 Offset: 0x25EABF4 VA: 0x25EEBF4 Slot: 5
	public void Reconnection(Game engine) { }
}
