// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomLobbyBattleJoinReconnectionData : IReconnectionSubData // TypeDefIndex: 4859
{
	// Fields
	private short[] position; // 0x10
	private float rotation; // 0x18
	private EmergencyPositionData emergencyPositionData; // 0x20

	// Properties
	public byte Code { get; }
	public byte SubCode { get; }

	// Methods

	// RVA: 0x25EB864 Offset: 0x25E7864 VA: 0x25EB864 Slot: 4
	public byte get_Code() { }

	// RVA: 0x25EB86C Offset: 0x25E786C VA: 0x25EB86C Slot: 5
	public byte get_SubCode() { }

	// RVA: 0x25EB874 Offset: 0x25E7874 VA: 0x25EB874
	public void .ctor(short[] position, float rotation, EmergencyPositionData emergencyPositionData) { }

	// RVA: 0x25EB8C8 Offset: 0x25E78C8 VA: 0x25EB8C8 Slot: 6
	public void Reconnection(Game engine) { }
}
