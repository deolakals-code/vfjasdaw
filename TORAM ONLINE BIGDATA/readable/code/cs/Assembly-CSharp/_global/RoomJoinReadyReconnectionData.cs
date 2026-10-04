// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomJoinReadyReconnectionData : IReconnectionData // TypeDefIndex: 5001
{
	// Fields
	private int[] itemList; // 0x10
	private int[] orbItemList; // 0x18

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EE590 Offset: 0x25EA590 VA: 0x25EE590 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EE598 Offset: 0x25EA598 VA: 0x25EE598
	public void .ctor(int[] itemList, int[] orbItemList) { }

	// RVA: 0x25EE5DC Offset: 0x25EA5DC VA: 0x25EE5DC Slot: 5
	public void Reconnection(Game engine) { }
}
