// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomBattleStartReconnectionData : IReconnectionData // TypeDefIndex: 4857
{
	// Fields
	private short[] position; // 0x10
	private float rotation; // 0x18
	private EmergencyPositionData emergencyPositionData; // 0x20
	private int[] itemList; // 0x28
	private int[] orbItemList; // 0x30

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB6AC Offset: 0x25E76AC VA: 0x25EB6AC Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB6B4 Offset: 0x25E76B4 VA: 0x25EB6B4
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData, int[] itemList, int[] orbItemList) { }

	// RVA: 0x25EB738 Offset: 0x25E7738 VA: 0x25EB738 Slot: 5
	public void Reconnection(Game engine) { }
}
