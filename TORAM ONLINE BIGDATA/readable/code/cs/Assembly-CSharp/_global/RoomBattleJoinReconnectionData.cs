// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomBattleJoinReconnectionData : IReconnectionData // TypeDefIndex: 4856
{
	// Fields
	private short[] position; // 0x10
	private float rotation; // 0x18
	private EmergencyPositionData emergencyPositionData; // 0x20

	// Properties
	public byte Code { get; }

	// Methods

	// RVA: 0x25EB634 Offset: 0x25E7634 VA: 0x25EB634 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB63C Offset: 0x25E763C VA: 0x25EB63C
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData) { }

	// RVA: 0x25EB690 Offset: 0x25E7690 VA: 0x25EB690 Slot: 5
	public void Reconnection(Game engine) { }
}
